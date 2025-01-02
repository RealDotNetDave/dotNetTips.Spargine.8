// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 01-02-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-02-2025
// ***********************************************************************
// <copyright file="PBKDF2PasswordHasherBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
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
public class PBKDF2PasswordHasherBenchmark : Benchmark
{
	private const string Password = "TEST";

	private string _hashedPassword;

	[Benchmark(Description = nameof(PBKDF2PasswordHasher.FixedTimeEquals))]
	[BenchmarkCategory(Categories.Encryption)]
	public void FixedTimeEquals()
	{
		// Arrange
		var left = Encoding.UTF8.GetBytes("Test");
		var right = Encoding.UTF8.GetBytes("Test");

		// Act
		var result = PBKDF2PasswordHasher.FixedTimeEquals(left, right);

		Consume(result);
	}

	[Benchmark(Description = nameof(PBKDF2PasswordHasher.HashPassword))]
	[BenchmarkCategory(Categories.Encryption)]
	public void HashPassword()
	{
		var result = PBKDF2PasswordHasher.HashPassword(Password);

		Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._hashedPassword = PBKDF2PasswordHasher.HashPassword(Password);
	}

	[Benchmark(Description = nameof(PBKDF2PasswordHasher.VerifyHashedPassword))]
	[BenchmarkCategory(Categories.Encryption)]
	public void VerifyHashedPassword()
	{
		var result = PBKDF2PasswordHasher.VerifyHashedPassword(this._hashedPassword, Password);

		Consume(result);
	}
}
