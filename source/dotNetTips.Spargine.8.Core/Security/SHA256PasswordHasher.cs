// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 10-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-31-2024
// ***********************************************************************
// <copyright file="SHA256PasswordHasher.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Generates and verifies passwords using SHA256, a secure cryptographic hash function.
// Original code from: https:www.meziantou.net/how-to-store-a-password-in-a-web-application.htm
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Security;

/// <summary>
/// Provides methods for hashing passwords using the SHA256 algorithm and verifying hashed passwords.
/// This class cannot be inherited and is designed to enhance security by incorporating salt and fixed-time comparison to mitigate common vulnerabilities.
/// </summary>
public static class SHA256PasswordHasher
{

	/// <summary>
	/// Generates a cryptographic salt of the specified byte length.
	/// </summary>
	/// <param name="byteLength">The length of the salt in bytes.</param>
	/// <returns>A byte array containing the generated salt.</returns>
	/// <remarks>This method uses a secure random number generator to produce a salt.
	/// The salt can be used as part of a hashing function to increase the security of stored passwords.</remarks>
	private static byte[] GenerateSalt(int byteLength)
	{
		var salt = RandomNumberGenerator.GetBytes(byteLength);

		return salt;
	}

	/// <summary>
	/// Hashes the specified password with the given salt using SHA256.
	/// </summary>
	/// <param name="password">The password to hash.</param>
	/// <param name="salt">The salt to use in the hashing process.</param>
	/// <returns>A byte array containing the hashed password combined with the salt.</returns>
	/// <remarks>This method combines the password and salt before applying the SHA256 hashing algorithm.
	/// The resulting hash can be used for securely storing passwords.</remarks>
	private static byte[] HashPasswordWithSalt(string password, byte[] salt)
	{
		var passwordBytes = Encoding.UTF8.GetBytes(password);

		// Combine salt and password bytes
		var saltAndPassword = new byte[salt.Length + passwordBytes.Length];
		Buffer.BlockCopy(salt, 0, saltAndPassword, 0, salt.Length);
		Buffer.BlockCopy(passwordBytes, 0, saltAndPassword, salt.Length, passwordBytes.Length);

		// Compute and return the hash
		return SHA256.HashData(saltAndPassword);
	}

	// In .NET Core 2.1, you can use CryptographicOperations.FixedTimeEquals
	// https://github.com/dotnet/runtime/blob/419e949d258ecee4c40a460fb09c66d974229623/src/libraries/System.Security.Cryptography.Primitives/src/System/Security/Cryptography/CryptographicOperations.cs#L32
	/// <summary>
	/// Fixes the time equals.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information(nameof(FixedTimeEquals), "David McCarter", "10/12/2021", OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public static bool FixedTimeEquals([NotNull] byte[] left, [NotNull] byte[] right)
	{
		left = left.ArgumentItemsExists(nameof(left));
		right = right.ArgumentItemsExists(nameof(right));

		// NoOptimization because we want this method to be exactly as non-short-circuiting as written.
		// NoInlining because the NoOptimization would get lost if the method got inlined.
		if (left.CheckIsCondition(left.Length != right.Length))
		{
			return false;
		}

		var byteCount = 0;

		for (var byteIndex = 0; byteIndex < left.Length; byteIndex++)
		{
			byteCount |= left[byteIndex] - right[byteIndex];
		}

		return byteCount == 0;
	}

