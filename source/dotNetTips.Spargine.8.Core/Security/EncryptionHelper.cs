// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Core
// Author           : David McCarter
// Created          : 07-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-15-2024
// ***********************************************************************
// <copyright file="EncryptionHelper.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Provides secure encryption for strings using AES
// (Advanced Encryption Standard) and includes a method to validate
// encrypted strings. The AES encryption ensures the confidentiality
// and integrity of sensitive information, making it suitable for securely
// handling data.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Security;

/// <summary>
/// Provides a collection of methods for encrypting and decrypting data, generating keys and initialization vectors (IVs),
/// and verifying hashed passwords. It leverages AES (Advanced Encryption Standard) for encryption tasks and SHA256 for hashing,
/// ensuring a high level of security for sensitive data handling.
/// </summary>
public static class EncryptionHelper
{

	/// <summary>
	/// Generates AES key and initialization vector (IV) based on a SHA256 hash of the provided key.
	/// </summary>
	/// <param name="key">The input key from which to generate the AES key and IV.</param>
	/// <returns>A tuple containing the AES key and IV.</returns>
	/// <remarks>
	/// This method hashes the input key using SHA256 and then uses the hash to generate
	/// a 32-byte AES key and a 16-byte IV. It ensures that the key and IV are derived
	/// from the input key in a consistent and secure manner.
	/// </remarks>
	private static (byte[] key, byte[] iv) GetSHA256HashKeys([NotNull] string key)
	{
		var encoding = Encoding.ASCII;

		var hash = SHA256.HashData(encoding.GetBytes(key));

		var aesKey = new byte[32];
		var aesIV = new byte[16];

		Array.Copy(hash, aesKey, aesKey.Length);
		Array.Copy(hash, 0, aesIV, 0, aesIV.Length);

		return (aesKey, aesIV);
	}

