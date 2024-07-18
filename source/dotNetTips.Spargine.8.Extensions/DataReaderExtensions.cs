// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-18-2024
// ***********************************************************************
// <copyright file="DataReaderExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for DataReader.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;
using DotNetTips.Spargine.Core;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="IDataReader"/> instances, enhancing functionality with additional utility methods.
/// </summary>
/// <remarks>
/// This class includes methods for converting data readers to other formats, such as CSV, with performance optimizations
/// such as using a <see cref="ObjectPool{T}"/> for <see cref="StringBuilder"/> instances to reduce memory allocations.
/// </remarks>
public static class DataReaderExtensions
{

	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool =
	new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Converts <see cref="IDataReader" /> to CSV format using <see cref="ObjectPool&lt;StringBuilder&gt;" /> to improve performance.
	/// Validates that <paramref name="dataReader" /> is not null
	/// </summary>
	/// <param name="dataReader">The data reader.</param>
	/// <param name="includeHeaderAsFirstRow">if set to <c>true</c> [include header as first row].</param>
	/// <param name="separator">The separator.</param>
	/// <returns>ReadOnlyCollection&lt;System.String&gt;.</returns>
	[Information(nameof(ToCsv), author: "David McCarter", createdOn: "10/8/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static ReadOnlyCollection<string> ToCsv([NotNull] this IDataReader dataReader, bool includeHeaderAsFirstRow, char separator = ControlChars.Comma)
	{
		dataReader = dataReader.ArgumentNotNull();

		var convertedRows = new List<string>();

		if (includeHeaderAsFirstRow)
		{
			var sb = _stringBuilderPool.Get();

			try
			{
				for (var fieldIndex = 0; fieldIndex <= dataReader.FieldCount - 1; fieldIndex++)
				{
					if (dataReader.GetName(fieldIndex) is not null)
					{
						_ = sb.Append(dataReader.GetName(fieldIndex));
					}

					if (fieldIndex < dataReader.FieldCount - 1)
					{
						_ = sb.Append(separator);
					}
				}

				convertedRows.Add(sb.ToString());
			}
			finally
			{
				_stringBuilderPool.Return(sb);
			}
		}

		while (dataReader.Read())
		{
			var sb = _stringBuilderPool.Get();

			try
			{
				for (var fieldIndex = 0; fieldIndex <= dataReader.FieldCount - 2; fieldIndex++)
				{
					if (!dataReader.IsDBNull(fieldIndex))
					{
						var value = dataReader.GetValue(fieldIndex).ToString();
						if (dataReader.GetFieldType(fieldIndex) == typeof(string))
						{
							// If double quotes are used in value, ensure each are replaced but 2.
							if (value.Contains(ControlChars.Backslash, StringComparison.Ordinal))
							{
								value = value.Replace("\"", "\"\"", StringComparison.Ordinal);
							}

							// If separator are is in value, ensure it is put in double quotes.
							if (value.Contains(separator, StringComparison.CurrentCulture))
							{
								value = $"{Convert.ToString(ControlChars.Backslash, CultureInfo.InvariantCulture)}{value}{ControlChars.Backslash}";
							}
						}

						_ = sb.Append(value);
					}

					if (fieldIndex < dataReader.FieldCount - 1)
					{
						_ = sb.Append(separator);
					}
				}

				if (!dataReader.IsDBNull(dataReader.FieldCount - 1))
				{
					_ = sb.Append(dataReader.GetValue(dataReader.FieldCount - 1).ToString().Replace(separator, ControlChars.Space));
				}

				convertedRows.Add(sb.ToString());
			}
			finally
			{
				_stringBuilderPool.Return(sb);
			}
		}

		return convertedRows.AsReadOnly();
	}

}
