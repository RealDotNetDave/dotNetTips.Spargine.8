// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 08-03-2024
//
// Last Modified By : David McCarter
// Last Modified On : 10-10-2024
// ***********************************************************************
// <copyright file="UlidGenerator.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Provides methods to generate and manipulate ULIDs (Universally Unique Lexicographically Sortable Identifiers)</summary>
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
	/// The characters used for Base32 encoding.
	/// </summary>
	private static readonly char[] _base32Chars = "0123456789ABCDEFGHJKMNPQRSTVWXYZ".ToCharArray();

	/// <summary>
	/// The length of the random component in the ULID.
	/// </summary>
	private static readonly int _randomLength = 16;

	/// <summary>
	/// The length of the timestamp component in the ULID.
	/// </summary>
	private static readonly int _timestampLength = 10;

	/// <summary>
	/// Encodes a byte array into a Base32 encoded character array.
	/// </summary>
	/// <param name="bytes">The byte array to encode.</param>
	/// <param name="chars">The character array to store the encoded characters.</param>
	/// <param name="charIndex">The starting index in the character array.</param>
	/// <param name="length">The number of bytes to encode.</param>
	private static void EncodeBase32(in ReadOnlySpan<byte> bytes, Span<char> chars, in int charIndex, in int length)
	{
		var byteIndex = 0;
		var bitIndex = 0;
		const int mask = 0x1F;

		for (var index = 0; index < length; index++)
		{
			if (bitIndex > 3)
			{
				var dualByte = (bytes[byteIndex] << 8) | (byteIndex + 1 < bytes.Length ? bytes[byteIndex + 1] : 0);
				dualByte >>= 16 - (bitIndex + 5);
				chars[charIndex + index] = _base32Chars[dualByte & mask];
				byteIndex++;
				bitIndex = (bitIndex + 5) % 8;
			}
			else
			{
				chars[charIndex + index] = _base32Chars[(bytes[byteIndex] >> (3 - bitIndex)) & mask];
				bitIndex += 5;
				if (bitIndex >= 8)
				{
					bitIndex -= 8;
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
	/// Generates multiple ULIDs based on the specified count.
	/// </summary>
	/// <param name="count">The number of ULIDs to generate.</param>
	/// <returns>A read-only collection of generated ULIDs.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the count is less than or equal to zero.</exception>
	[Information("Generates multiple ULIDs based on the specified count.", UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.New)]
	public static ReadOnlyCollection<string> GenerateMultipleUlids(int count)
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
	[Information("Generates a new ULID.", UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.New)]
	public static string GenerateUlid()
	{
		var timestamp = GetTimestamp().AsSpan();
		var randomBytes = GetRandomBytes().AsSpan();

		var ulidChars = new char[26].AsSpan();

		EncodeBase32(timestamp, ulidChars, 0, _timestampLength);
		EncodeBase32(randomBytes, ulidChars, _timestampLength, _randomLength);

		return new string(ulidChars);
	}
}
