// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 03-28-2025
// ***********************************************************************
// <copyright file="Validator.Check.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Methods that facilitate the validation of arguments and values,
// ensuring simplicity and accuracy. When invalid data is encountered,
// an Exception will be thrown, providing an appropriate error message,
// either custom or default.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core.Properties;

#nullable enable

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides a set of static methods for performing various validation checks.
/// These methods can throw exceptions if the validation fails and throwException parameter is set to true.
/// </summary>
public static partial class Validator
{

	/// <summary>
	/// Creates the exception message.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="messageFromResource">The message from resource.</param>
	/// <returns>System.String.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static string CreateExceptionMessage(string message, string messageFromResource) => string.IsNullOrEmpty(message) ? messageFromResource : message;

	/// <summary>
	/// Checks if the input type is equal to the expected type.
	/// </summary>
	/// <param name="input">The type to check.</param>
	/// <param name="expectedType">The expected type to compare against.</param>
	/// <param name="throwException">If set to true, throws an exception when the types do not match.</param>
	/// <param name="errorMessage">The error message to use if an exception is thrown. If not provided, a default message is used.</param>
	/// <returns>True if the input type matches the expected type; otherwise, false.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CheckEquals), "David McCarter", "1/31/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Data")]
	public static bool CheckEquals(this Type input, Type expectedType, in bool throwException = false, string errorMessage = ControlChars.EmptyString)
	{
		//TODO: CHANGE TO CHECKTYPEEQUALS IN V10

		var isValid = input == expectedType;

		if (isValid is false && throwException)
		{
			ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorInvalidType), expectedType);
		}

		return isValid;
	}

	/// <summary>
	/// Checks if the specified <see cref="FileInfo" /> exists on the file system.
	/// </summary>
	/// <param name="input">The <see cref="FileInfo" /> to check.</param>
	/// <param name="throwException">If set to true, an exception is thrown if the file does not exist.</param>
	/// <param name="errorMessage">The error message to use if an exception is thrown. If not provided, a default message is used.</param>
	/// <returns>True if the file exists; otherwise, false.</returns>
	/// <exception cref="FileNotFoundException">Thrown if <paramref name="throwException" /> is true and the file does not exist.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CheckExists), "David McCarter", "1/31/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Data")]
	public static bool CheckExists(this FileInfo input, in bool throwException = false, string errorMessage = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNull();

		var isValid = input.Exists;

		return isValid is false && throwException
			? throw ExceptionThrower.CreateFileNotFoundException(CreateExceptionMessage(errorMessage, Resources.ErrorFileNotFound), input.FullName)
			: isValid;
	}

	/// <summary>
	/// Checks if the specified <see cref="DirectoryInfo" /> exists on the file system. Optionally creates the directory if it does not exist.
	/// </summary>
	/// <param name="input">The <see cref="DirectoryInfo" /> to check.</param>
	/// <param name="createDirectory">If set to true, the directory is created if it does not exist.</param>
	/// <param name="throwException">If set to true, an exception is thrown if the directory does not exist and <paramref name="createDirectory" /> is false.</param>
	/// <param name="errorMessage">The error message to use if an exception is thrown. If not provided, a default message is used.</param>
	/// <returns>True if the directory exists or was successfully created; otherwise, false.</returns>
	/// <exception cref="DirectoryNotFoundException">Thrown if <paramref name="throwException" /> is true, <paramref name="createDirectory" /> is false, and the directory does not exist.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CheckExists), "David McCarter", "1/31/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Data")]
	public static bool CheckExists(this DirectoryInfo input, in bool createDirectory = false, in bool throwException = false, string errorMessage = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNull();

		var isValid = Directory.Exists(input.FullName);

		if (isValid is false && throwException)
		{
			ExceptionThrower.ThrowDirectoryNotFoundException(CreateExceptionMessage(errorMessage, input.FullName), input);
		}
		else if (isValid is false && createDirectory)
		{
			input.Create();
			isValid = Directory.Exists(input.FullName);
		}

		return isValid;
	}

	/// <summary>
	/// Checks if the specified condition is true for the input value.
	/// </summary>
	/// <typeparam name="T">The type of the input value.</typeparam>
	/// <param name="input">The input value to check.</param>
	/// <param name="condition">The condition to evaluate against the input value.</param>
	/// <param name="throwException">Indicates whether to throw an exception if the condition is false.</param>
	/// <param name="errorMessage">The error message to use if an exception is thrown. If not provided, a default message is used.</param>
	/// <returns>True if the condition is met; otherwise, false.</returns>
	/// <exception cref="ArgumentException">Thrown if <paramref name="throwException" /> is true and the condition is not met.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CheckIsCondition), "David McCarter", "2/10/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Data")]
	public static bool CheckIsCondition<T>(this T input, in bool condition, in bool throwException = false, string errorMessage = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNull();

		if (condition is false && throwException)
		{
#pragma warning disable CS8604 // Possible null reference argument.
			ExceptionThrower.ThrowInvalidValueException<object>(CreateExceptionMessage(errorMessage, Resources.ErrorInvalidValue), input);
#pragma warning restore CS8604 // Possible null reference argument.
		}

		return condition;
	}

	/// <summary>
	/// Checks if the specified enum value is defined in its enumeration type.
	/// </summary>
	/// <param name="input">The enum value to check.</param>
	/// <param name="throwException">If set to true, throws an exception if the enum value is not defined.</param>
	/// <param name="errorMessage">The error message to use if an exception is thrown. If not provided, a default message is used.</param>
	/// <returns>True if the enum value is defined; otherwise, false.</returns>
	/// <exception cref="ArgumentException">Thrown if <paramref name="throwException" /> is true and the enum value is not defined.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CheckIsDefined), "David McCarter", "1/31/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Data")]
	public static bool CheckIsDefined(this Enum input, in bool throwException = false, string errorMessage = ControlChars.EmptyString)
	{
		var isDefined = input is not null && Enum.IsDefined(input.GetType(), input);

		if (isDefined is false && throwException)
		{
			ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorEnumNotDefined), input);
		}

		return isDefined;
	}

	/// <summary>
	/// Checks if the input value is within the specified range.
	/// </summary>
	/// <param name="input">The input value to check.</param>
	/// <param name="lower">The lower bound of the range.</param>
	/// <param name="upper">The upper bound of the range.</param>
	/// <param name="throwException">If set to true, throws an exception if the input is outside the range.</param>
	/// <param name="errorMessage">The error message to use if an exception is thrown. If not provided, a default message is used.</param>
	/// <returns>True if the input value is within the range; otherwise, false.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="throwException" /> is true and the input value is outside the specified range.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CheckIsInRange), "David McCarter", "1/31/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Data")]
	public static bool CheckIsInRange(this in DateTime input, in DateTime lower, in DateTime upper, in bool throwException = false, string errorMessage = ControlChars.EmptyString)
	{
		var isValid = (input >= lower) && (input <= upper);

		if (isValid is false && throwException)
		{
			ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorDateIsInvalidBasedOnMinMaxDateTime), input);
		}

		return isValid;
	}

	/// <summary>
	/// Checks if the input value is within the specified range.
	/// </summary>
	/// <param name="input">The input value to check.</param>
	/// <param name="lower">The lower bound of the range.</param>
	/// <param name="upper">The upper bound of the range.</param>
	/// <param name="throwException">If set to true, throws an exception if the input is outside the range.</param>
	/// <param name="errorMessage">The error message to use if an exception is thrown. If not provided, a default message is used.</param>
	/// <returns>True if the input value is within the range; otherwise, false.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="throwException" /> is true and the input value is outside the specified range.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CheckIsInRange), "David McCarter", "2/14/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Data")]
	public static bool CheckIsInRange(this in TimeOnly input, in TimeOnly lower, in TimeOnly upper, in bool throwException = false, string errorMessage = ControlChars.EmptyString)
	{
		var isValid = (input >= lower) && (input <= upper);

		if (isValid is false && throwException)
		{
			ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorTimeIsInvalidBasedOnTheMinMaxRange), input);
		}

		return isValid;
	}

	/// <summary>
	/// Checks if the input value is within the specified range.
	/// </summary>
	/// <param name="input">The input value to check.</param>
	/// <param name="lower">The lower bound of the range.</param>
	/// <param name="upper">The upper bound of the range.</param>
	/// <param name="throwException">If set to true, throws an exception if the input is outside the range.</param>
	/// <param name="errorMessage">The error message to use if an exception is thrown. If not provided, a default message is used.</param>
	/// <returns>True if the input value is within the range; otherwise, false.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="throwException" /> is true and the input value is outside the specified range.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CheckIsInRange), "David McCarter", "2/14/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Data")]
	public static bool CheckIsInRange(this in DateOnly input, in DateOnly lower, in DateOnly upper, in bool throwException = false, string errorMessage = ControlChars.EmptyString)
	{
		var isValid = (input >= lower) && (input <= upper);

		if (!isValid && throwException)
		{
			ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorDateIsInvalidBasedOnTheMinMaxRange), input);
		}

		return isValid;
	}

	/// <summary>
	/// Checks if the input value is within the specified range.
	/// </summary>
	/// <param name="input">The input value to check.</param>
	/// <param name="lower">The lower bound of the range.</param>
	/// <param name="upper">The upper bound of the range.</param>
	/// <param name="throwException">If set to true, throws an exception if the input is outside the range.</param>
	/// <param name="errorMessage">The error message to use if an exception is thrown. If not provided, a default message is used.</param>
	/// <returns>True if the input value is within the range; otherwise, false.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="throwException" /> is true and the input value is outside the specified range.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CheckIsInRange), "David McCarter", "2/3/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Data")]
	public static bool CheckIsInRange(this int input, int lower, int upper, in bool throwException = false, string errorMessage = ControlChars.EmptyString)
	{
		var isValid = (input >= lower) && (input <= upper);

		if (isValid is false && throwException)
		{
			ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), input);
		}

		return isValid;
	}

	/// <summary>
	/// Checks if the input value is within the specified range.
	/// </summary>
	/// <param name="input">The input value to check.</param>
	/// <param name="lower">The lower bound of the range.</param>
	/// <param name="upper">The upper bound of the range.</param>
	/// <param name="throwException">If set to true, throws an exception if the input is outside the range.</param>
	/// <param name="errorMessage">The error message to use if an exception is thrown. If not provided, a default message is used.</param>
	/// <returns>True if the input value is within the range; otherwise, false.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="throwException" /> is true and the input value is outside the specified range.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CheckIsInRange), "David McCarter", "2/14/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Data")]
	public static bool CheckIsInRange(this in long input, in long lower, in long upper, in bool throwException = false, string errorMessage = ControlChars.EmptyString)
	{
		var isValid = (input >= lower) && (input <= upper);

		if (isValid is false && throwException)
		{
			ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), input);
		}

		return isValid;
	}

	/// <summary>
	/// Checks if the input value is within the specified range.
	/// </summary>
	/// <param name="input">The input value to check.</param>
	/// <param name="lower">The lower bound of the range.</param>
	/// <param name="upper">The upper bound of the range.</param>
	/// <param name="throwException">If set to true, throws an exception if the input is outside the range.</param>
	/// <param name="errorMessage">The error message to use if an exception is thrown. If not provided, a default message is used.</param>
	/// <returns>True if the input value is within the range; otherwise, false.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="throwException" /> is true and the input value is outside the specified range.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CheckIsInRange), "David McCarter", "2/14/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Data")]
	public static bool CheckIsInRange(this in double input, in double lower, in double upper, in bool throwException = false, string errorMessage = ControlChars.EmptyString)
	{
		var isValid = (input >= lower) && (input <= upper);

		if (isValid is false && throwException)
		{
			ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), input);
		}

		return isValid;
	}

	/// <summary>
	/// Checks if the input value is within the specified range.
	/// </summary>
	/// <param name="input">The input value to check.</param>
	/// <param name="lower">The lower bound of the range.</param>
	/// <param name="upper">The upper bound of the range.</param>
	/// <param name="throwException">If set to true, throws an exception if the input is outside the range.</param>
	/// <param name="errorMessage">The error message to use if an exception is thrown. If not provided, a default message is used.</param>
	/// <returns>True if the input value is within the range; otherwise, false.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="throwException" /> is true and the input value is outside the specified range.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CheckIsInRange), "David McCarter", "2/14/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Data")]
	public static bool CheckIsInRange(this in decimal input, in decimal lower, in decimal upper, in bool throwException = false, string errorMessage = ControlChars.EmptyString)
	{
		var isValid = (input >= lower) && (input <= upper);

		if (isValid is false && throwException)
		{
			ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), input);
		}

		return isValid;
	}

	/// <summary>
	/// Checks if the input value is within the specified range.
	/// </summary>
	/// <param name="input">The input value to check.</param>
	/// <param name="lower">The lower bound of the range.</param>
	/// <param name="upper">The upper bound of the range.</param>
	/// <param name="throwException">If set to true, throws an exception if the input is outside the range.</param>
	/// <param name="errorMessage">The error message to use if an exception is thrown. If not provided, a default message is used.</param>
	/// <returns>True if the input value is within the range; otherwise, false.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="throwException" /> is true and the input value is outside the specified range.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CheckIsInRange), "David McCarter", "1/31/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Data")]
	public static bool CheckIsInRange(this in DateTimeOffset input, in DateTimeOffset lower, in DateTimeOffset upper, in bool throwException = false, string errorMessage = ControlChars.EmptyString)
	{
		var isValid = (input >= lower) && (input <= upper);

		if (isValid is false && throwException)
		{
			ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorDateIsInvalidBasedOnMinMaxDateTime), input);
		}

		return isValid;
	}

	/// <summary>
	/// Determines whether the <see cref="ReadOnlySpan{T}" /> is not empty.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="ReadOnlySpan{T}" /> to validate.</param>
	/// <param name="throwException">if set to <c>true</c> [throws exception].</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <returns><c>true</c> if [is not empty] [the specified span]; otherwise, <c>false</c>.</returns>
	/// <exception cref="InvalidOperationException">Input cannot be empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CheckIsNotEmpty), "David McCarter", "6/26/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Data")]
	public static bool CheckIsNotEmpty<T>([NotNull] this ReadOnlySpan<T> input, in bool throwException = false, string errorMessage = ControlChars.EmptyString)
	{
		var isValid = input.IsEmpty is false;

		if (isValid is false && throwException)
		{
			ExceptionThrower.ThrowInvalidOperationException(CreateExceptionMessage(errorMessage, Resources.ErrorSpanIsEmpty));
		}

		return isValid;
	}

	/// <summary>
	/// Determines whether the specified <see cref="Guid" /> is not empty.
	/// </summary>
	/// <param name="input">The <see cref="Guid" /> to validate.</param>
	/// <param name="throwException">if set to <c>true</c>, throws an exception if the Guid is empty.</param>
	/// <param name="errorMessage">The error message to be used in the exception message. If not provided, a default message is used.</param>
	/// <returns><c>true</c> if the specified Guid is not empty; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentException">Thrown when <paramref name="input" /> is empty and <paramref name="throwException" /> is true.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CheckIsNotEmpty), "David McCarter", "2/2/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Data")]
	public static bool CheckIsNotEmpty([NotNull] this Guid input, in bool throwException = false, string errorMessage = ControlChars.EmptyString)
	{
		var isValid = input.Equals(Guid.Empty) is false;

		if (isValid is false && throwException)
		{
			ExceptionThrower.ThrowInvalidOperationException(CreateExceptionMessage(errorMessage, Resources.ErrorGUIDIsEmpty));
		}

		return isValid;
	}

	/// <summary>
	/// Checks if the input value is not null.
	/// </summary>
	/// <typeparam name="T">The type of the input value.</typeparam>
	/// <param name="input">The input value to check.</param>
	/// <param name="throwException">If set to true, throws an exception if the input is null.</param>
	/// <param name="errorMessage">The error message to use if an exception is thrown. If not provided, a default message is used.</param>
	/// <returns>True if the input value is not null; otherwise, false.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="throwException" /> is true and the input value is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CheckIsNotNull), "David McCarter", "2/10/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Data")]
	public static bool CheckIsNotNull<T>(this T input, in bool throwException = false, string errorMessage = ControlChars.EmptyString) where T : class
	{
		var isValid = input != null;

		if (isValid is false && throwException)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorObjectCannotBeNull));
		}

		return isValid;
	}

	/// <summary>
	/// Checks if the input <see cref="IEnumerable{T}" /> contains any items.
	/// </summary>
	/// <typeparam name="T">The type of the items in the enumerable.</typeparam>
	/// <param name="input">The enumerable to check.</param>
	/// <param name="throwException">If set to true, throws an exception if the enumerable is empty.</param>
	/// <param name="errorMessage">The error message to use if an exception is thrown. If not provided, a default message is used.</param>
	/// <returns>True if the enumerable contains any items; otherwise, false.</returns>
	/// <exception cref="ArgumentException">Thrown if <paramref name="throwException" /> is true and the enumerable is empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CheckItemsExists), "David McCarter", "4/14/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Data")]
	public static bool CheckItemsExists<T>(this IEnumerable<T> input, in bool throwException = false, string errorMessage = ControlChars.EmptyString)
	{
		var isValid = input?.Count() > 0;

		if (isValid is false && throwException)
		{
			ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), input);
		}

		return isValid;
	}

}
