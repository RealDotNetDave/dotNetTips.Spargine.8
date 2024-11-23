// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : david
// Created          : 11-12-2024
//
// Last Modified By : david
// Last Modified On : 11-23-2024
// ***********************************************************************
// <copyright file="PasswordGenerator.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Security;

/// <summary>
/// Class PasswordGenerator.
/// Provides functionality to generate random passwords with a mix of uppercase letters, lowercase letters, digits, and special characters.
/// </summary>
public static class PasswordGenerator
{
	private const string Digits = "0123456789";
	private const string Lowercase = "abcdefghijklmnopqrstuvwxyz";
	private const string SpecialChars = "!@#$%^&*()_-+=<>?";
	private const string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly Lazy<ObjectPool<StringBuilder>> _stringBuilderPool =
		new(() => new DefaultObjectPoolProvider().CreateStringBuilderPool());

	/// <summary>
	/// Generates a random password with the specified length.
	/// The password will contain a mix of uppercase letters, lowercase letters, digits, and special characters.
	/// </summary>
	/// <param name="length">The length of the password to generate. Must be at least 8 characters.</param>
	/// <returns>A randomly generated password string.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the length is less than 8.</exception>
	/// <example>Password example: ik)-qm%OomiO</example>
	[Information(nameof(GeneratePassword), "David McCarter", "11/12/2024", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
	public static string GeneratePassword(int length)
	{
		length = length.ArgumentInRange(8, errorMessage: "Password length must be at lease 8 characters.");

		var passwordChars = _stringBuilderPool.Value.Get().ClearSetCapacity(length);

		try
		{
			var characterPool = Uppercase + Lowercase + Digits + SpecialChars;
			var randomNumber = new byte[4];

			using (var rng = RandomNumberGenerator.Create())
			{
				for (var charIndex = 0; charIndex < length; charIndex++)
				{
					rng.GetBytes(randomNumber);
					var index = randomNumber[0] % characterPool.Length;
					_ = passwordChars.Append(characterPool[index]);
				}
			}

			return passwordChars.ToString();
		}
		finally
		{
			_stringBuilderPool.Value.Return(passwordChars);
		}
	}
}

