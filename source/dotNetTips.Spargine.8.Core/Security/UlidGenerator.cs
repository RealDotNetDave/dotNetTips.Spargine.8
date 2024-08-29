// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 08-03-2024
//
// Last Modified By : David McCarter
// Last Modified On : 08-29-2024
// ***********************************************************************
// <copyright file="UlidGenerator.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Security.Cryptography;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Security;

/// <summary>
/// Provides methods to generate and manipulate ULIDs (Universally Unique Lexicographically Sortable Identifiers).
/// </summary>
/// <remarks>
/// This class includes methods to generate single or multiple ULIDs, extract timestamps from ULIDs, and encode/decode ULIDs using Base32 encoding.
/// </remarks>
public static class UlidGenerator
{

	/// <summary>
	/// The length of the random component in the ULID.
	/// </summary>
	private const int RandomLength = 16;

	/// <summary>
	/// The length of the timestamp component in the ULID.
	/// </summary>
	private const int TimestampLength = 10;

	/// <summary>
	/// The characters used for Base32 encoding.
	/// </summary>
	private static readonly char[] _base32Chars = "0123456789ABCDEFGHJKMNPQRSTVWXYZ".ToCharArray();

	/// <summary>
	/// Decodes a Base32 encoded string into a byte array.
	/// </summary>
	/// <param name="base32">The Base32 encoded string.</param>
	/// <param name="bytes">The byte array to store the decoded bytes.</param>
	/// <exception cref="ArgumentException">Thrown if the Base32 string contains invalid characters.</exception>
	private static void DecodeBase32(string base32, byte[] bytes)
	{
		var byteIndex = 0;
		var bitIndex = 0;

		for (var index = 0; index < base32.Length; index++)
		{
			var value = Array.IndexOf(_base32Chars, base32[index]);

			if (value < 0)
			{
				ExceptionThrower.ThrowArgumentException("Invalid character in ULID.", nameof(base32));
			}

			if (bitIndex <= 3)
			{
				bytes[byteIndex] |= (byte)(value << (3 - bitIndex));
				bitIndex = (bitIndex + 5) % 8;
				if (bitIndex == 0)
				{
					byteIndex++;
				}
			}
			else
			{
				bytes[byteIndex] |= (byte)(value >> (bitIndex - 3));
				byteIndex++;
				bytes[byteIndex] |= (byte)(value << (8 - (bitIndex + 3)));
				bitIndex = (bitIndex + 5) % 8;
			}
		}
	}

	/// <summary>
	/// Encodes a byte array into a Base32 encoded character array.
	/// </summary>
	/// <param name="bytes">The byte array to encode.</param>
	/// <param name="chars">The character array to store the encoded characters.</param>
	/// <param name="charIndex">The starting index in the character array.</param>
	/// <param name="length">The number of bytes to encode.</param>
	private static void EncodeBase32(byte[] bytes, char[] chars, in int charIndex, in int length)
	{
		var byteIndex = 0;
		var bitIndex = 0;
		var mask = 0x1F;

		for (var i = 0; i < length; i++)
		{
			if (bitIndex > 3)
			{
				var dualByte = bytes[byteIndex] & 0xFF;
				dualByte <<= 8;
				if (byteIndex + 1 < bytes.Length)
				{
					dualByte |= bytes[byteIndex + 1] & 0xFF;
				}
				dualByte >>= 16 - (bitIndex + 5);
				chars[charIndex + i] = _base32Chars[dualByte & mask];
				byteIndex++;
				bitIndex = (bitIndex + 5) % 8;
			}
			else
			{
				chars[charIndex + i] = _base32Chars[(bytes[byteIndex] >> (3 - bitIndex)) & mask];
				bitIndex = (bitIndex + 5) % 8;
				if (bitIndex == 0)
				{
					byteIndex++;
				}
			}
		}
	}

	/// <summary>
	/// Generates a byte array of random bytes.
	/// </summary>
	/// <returns>A byte array containing 10 random bytes.</returns>
	private static byte[] GetRandomBytes()
	{
		var randomBytes = new byte[10];

		using (var rng = RandomNumberGenerator.Create())
		{
			rng.GetBytes(randomBytes);
		}

		return randomBytes;
	}

	/// <summary>
	/// Gets the current timestamp in milliseconds since the Unix epoch.
	/// </summary>
	/// <returns>A byte array representing the current timestamp.</returns>
	private static byte[] GetTimestamp()
	{
		var timestamp = BitConverter.GetBytes(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse(timestamp);
		}

		return timestamp;
	}

	/// <summary>
	/// Extracts the timestamp from a given ULID.
	/// </summary>
	/// <param name="ulid">The ULID string.</param>
	/// <returns>The extracted timestamp as a <see cref="DateTimeOffset"/>.</returns>
	/// <exception cref="ArgumentException">Thrown if the ULID is not valid.</exception>
	[Information("Extracts the timestamp from a given ULID.", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.New)]
	public static DateTimeOffset ExtractTimestamp(string ulid)
	{
		if (ulid == null || ulid.Length != 26)
		{
			ExceptionThrower.ThrowArgumentInvalidException("Invalid ULID format.", nameof(ulid));
		}

		var timestampBytes = new byte[8];

		DecodeBase32(ulid[..TimestampLength], timestampBytes);

		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse(timestampBytes);
		}

		var timestamp = BitConverter.ToInt64(timestampBytes, 0);

		return DateTimeOffset.FromUnixTimeMilliseconds(timestamp);
	}

	/// <summary>
	/// Generates multiple ULIDs based on the specified count.
	/// </summary>
	/// <param name="count">The number of ULIDs to generate.</param>
	/// <returns>A read-only collection of generated ULIDs.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the count is less than or equal to zero.</exception>
	[Information("Generates multiple ULIDs based on the specified count.", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.New)]
	public static ReadOnlyCollection<string> GenerateMultipleUlids(in int count)
	{
		var ulids = new List<string>(count.ArgumentInRange(1, defaultValue: 1));

		for (var index = 0; index < count; index++)
		{
			ulids.Add(GenerateUlid());
		}
		return ulids.AsReadOnly();
	}

	/// <summary>
	/// Generates a new ULID.
	/// </summary>
	/// <returns>A new ULID as a string.</returns>
	[Information("Generates a new ULID.", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.New)]
	public static string GenerateUlid()
	{
		var timestamp = GetTimestamp();
		var randomBytes = GetRandomBytes();

		var ulidChars = new char[26];

		EncodeBase32(timestamp, ulidChars, 0, TimestampLength);
		EncodeBase32(randomBytes, ulidChars, TimestampLength, RandomLength);

		return new string(ulidChars);
	}
}