	/// <summary>
	/// Hashes the specified password using SHA256 and a unique salt, returning the result as a Base64 string.
	/// </summary>
	/// <param name="password">The password to hash.</param>
	/// <returns>A Base64 encoded string representing the hashed password combined with a salt.</returns>
	/// <remarks>This method generates a new salt for each password, hashes the password using SHA256 with the salt,
	/// and returns the combined salt and hash as a Base64 string. This approach enhances security by ensuring
	/// that each password is stored with a unique salt, making it more resistant to dictionary and rainbow table attacks.</remarks>
	[Information(nameof(HashPassword), "David McCarter", "10/12/2021", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Documentation = "https://bit.ly/SpargineJan2022", Status = Status.Available)]
	public static string HashPassword([NotNull] string password)
	{
		password = password.ArgumentNotNullOrEmpty();

		// The salt must be unique for each password
		var salt = GenerateSalt(SaltSize);
		var hash = HashPasswordWithSalt(password, salt);

		var passwordBytes = new byte[1 + SaltSize + hash.Length];
		passwordBytes[0] = Version;

		Buffer.BlockCopy(salt, 0, passwordBytes, 1, SaltSize);
		Buffer.BlockCopy(hash, 0, passwordBytes, 1 + SaltSize, hash.Length);

		return Convert.ToBase64String(passwordBytes);
	}

	/// <summary>
	/// Verifies a hashed password against a provided plain text password.
	/// </summary>
	/// <param name="hashedPassword">The hashed password as a Base64 encoded string.</param>
	/// <param name="password">The plain text password to verify against the hashed password.</param>
	/// <returns>A <see cref="PasswordVerificationResult" /> indicating the result of the verification.</returns>
	/// <example>
	/// Here is how you can use the <see cref="VerifyHashedPassword" /> method:
	/// <code>
	/// var hashedPassword = "your-hashed-password-in-base64";
	/// var password = "your-plain-text-password";
	/// var result = SHA256PasswordHasher.VerifyHashedPassword(hashedPassword, password);
	/// Console.WriteLine(result == PasswordVerificationResult.Success ? "Password verified" : "Password verification failed");
	/// </code></example>
	[Information(nameof(VerifyHashedPassword), "David McCarter", "10/12/2021", OptimizationStatus = OptimizationStatus.Optimize, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static PasswordVerificationResult VerifyHashedPassword(string hashedPassword, [NotNull] string password)
	{
		if (string.IsNullOrEmpty(hashedPassword))
		{
			return PasswordVerificationResult.Failed;
		}

		if (Convert.FromBase64String(hashedPassword).Length < 1 + SaltSize)
		{
			return PasswordVerificationResult.Failed;
		}

		if (Convert.FromBase64String(hashedPassword)[0] > Version)
		{
			return PasswordVerificationResult.Failed;
		}

		var salt = new byte[SaltSize];
		Buffer.BlockCopy(Convert.FromBase64String(hashedPassword), 1, salt, 0, SaltSize);

		var expectedHash = new byte[Convert.FromBase64String(hashedPassword).Length - 1 - SaltSize];
		Buffer.BlockCopy(Convert.FromBase64String(hashedPassword), 1 + SaltSize, expectedHash, 0, expectedHash.Length);

		var actualHash = HashPasswordWithSalt(password, salt);

		return FixedTimeEquals(actualHash, expectedHash) ? PasswordVerificationResult.Success : PasswordVerificationResult.Failed;
	}

	/// <summary>
	/// Gets the name of the hash algorithm used by the SHA256PasswordHasher.
	/// </summary>
	/// <value>The name of the hash algorithm, which is SHA256.</value>
	public static HashAlgorithmName HashAlgorithmName { get; } = HashAlgorithmName.SHA256;

	/// <summary>
	/// Gets the size of the salt used in the hashing process.
	/// </summary>
	/// <value>The size of the salt in bytes.</value>
	/// <remarks>The salt size is crucial for the security of the hashed passwords. A larger salt size increases the complexity and security of the hash, making it more resistant to brute-force attacks.</remarks>
	public static int SaltSize { get; } = 128 / 8;

	/// <summary>
	/// Gets the version of the SHA256PasswordHasher.
	/// </summary>
	/// <value>The current version of the SHA256PasswordHasher.</value>
	/// <remarks>This version can be used to manage different hashing strategies or updates in the future.</remarks>
	public static byte Version => 1;

}
