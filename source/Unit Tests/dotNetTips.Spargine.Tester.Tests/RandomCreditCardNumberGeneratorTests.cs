// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 09-17-2024
//
// Last Modified By : David McCarter
// Last Modified On : 09-17-2024
// ***********************************************************************
// <copyright file="RandomCreditCardNumberGeneratorTests.cs" company="DotNetTips.Spargine.Tester.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Tests;

[TestClass]
public class RandomCreditCardNumberGeneratorTests
{
	private bool LuhnCheck(string creditCardNumber)
	{
		int sum = 0;
		bool alternate = false;
		for (int i = creditCardNumber.Length - 1; i >= 0; i--)
		{
			int n = int.Parse(creditCardNumber[i].ToString());
			if (alternate)
			{
				n *= 2;
				if (n > 9)
				{
					n -= 9;
				}
			}
			sum += n;
			alternate = !alternate;
		}
		return sum % 10 == 0;
	}

	[TestMethod]
	public void GetCreditCardNumber_ReturnsValidCreditCardNumber()
	{
		// Act
		var creditCardNumber = RandomCreditCardNumberGenerator.GetCreditCardNumber();

		// Assert
		Assert.IsNotNull(creditCardNumber);
		Assert.IsTrue(creditCardNumber.Length >= 13 && creditCardNumber.Length <= 19);
		Assert.IsTrue(LuhnCheck(creditCardNumber));
	}

	[TestMethod]
	public void GetCreditCardNumbers_ReturnsCorrectCount()
	{
		// Arrange
		int count = 5;

		// Act
		var creditCardNumbers = RandomCreditCardNumberGenerator.GetCreditCardNumbers(count);

		// Assert
		Assert.IsNotNull(creditCardNumbers);
		Assert.AreEqual(count, creditCardNumbers.Count);
		foreach (var number in creditCardNumbers)
		{
			Assert.IsTrue(LuhnCheck(number));
		}
	}
}