	/// <summary>
	/// Decrypts array to string using AES security.
	/// </summary>
	/// <param name="cipherText">The cipher text.</param>
	/// <param name="key">The secret key.</param>
	/// <param name="iv">The initialization vector.</param>
	/// <returns>System.String.</returns>
	/// <example>
	/// Here is how you can use the <see cref="AesDecrypt"/> method:
	/// <code>
	/// var decryptedString = EncryptionHelper.AesDecrypt(cipherText, key, iv);
	/// Console.WriteLine(decryptedString);
	/// </code>
	/// </example>
	[Information(nameof(AesDecrypt), "David McCarter", "7/19/2021", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2021")]
	public static string AesDecrypt(string cipherText, byte[] key, byte[] iv)
	{
		cipherText = cipherText.ArgumentNotNull();
		key = key.ArgumentNotNull();
		iv = iv.ArgumentNotNull();

		// Create AesManaged.
		using (var aes = Aes.Create())
		{
			// Create a decryptor.
			using (var decryptor = aes.CreateDecryptor(key, iv))
			{
				// Create the streams used for decryption.
				using (var ms = new MemoryStream(Convert.FromBase64String(cipherText)))
				{
					// Create crypto stream.
					using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
					{
						// Read crypto stream.
						using (var reader = new StreamReader(cs))
						{
							return reader.ReadToEnd();
						}
					}
				}
			}
		}
	}

	/// <summary>
	/// Encrypts a string using AES security.
	/// </summary>
	/// <param name="plainText">The plain text to encrypt.</param>
	/// <param name="key">The secret key used for encryption. Must be 256 bits (32 bytes) long.</param>
	/// <param name="iv">The initialization vector used for encryption. Must be 128 bits (16 bytes) long.</param>
	/// <returns>The encrypted string, encoded in Base64.</returns>
	/// <example>
	/// Here is how you can use the <see cref="AesEncrypt"/> method:
	/// <code>
	/// var key = EncryptionHelper.GenerateAesKey();
	/// var iv = EncryptionHelper.GenerateAesIV();
	/// var encryptedString = EncryptionHelper.AesEncrypt("Hello World", key, iv);
	/// Console.WriteLine(encryptedString);
	/// </code>
	/// </example>
	[SupportedOSPlatform("windows")]
	[Information(nameof(AesEncrypt), "David McCarter", "7/19/2021", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2021")]
	public static string AesEncrypt([NotNull] string plainText, [NotNull] byte[] key, [NotNull] byte[] iv)
	{
		plainText = plainText.ArgumentNotNullOrEmpty(true);
		key = key.ArgumentNotNull();
		iv = iv.ArgumentNotNull();

		// Create MemoryStream
		using (var ms = new MemoryStream())
		{
			// Create encryptor
			using (var aesCng = new AesCng())
			{
				// Create crypto stream using the CryptoStream class. This class is the key to encryption
				// and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream
				// to encrypt
				using (var cs = new CryptoStream(ms, aesCng.CreateEncryptor(key, iv), CryptoStreamMode.Write))
				{
					// Create StreamWriter and write data to a stream
					using (var sw = new StreamWriter(cs))
					{
						sw.Write(plainText);
					}
				}

				return Convert.ToBase64String(ms.ToArray());
			}
		}
	}

	/// <summary>
	/// Generates a new AES Initialization Vector (IV).
	/// </summary>
	/// <returns>A new 16-byte initialization vector.</returns>
	/// <remarks>
	/// The IV is used to prevent any patterns from being discernible in the ciphertext.
	/// It's crucial that the IV is random and not reused across encryptions for the same key.
	/// </remarks>
	[Information(nameof(GenerateAesIV), "David McCarter", "7/19/2021", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static byte[] GenerateAesIV()
	{
		using (var aes = Aes.Create())
		{
			aes.GenerateIV();
			return aes.IV;
		}
	}

	/// <summary>
	/// Generates a new AES Key.
	/// </summary>
	/// <returns>A new 32-byte key for AES encryption.</returns>
	/// <remarks>
	/// The key is used in conjunction with the IV for encrypting and decrypting data.
	/// It's crucial that the key is securely stored and not exposed to unauthorized entities.
	/// </remarks>
	[Information(nameof(GenerateAesKey), "David McCarter", "7/19/2021", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static byte[] GenerateAesKey()
	{
		using (var aes = Aes.Create())
		{
			aes.GenerateKey();
			return aes.Key;
		}
	}

	/// <summary>
	/// Generates a random key using a GUID.
	/// </summary>
	/// <returns>A string representation of the GUID, formatted without dashes.</returns>
	/// <remarks>
	/// This method generates a GUID and formats it as a string without dashes.
	/// It's primarily used for generating non-cryptographic keys or identifiers.
	/// </remarks>
	/// <example><b>Output:</b> f7f0af78003d4ab194b5a4024d02112a</example>
	[Information(nameof(GenerateRandomKey), "David McCarter", "5/30/2021", UnitTestStatus = UnitTestStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static string GenerateRandomKey() => Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture);

	/// <summary>
	/// Decrypts a string using SHA256 and AES security.
	/// </summary>
	/// <param name="cipherText">The encrypted text to decrypt.</param>
	/// <param name="key">The key used for decryption.</param>
	/// <returns>The decrypted string.</returns>
	/// <example>
	/// Here is how you can use the <see cref="SimpleSHA256Decrypt"/> method:
	/// <code>
	/// var key = "your-encryption-key";
	/// var cipherText = "your-encrypted-text";
	/// var decryptedText = EncryptionHelper.SimpleSHA256Decrypt(cipherText, key);
	/// Console.WriteLine(decryptedText);
	/// </code>
	/// </example>
	[Information(nameof(SimpleSHA256Decrypt), "David McCarter", "7/19/2021", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2021")]
	public static string SimpleSHA256Decrypt([NotNull] string cipherText, [NotNull] string key)
	{
		cipherText = cipherText.ArgumentNotNullOrEmpty(true);
		key = key.ArgumentNotNullOrEmpty(true);

		var keys = GetSHA256HashKeys(key);

		return AesDecrypt(cipherText, keys.key, keys.iv);
	}

	/// <summary>
	/// Encrypts text using SHA256 and AES security.
	/// </summary>
	/// <param name="plainText">The plain text to encrypt.</param>
	/// <param name="key">The key used for encryption.</param>
	/// <returns>The encrypted string.</returns>
	/// <example>
	/// Here is how you can use the <see cref="SimpleSHA256Encrypt"/> method:
	/// <code>
	/// var key = "your-encryption-key";
	/// var plainText = "your-plain-text";
	/// var encryptedText = EncryptionHelper.SimpleSHA256Encrypt(plainText, key);
	/// Console.WriteLine(encryptedText);
	/// </code>
	/// </example>
	[SupportedOSPlatform("windows")]
	[Information(nameof(SimpleSHA256Encrypt), "David McCarter", "7/19/2021", OptimizationStatus = OptimizationStatus.Completed, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Documentation = "https://bit.ly/SpargineSep2021", Status = Status.Available)]
	public static string SimpleSHA256Encrypt([NotNull] string plainText, [NotNull] string key)
	{
		plainText = plainText.ArgumentNotNullOrEmpty(true);
		key = key.ArgumentNotNullOrEmpty();

		var keys = GetSHA256HashKeys(key);

		return AesEncrypt(plainText, keys.key, keys.iv);
	}

	/// <summary>
	/// Verifies a hashed password with SHA256.
	/// </summary>
	/// <param name="hashedPassword">The hashed password.</param>
	/// <param name="password">The password to verify.</param>
	/// <returns>A <see cref="PasswordVerificationResult"/> indicating the result of the verification.</returns>
	/// <example>
	/// Here is how you can use the <see cref="VerifySHA256HashedPassword"/> method:
	/// <code>
	/// var hashedPassword = "your-hashed-password";
	/// var password = "your-password";
	/// var result = EncryptionHelper.VerifySHA256HashedPassword(hashedPassword, password);
	/// Console.WriteLine(result);
	/// </code>
	/// </example>
	[Information(nameof(VerifySHA256HashedPassword), "David McCarter", "10/13/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022", BenchMarkStatus = BenchMarkStatus.Completed)]
	public static PasswordVerificationResult VerifySHA256HashedPassword(string hashedPassword, [NotNull] string password) => SHA256PasswordHasher.VerifyHashedPassword(hashedPassword.ArgumentNotNullOrEmpty(), password.ArgumentNotNullOrEmpty());

}
