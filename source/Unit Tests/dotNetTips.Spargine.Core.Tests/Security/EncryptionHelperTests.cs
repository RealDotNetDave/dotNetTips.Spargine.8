// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 07-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-14-2024
// ***********************************************************************
// <copyright file="EncryptionHelperTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using DotNetTips.Spargine.Core.Security;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Tests.Security;

[ExcludeFromCodeCoverage]

[TestClass]
public class EncryptionHelperTests
{

	private string _cipherText;
	private byte[] _iv;
	private byte[] _key;

	[TestMethod]
	public void AesDecrypt_NullCipherText_ThrowsArgumentNullException()
	{
		// Act and Assert
		Assert.ThrowsException<ArgumentNullException>(() => EncryptionHelper.AesDecrypt(null, _key, _iv));
	}

	[TestMethod]
	public void AesDecrypt_NullIv_ThrowsArgumentNullException()
	{
		// Act and Assert
		Assert.ThrowsException<ArgumentNullException>(() => EncryptionHelper.AesDecrypt(_cipherText, _key, null));
	}

	[TestMethod]
	public void AesDecrypt_NullKey_ThrowsArgumentNullException()
	{
		// Act and Assert
		Assert.ThrowsException<ArgumentNullException>(() => EncryptionHelper.AesDecrypt(_cipherText, null, _iv));
	}

	[TestMethod]
	public void AesDecrypt_ValidInputs_ReturnsDecryptedString()
	{
		// Act
		var result = EncryptionHelper.AesDecrypt(_cipherText, _key, _iv);

		// Assert
		Assert.AreEqual("Test", result);
	}

	[TestMethod]
	public void ComputeSha256HashTest()
	{
		var testString = RandomData.GenerateWord(15);

		var result = testString.ComputeSHA256Hash();

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);
	}

	[TestMethod]
	public void GenerateAesIVTest()
	{
		var result = EncryptionHelper.GenerateAesIV();

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void GenerateAesKeyTest()
	{
		var result = EncryptionHelper.GenerateAesKey();

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void SimpleSHA256EncryptDecryptStringTest()
	{
		var testString = RandomData.GenerateWord(15);

		var key = EncryptionHelper.GenerateRandomKey();

		var cipherText = EncryptionHelper.SimpleSHA256Encrypt(testString, key);

		Assert.IsTrue(string.IsNullOrEmpty(cipherText) is false);

		var plainText = EncryptionHelper.SimpleSHA256Decrypt(cipherText, key);

		Assert.IsTrue(string.IsNullOrEmpty(plainText) is false);

		Assert.IsTrue(plainText.Equals(testString));
	}

	[TestInitialize]
	public void TestInitialize()
	{
		var aes = Aes.Create();

		_key = aes.Key;
		_iv = aes.IV;


		_cipherText = EncryptionHelper.AesEncrypt("Test", _key, _iv);
	}

	[TestMethod]
	public void VerifySHA256HashedPassword_InvalidPassword_ReturnsFailed()
	{
		// Arrange
		var password = "TestPassword";
		var hashedPassword = SHA256PasswordHasher.HashPassword(password);

		// Act
		var result = EncryptionHelper.VerifySHA256HashedPassword(hashedPassword, "WrongPassword");

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Failed, result);
	}

	[TestMethod]
	public void VerifySHA256HashedPassword_NullHashedPassword_ThrowsArgumentNullException()
	{
		// Act and Assert
		Assert.ThrowsException<ArgumentNullException>(() => EncryptionHelper.VerifySHA256HashedPassword(null, "TestPassword"));
	}

	[TestMethod]
	public void VerifySHA256HashedPassword_NullPassword_ThrowsArgumentNullException()
	{
		// Arrange
		var password = "TestPassword";
		var hashedPassword = SHA256PasswordHasher.HashPassword(password);

		// Act and Assert
		Assert.ThrowsException<ArgumentNullException>(() => EncryptionHelper.VerifySHA256HashedPassword(hashedPassword, null));
	}

	[TestMethod]
	public void VerifySHA256HashedPassword_ValidInputs_ReturnsSuccess()
	{
		// Arrange
		var password = "TestPassword";
		var hashedPassword = SHA256PasswordHasher.HashPassword(password);

		// Act
		var result = EncryptionHelper.VerifySHA256HashedPassword(hashedPassword, password);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Success, result);
	}

}

