using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Security;

[ExcludeFromCodeCoverage]
[TestClass]
public class PBKDF2PasswordHasherTests
{

	[TestMethod]
	public void FixedTimeEquals_WithDifferentByteArrays_ReturnsFalse()
	{
		// Arrange
		var left = new byte[] { 1, 2, 3, 4, 5 };
		var right = new byte[] { 1, 2, 3, 4, 6 };

		// Act
		var result = PBKDF2PasswordHasher.FixedTimeEquals(left, right);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void FixedTimeEquals_WithDifferentLengthByteArrays_ReturnsFalse()
	{
		// Arrange
		var left = new byte[] { 1, 2, 3, 4, 5 };
		var right = new byte[] { 1, 2, 3, 4 };

		// Act
		var result = PBKDF2PasswordHasher.FixedTimeEquals(left, right);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void FixedTimeEquals_WithEqualByteArrays_ReturnsTrue()
	{
		// Arrange
		var left = new byte[] { 1, 2, 3, 4, 5 };
		var right = new byte[] { 1, 2, 3, 4, 5 };

		// Act
		var result = PBKDF2PasswordHasher.FixedTimeEquals(left, right);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HashPassword_WithDifferentPasswords_ReturnsDifferentHashes()
	{
		// Arrange
		var password1 = "password123";
		var password2 = "password456";

		// Act
		var hashedPassword1 = PBKDF2PasswordHasher.HashPassword(password1);
		var hashedPassword2 = PBKDF2PasswordHasher.HashPassword(password2);

		// Assert
		Assert.AreNotEqual(hashedPassword1, hashedPassword2);
	}

	[TestMethod]
	public void HashPassword_WithValidPassword_ReturnsHashedPassword()
	{
		// Arrange
		var password = "password123";

		// Act
		var hashedPassword = PBKDF2PasswordHasher.HashPassword(password);

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(hashedPassword));
	}

	[TestMethod]
	public void VerifyHashedPassword_WithCorrectPassword_ReturnsSuccess()
	{
		// Arrange
		var password = "password123";
		var hashedPassword = PBKDF2PasswordHasher.HashPassword(password);

		// Act
		var result = PBKDF2PasswordHasher.VerifyHashedPassword(hashedPassword, password);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Success, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_WithEmptyHashedPassword_ReturnsFailed()
	{
		// Arrange
		var password = "password123";
		var hashedPassword = string.Empty;

		// Act
		var result = PBKDF2PasswordHasher.VerifyHashedPassword(hashedPassword, password);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Failed, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_WithIncorrectPassword_ReturnsFailed()
	{
		// Arrange
		var password = "password123";
		var hashedPassword = PBKDF2PasswordHasher.HashPassword(password);
		var incorrectPassword = "wrongpassword";

		// Act
		var result = PBKDF2PasswordHasher.VerifyHashedPassword(hashedPassword, incorrectPassword);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Failed, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_WithIncorrectVersionHashedPassword_ReturnsFailed()
	{
		// Arrange
		var password = "password123";
		var hashedPassword = PBKDF2PasswordHasher.HashPassword(password);
		var passwordBytes = Convert.FromBase64String(hashedPassword);
		passwordBytes[0] = 2; // Change version to an incorrect value
		var incorrectVersionHashedPassword = Convert.ToBase64String(passwordBytes);

		// Act
		var result = PBKDF2PasswordHasher.VerifyHashedPassword(incorrectVersionHashedPassword, password);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Failed, result);
	}
}

