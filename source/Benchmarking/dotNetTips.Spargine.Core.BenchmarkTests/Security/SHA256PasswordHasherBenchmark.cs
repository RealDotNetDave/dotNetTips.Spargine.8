// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 06-07-2024
//
// Last Modified By : David McCarter
// Last Modified On : 01-02-2025
// ***********************************************************************
// <copyright file="SHA256PasswordHasherBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Security;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Security;

[BenchmarkCategory(Categories.Encryption)]
public class SHA256PasswordHasherBenchmark : Benchmark
{

	[Benchmark(Description = nameof(SHA256PasswordHasher.FixedTimeEquals))]
	[BenchmarkCategory(Categories.Encryption)]
	public void FixedTimeEquals()
	{
		// Arrange
		var left = Encoding.UTF8.GetBytes("Test");
		var right = Encoding.UTF8.GetBytes("Test");

		// Act
		var result = SHA256PasswordHasher.FixedTimeEquals(left, right);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(SHA256PasswordHasher.HashPassword))]
	[BenchmarkCategory(Categories.Encryption)]
	public void HashPassword()
	{
		var password = "TestPassword";
		var hashedPassword = SHA256PasswordHasher.HashPassword(password);

		this.Consume(hashedPassword);
	}

	[Benchmark(Description = nameof(SHA256PasswordHasher.HashPassword) + ": LONG STRING")]
	[BenchmarkCategory(Categories.Encryption, Categories.New)]
	public void HashTest()
	{
		// TESTING DUE TO EMAIL RECEIVED ABOUT HASHING MESSAGES.
		var password = this.LongTestString;
		var hashedPassword = SHA256PasswordHasher.HashPassword(password);

		this.Consume(hashedPassword);
	}

	[Benchmark(Description = nameof(SHA256PasswordHasher.VerifyHashedPassword))]
	[BenchmarkCategory(Categories.Encryption)]
	public void VerifyHashedPassword()
	{
		var password = "TestPassword";
		var hashedPassword = SHA256PasswordHasher.HashPassword(password);

		var result = SHA256PasswordHasher.VerifyHashedPassword(hashedPassword, password);

		this.Consume(result);
	}

}
