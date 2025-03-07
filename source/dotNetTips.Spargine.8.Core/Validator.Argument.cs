// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 02-16-2022
//
// Last Modified By : David McCarter
// Last Modified On : 03-07-2025
// ***********************************************************************
// <copyright file="Validator.Argument.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Methods facilitating the validation of arguments and values,
// ensuring both simplicity and accuracy. In the event of encountering
// invalid data, an Exception will be thrown, accompanied by an
// appropriate error message, which can be either custom or default.
// </summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

#nullable enable
namespace DotNetTips.Spargine.Core;

/// <summary>
/// Class to validate method parameters.
/// </summary>
[Information(Status = Status.NeedsDocumentation)]
public static partial class Validator
{

	/// <summary>
	/// The invalid string length format
	/// </summary>
	private const string InvalidStringLengthFormat = "Invalid string length. Acceptable range is between {0} and {1}.";

	/// <summary>
	/// Creates the exception message.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <param name="messageFromResource">The message from resource.</param>
	/// <returns>System.String.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static string CreateParamExceptionMessage(string message, string paramName, string messageFromResource)
	{
		var returnMessage = $"{paramName}: ";

		return message switch
		{
			null => $"{returnMessage}{messageFromResource}",
			_ => $"{returnMessage}{message}"
		};
	}

	/// <summary>
	/// Tries to validate the <see cref="Enum" /> input.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="Enum" /> input to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>Enum.</returns>
	/// <exception cref="ArgumentException">Input cannot be null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">The value is not defined in the enum type.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentDefined), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static T ArgumentDefined<T>([NotNull] this T input, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "") where T : Enum
	{
		var isValid = Enum.IsDefined(input.ArgumentNotNull().GetType(), input);

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorEnumNotDefined), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries to validate that the <see cref="Type" /> matches the expected <see cref="Type" />.
	/// </summary>
	/// <param name="input">The <see cref="Type" /> to validate.</param>
	/// <param name="expectedType">The expected <see cref="Type" />.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>Type.</returns>
	/// <exception cref="ArgumentInvalidException">Validation failed for Input.</exception>
	/// <exception cref="ArgumentException">Input cannot be null.</exception>
	/// <exception cref="ArgumentException">Expected Type cannot be null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentEquals), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static Type ArgumentEquals([NotNull] this Type input, [NotNull] Type expectedType, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		input = input.ArgumentNotNull();
		expectedType = expectedType.ArgumentNotNull();

		if (input.CheckEquals(expectedType) is false)
		{
			ExceptionThrower.ThrowArgumentInvalidException(CreateExceptionMessage(errorMessage, Resources.ErrorInvalidType), paramName);
		}

