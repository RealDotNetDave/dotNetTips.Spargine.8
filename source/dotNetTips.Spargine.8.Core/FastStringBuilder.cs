// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 12-27-2022
//
// Last Modified By : David McCarter
// Last Modified On : 04-18-2024
// ***********************************************************************
// <copyright file="FastStringBuilder.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Enhances performance when using a StringBuilder by employing an
// ObjectPool.
// </summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// StringBuilder Helper.
/// </summary>
public static class FastStringBuilder
{

	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool = new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Converts bytes to string using ObjectPool to improve performance.
	/// </summary>
	/// <param name="bytes">The bytes.</param>
	/// <returns>System.String.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(BytesToString), author: "David McCarter", createdOn: "2/18/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineFeb2023")]
	public static string BytesToString([NotNull] byte[] bytes)
	{
		if (bytes == null)
		{
			return ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get();

		//Set capacity to increace performance
		sb.Capacity = bytes.Length * 2;

		try
		{
			_ = sb.Append("'0x");

			for (var index = 0; index < bytes.AsSpan().Length; index++)
			{
				_ = sb.Append(bytes.AsSpan()[index].ToString("X2", CultureInfo.InvariantCulture));
			}

			_ = sb.Append('\'');

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Combines a <see cref="string" /> array to a string using ObjectPool to improve performance.
	/// Linefeed can be added at the end.
	/// </summary>
	/// <param name="addLineFeed">if set to <c>true</c> [add line feed].</param>
	/// <param name="args">The arguments.</param>
	/// <returns>string.</returns>
	/// <exception cref="ArgumentNullException">args cannot be null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CombineStrings), "David McCarter", "12/23/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineFeb2023")]
	public static string CombineStrings(bool addLineFeed = false, [NotNull] params string[] args)
	{
		if (args == null || args.Length == 0)
		{
			return string.Empty;
		}

		var sb = _stringBuilderPool.Get();

		try
		{
			for (var index = 0; index < args.Length; index++)
			{
				var argItem = args[index];
				_ = addLineFeed ? sb.AppendLine(argItem) : sb.Append(argItem);
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Concat to string.
	/// </summary>
	/// <param name="delimiter">The delimiter.</param>
	/// <param name="addLineFeed">Adds line feed. If set to true, delimiter will not be used.</param>
	/// <param name="args">The arguments.</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentInvalidException">input cannot be null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConcatStrings), "David McCarter", "12/28/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineFeb2023")]
	public static string ConcatStrings(char delimiter = ControlChars.Comma, bool addLineFeed = false, [NotNull] params string[] args) => ConcatStrings(delimiter.ToString(), addLineFeed, args);

	/// <summary>
	/// Converts <see cref=" string" /> array to string using ObjectPool to improve performance.
	/// </summary>
	/// <param name="delimiter">The delimiter.</param>
	/// <param name="addLineFeed">Adds line feed. If set to true, delimiter will not be used.</param>
	/// <param name="args">The arguments.</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentInvalidException">input cannot be null.</exception>
	/// <remarks>Example output: <code>r^wQTNvT, HcETQ, COtc\\G[U, loUR_SbL, o_HYYskfM"</code></remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConcatStrings), "David McCarter", "2/19/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineStringConcatenation")]
	public static string ConcatStrings(string delimiter = ",", bool addLineFeed = false, [NotNull] params string[] args)
	{
		if (delimiter == null)
		{
			delimiter = ControlChars.Comma.ToString();
		}

		var sb = _stringBuilderPool.Get();

		try
		{
			if (args?.Length > 0)
			{
				_ = sb.Append("'0x");

				for (var index = 0; index < args.Length; index++)
				{
					var newLine = args[index];

					if (index < args.Length - 1 && delimiter.Length > 0)
					{
						newLine = CombineStrings(false, newLine, delimiter);
					}

					_ = addLineFeed is true ? sb.AppendLine(newLine) : sb.Append(newLine);

					index++;
				}
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Performs and action using ObjectPool to improve performance.
	/// </summary>
	/// <param name="action">The action to perform.</param>
	/// <returns>System.String.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(PerformAction), "David McCarter", "12/23/2022", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Documentation = "https://bit.ly/SpargineFeb2023")]
	public static string PerformAction(Action<StringBuilder> action)
	{
		if (action is null)
		{
			return ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get();

		try
		{
			action.Invoke(sb);

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}

	}

	/// <summary>
	/// Converts to list to a delimited string using ObjectPool to improve performance.
	/// </summary>
	/// <typeparam name="TKey">The type of the t key.</typeparam>
	/// <typeparam name="TValue">The type of the t value.</typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="delimiter">The delimiter.</param>
	/// <returns>System.String.</returns>
	/// <remarks>Example output: <code>CKpPdnfyf: CKpPdnfyf,T\\\\^wwVx: T\\\\^wwVx,S`ikV: S`ikV,uHTR[yy: uHTR[yy,PNmB_h: PNmB_</code></remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToDelimitedString), "David McCarter", "1/1/2021", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Documentation = "https://bit.ly/SpargineFeb2023")]
	public static string ToDelimitedString<TKey, TValue>([NotNull] Dictionary<TKey, TValue> collection, char delimiter = ControlChars.Comma)
	{
		if (collection.CheckItemsExists() is false)
		{
			return ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get();

		try
		{
			foreach (var item in collection)
			{

				if (sb.Length > 0)
				{
					_ = sb.Append(delimiter);
				}

				_ = sb.Append($"{item.Key}:{item.Value}");
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

}