		return input!;
	}

	/// <summary>
	/// Checks that the <see cref="DirectoryInfo" /> exists.
	/// </summary>
	/// <param name="input">The <see cref="DirectoryInfo" /> to validate.</param>
	/// <param name="defaultValue">The default value that will be returned if the directory does not exist.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.IO.DirectoryInfo.</returns>
	/// <exception cref="ArgumentNullException">Input cannot be null.</exception>
	/// <exception cref="DirectoryNotFoundException">Directory not found.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentExists), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static DirectoryInfo ArgumentExists([NotNull] this DirectoryInfo input, DirectoryInfo? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		input = input.ArgumentNotNull();

		var isValid = input.Exists;

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue!;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowDirectoryNotFoundException(CreateParamExceptionMessage(errorMessage, paramName, $"{Resources.ErrorDirectoryDoesNotExist} Directory:{input.FullName}"), input);
		}

		return input;
	}

	/// <summary>
	/// Validates that the <see cref="FileInfo" /> exists.
	/// </summary>
	/// <param name="input">The <see cref="FileInfo" /> to validate.</param>
	/// <param name="defaultValue">The default <see cref="FileInfo" /> value that will be returned if the file does not exist.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>A valid <see cref="FileInfo" /> object.</returns>
	/// <exception cref="FileNotFoundException">File cannot be found.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentExists), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static FileInfo ArgumentExists([NotNull] this FileInfo input, FileInfo? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		input = input.ArgumentNotNull();

		var isValid = input.CheckExists();

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue!;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowFileNotFoundException(CreateParamExceptionMessage(errorMessage, paramName, Resources.ErrorFileNotFound), input.FullName);
		}

		return input;
	}

	/// <summary>
	/// Validates the <see cref="byte" /> is in range.
	/// </summary>
	/// <param name="input">The <see cref="byte" /> input to validate.</param>
	/// <param name="lower">The minimum value. Default = 0.</param>
	/// <param name="upper">The maximum value.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.Byte.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation of lower or upper failed.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "1/29/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static byte ArgumentInRange(this in byte input, in byte lower = byte.MinValue, in byte upper = byte.MaxValue, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsInRange(lower, upper);

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), paramName);
		}

		return input;
	}
	/// <summary>
	/// Tries the validate <see cref="DateTime" /> parameter.
	/// </summary>
	/// <param name="input">The <see cref="DateTime" /> to validate.</param>
	/// <param name="lower">The minimum date time.</param>
	/// <param name="upper">The maximum date time.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>DateTime.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation failed for lower or uppper.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "1/21/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static DateTime ArgumentInRange(this DateTime input, in DateTime lower, in DateTime upper, in DateTime? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsInRange(lower, upper);

		if (isValid is false && defaultValue.HasValue)
		{
			input = defaultValue.GetValueOrDefault();
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorDateIsInvalidBasedOnMinMaxDateTime), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries the validate <see cref="DateTimeOffset" /> parameter.
	/// </summary>
	/// <param name="input">The <see cref="DateTimeOffset" /> to validate.</param>
	/// <param name="lower">The minimum date time.</param>
	/// <param name="upper">The maximum date time.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>DateTimeOffset.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation failed for lower or uppper.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "1/21/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static DateTimeOffset ArgumentInRange(this DateTimeOffset input, in DateTimeOffset lower, in DateTimeOffset upper, in DateTimeOffset? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsInRange(lower, upper);

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue!.Value;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorDateIsInvalidBasedOnMinMaxDateTime), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries the validate an <see cref="int" /> value.
	/// </summary>
	/// <param name="input">The <see cref="int" /> to validate</param>
	/// <param name="lower">The minimum value. Default = 0.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <param name="upper">The maximum value.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <returns>System.Int32.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation failed for lower or uppper.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static int ArgumentInRange(this int input, in int lower = 0, [CallerArgumentExpression(nameof(input))] string paramName = "", in int upper = int.MaxValue, in int? defaultValue = null, string errorMessage = "")
	{
		var isValid = input.CheckIsInRange(lower, upper);

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue!.Value;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries the validate a <see cref="double" /> parameter.
	/// </summary>
	/// <param name="input">The <see cref="double" /> to validate.</param>
	/// <param name="lower">The minimum value. Default = 0.</param>
	/// <param name="upper">The maximum value.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.Double.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation failed for lower or uppper.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static double ArgumentInRange(this double input, in double lower = 0, in double upper = double.MaxValue, in double? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsInRange(lower, upper);

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue!.Value;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries the validate a <see cref="long" /> parameter.
	/// </summary>
	/// <param name="input">The <see cref="long" /> to validate.</param>
	/// <param name="lower">The minimum value. Default = 0.</param>
	/// <param name="upper">The maximum value.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.Int64.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation failed for lower or uppper.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static long ArgumentInRange(this long input, in long lower = 0, in long upper = long.MaxValue, in long? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsInRange(lower, upper);

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue!.Value;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries the validate a <see cref="decimal" /> input.
	/// </summary>
	/// <param name="input">The <see cref="decimal" /> to validate.</param>
	/// <param name="lower">The minimum value.</param>
	/// <param name="upper">The maximum value.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.Decimal.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation failed for lower or uppper.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static decimal ArgumentInRange(this decimal input, in decimal lower = 0, in decimal upper = decimal.MaxValue, in decimal? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsInRange(lower, upper);

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue!.Value;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries to validate the <see cref="DateOnly" /> input.
	/// </summary>
	/// <param name="input">The <see cref="DateOnly" /> input to validate.</param>
	/// <param name="lower">The minimum date.</param>
	/// <param name="upper">The maximum date.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>DateOnly.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation failed for lower or uppper.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "2/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static DateOnly ArgumentInRange(this DateOnly input, in DateOnly lower, in DateOnly upper, in DateOnly? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsInRange(lower, upper);

		if (isValid is false && defaultValue.HasValue)
		{
			input = defaultValue.GetValueOrDefault();
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorDateIsInvalidBasedOnMinMaxDateTime), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries to validate the <see cref="TimeOnly" /> input.
	/// </summary>
	/// <param name="input">The <see cref="TimeOnly" /> to validate.</param>
	/// <param name="lower">The minimum time.</param>
	/// <param name="upper">The maximum time.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>TimeOnly.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation failed for lower or uppper.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "2/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static TimeOnly ArgumentInRange(this TimeOnly input, in TimeOnly lower, in TimeOnly upper, in TimeOnly? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input!.CheckIsInRange(lower, upper);

		if (isValid is false && defaultValue.HasValue)
		{
			input = defaultValue.GetValueOrDefault();
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorTimeIsInvalidBasedOnTheMinMaxRange), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries to validate the <see cref="string" /> input.
	/// </summary>
	/// <param name="input">The <see cref="string" /> to validate.</param>
	/// <param name="lower">The minimum length.</param>
	/// <param name="upper">The maximum length.</param>
	/// <param name="trim">if set to <c>true</c> trims the string.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentInvalidException">Input cannot be null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Minimum length is not valid.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Value is not within range.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentInRange), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static string ArgumentInRange([NotNull] this string input, int lower = 0, int upper = int.MaxValue, bool trim = true, string? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsNotNull() && input!.Length.CheckIsInRange(lower, upper);

		if (isValid is false && string.IsNullOrEmpty(defaultValue) is false)
		{
			input = defaultValue;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, string.Format(CultureInfo.CurrentCulture, InvalidStringLengthFormat, lower, upper)), paramName);
		}

		return trim ? input!.Trim() : input!;
	}

	/// <summary>
	/// Tries to validate the <see cref="IEnumerable{T}" /> is not null and has items.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="IEnumerable{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>IEnumerable.</returns>
	/// <exception cref="ArgumentNullException">Collection is null or has no items.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentItemsExists), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static IEnumerable<T> ArgumentItemsExists<T>([NotNull] this IEnumerable<T> input, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckItemsExists();

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), paramName);
		}

		return input!;
	}

	/// <summary>
	/// Arguments the items exists.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The input.</param>
	/// <param name="errorMessage">The error message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>IReadOnlyList&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">Input cannot be empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentItemsExists), "David McCarter", "5/25/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static IReadOnlyList<T> ArgumentItemsExists<T>(this IReadOnlyList<T> input, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckItemsExists();

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), paramName);
		}

		return input!;
	}

	/// <summary>
	/// Arguments the items exists.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The input.</param>
	/// <param name="errorMessage">The error message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>IReadOnlyCollection&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">Input cannot be empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentItemsExists), "David McCarter", "5/27/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static IReadOnlyCollection<T> ArgumentItemsExists<T>(this IReadOnlyCollection<T> input, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckItemsExists();

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), paramName);
		}

		return input!;
	}

	/// <summary>
	/// Tries to validate the <see cref="List{T}" /> has items.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="List{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>IEnumerable.</returns>
	/// <exception cref="ArgumentNullException">Collection is null or has no items.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentItemsExists), "David McCarter", "2/17/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static List<T> ArgumentItemsExists<T>([NotNull] this List<T> input, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckItemsExists();

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), paramName);
		}

		return input!;
	}

	/// <summary>
	/// Tries to validate the array has items.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The array to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>T[].</returns>
	/// <exception cref="ArgumentNullException">Input cannot be empty.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentItemsExists), "David McCarter", "2/4/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static T[] ArgumentItemsExists<T>([NotNull] this T[] input, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckItemsExists();

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionSizeIsNotValid), paramName);
		}

		return input!;
	}

	/// <summary>
	/// Tries to validate the <see cref="IEnumerable{T}" /> has the given count.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="IEnumerable{T}" /> to validate.</param>
	/// <param name="count">The count.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>IEnumerable&lt;T&gt;.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Validation failed due to invalid count.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentItemsExists), "David McCarter", "4/4/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static IEnumerable<T> ArgumentItemsExists<T>([NotNull] this IEnumerable<T> input, [ConstantExpected(Min = 0, Max = long.MaxValue)] in long count, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		input = input.ArgumentNotNull();

		var isValid = input!.TryGetNonEnumeratedCount(out var collectionCount) && collectionCount == count;

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, "Collection has no items."), paramName);
		}

		return input!;
	}

	/// <summary>
	/// Tries to validate the <see cref="string" /> input. Trims the string.
	/// </summary>
	/// <param name="input">The <see cref="string" /> to validate.</param>
	/// <param name="match">The match.</param>
	/// <param name="trim">if set to <c>true</c> trims the string.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentException">'input' cannot be null or empty.</exception>
	/// <exception cref="ArgumentNullException">'match' cannot be null or empty.</exception>
	/// <exception cref="ArgumentInvalidException">Argument not matched.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentMatched), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static string ArgumentMatched([NotNull] this string input, [NotNull] Regex match, bool trim = true, string? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		input = input!.ArgumentNotNullOrEmpty();
		match = match.ArgumentNotNull();

		var isValid = match!.IsMatch(input);

		if (isValid is false && string.IsNullOrEmpty(defaultValue) is false)
		{
			input = defaultValue; // Not being tested 
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentInvalidException(CreateExceptionMessage(errorMessage, Resources.ErrorStringIsNotValid), paramName);
		}

		return trim ? input!.Trim() : input!;
	}

	/// <summary>
	/// Checks a condition against the input.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The input to validate.</param>
	/// <param name="condition">if set to <c>true</c> [condition].</param>
	/// <param name="defaultValue">The default value to be returned if condition failed.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>T.</returns>
	/// <exception cref="ArgumentInvalidException">Codition failed.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentMeetsCondition), "David McCarter", "4/4/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static T ArgumentMeetsCondition<T>(this T input, in bool condition, T? defaultValue = default, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input is not null && condition;

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue!;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentInvalidException(CreateExceptionMessage(errorMessage, Resources.ErrorInvalidValue), paramName);
		}

		return input!;
	}

	/// <summary>
	/// Determines whether the <see cref="ReadOnlySpan{T}" /> is empty.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="ReadOnlySpan{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>ReadOnlySpan&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">Argument is empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentNotEmpty), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static ReadOnlySpan<T> ArgumentNotEmpty<T>([NotNull] this ReadOnlySpan<T> input, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		if (input.CheckIsNotEmpty() is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorReadOnlySpanCannotBeNull), paramName);
		}

		return input;
	}

	/// <summary>
	/// Determines whether the <see cref="Span{T}" /> is empty.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="Span{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>Span&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">Input is empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentNotEmpty), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static Span<T> ArgumentNotEmpty<T>([NotNull] this Span<T> input, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		if (input.IsEmpty)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorSpanCannotBeNullOrEmpty), paramName);
		}

		return input;
	}

	/// <summary>
	/// Validates the <see cref="Collection{T}" /> is not read only.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="Collection{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>Collections.Generic.Collection&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">Input cannot be null.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentNotNull), "David McCarter", "10/24/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug23")]
	public static Collection<T> ArgumentNotNull<T>([NotNull] this Collection<T> input, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		if (input is null)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), paramName);
		}

		return input!;
	}

	/// <summary>
	/// Validates the input is not <see langword="null" />.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The input to validate.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="ArgumentNullException">Input cannot be null.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentNotNull), "David McCarter", "2/10/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static T ArgumentNotNull<T>(this T input, T? defaultValue = default, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input is not null;

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateParamExceptionMessage(errorMessage, paramName, Resources.ErrorObjectCannotBeNull));
		}

		return input!;
	}

	/// <summary>
	/// Tries the validate that the <see cref="Uri" /> is not null.
	/// </summary>
	/// <param name="input">The <see cref="Uri" /> to validate.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>Uri.</returns>
	/// <exception cref="ArgumentNullException">Input cannot be null.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentNotNull), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static Uri ArgumentNotNull([NotNull] this Uri input, [AllowNull] Uri? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsNotNull();

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorUriCannotBeNull), paramName);
		}

		return input!;
	}

	/// <summary>
	/// Tries to validate the <see cref="Guid" /> is not empty.
	/// </summary>
	/// <param name="input">The <see cref="Guid" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>Guid.</returns>
	/// <exception cref="ArgumentInvalidException">Guid cannot be empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentNotNullOrEmpty), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static Guid ArgumentNotNullOrEmpty([NotNull] this Guid input, string errorMessage = "", [AllowNull] Guid? defaultValue = null, [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsNotEmpty();

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue.Value;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentInvalidException(CreateExceptionMessage(errorMessage, Resources.ErrorGuidIsNullOrEmpty), paramName);
		}

		return input;
	}

	/// <summary>
	/// Validates that the provided string is not null or empty. Optionally trims the string before validation.
	/// </summary>
	/// <param name="input">The string to validate.</param>
	/// <param name="trim">Indicates whether to trim the string before validation. Default is true.</param>
	/// <param name="defaultValue">The default value to return if the input is null or empty. This parameter is optional.</param>
	/// <param name="errorMessage">The error message to use if validation fails. If not provided, a default message is used.</param>
	/// <param name="paramName">The name of the parameter being validated. This is automatically provided and typically does not need to be specified manually.</param>
	/// <returns>The input string if it is not null or empty.</returns>
	/// <exception cref="ArgumentNullException">Thrown if the input string is null.</exception>
	/// <exception cref="ArgumentException">Thrown if the input string is empty.</exception>
	/// <example>
	/// Here is an example of using <c>ArgumentNotNullOrEmpty</c>:
	/// <code>
	/// string name = "John Doe";
	/// name = Validator.ArgumentNotNullOrEmpty(name, trim: true, errorMessage: "Name cannot be empty");
	/// </code></example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentNotNullOrEmpty), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static string ArgumentNotNullOrEmpty([NotNull] this string input, bool trim = true, [AllowNull] string? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = string.IsNullOrEmpty(input) is false;

		if (isValid is false && string.IsNullOrEmpty(defaultValue) is false)
		{
			input = defaultValue;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorStringIsNullOrEmpty), paramName);
		}

		return trim ? input.Trim() : input;
	}

	/// <summary>
	/// Validates the <see cref="IList{T}" /> is not read only.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="IList{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>IList&lt;T&gt;.</returns>
	/// <exception cref="ArgumentReadOnlyException">Input cannot be read-only.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentNotReadOnly), "David McCarter", "1/29/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static IList<T> ArgumentNotReadOnly<T>(this IList<T> input, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input is not null && input.IsReadOnly is false;

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentReadOnlyException(CreateExceptionMessage(errorMessage, Resources.ErrorListCannotBeReadOnly), paramName);
		}

		return input!;
	}

	/// <summary>
	/// Validates the <see cref="ICollection{T}" /> is not read only.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="ICollection{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>ICollection&lt;T&gt;.</returns>
	/// <exception cref="ArgumentReadOnlyException">Input cannot be read-only.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ArgumentNotReadOnly), "David McCarter", "1/28/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	public static ICollection<T> ArgumentNotReadOnly<T>(this ICollection<T> input, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input is not null && input!.IsReadOnly is false;

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentReadOnlyException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), paramName);
		}

		return input!;
	}

}
