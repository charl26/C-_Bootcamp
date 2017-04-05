using NUnit.Framework;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabNUnit
{
	[TestFixture]
	public class UnitTest1
	{
		[Test]
		public void Test_That_Fizzbuz_Is_Prints_Completly_fizz_buzz()
		{
			FizzBuzz fizzBuzz = new FizzBuzz();
			string testString = "12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz1617Fizz19Buzz" +
								"Fizz2223FizzBuzz26Fizz2829FizzBuzz3132Fizz34BuzzFizz3738FizzBuzz" +
								"41Fizz4344FizzBuzz4647Fizz49BuzzFizz5253FizzBuzz56Fizz5859FizzBuzz" +
								"6162Fizz64BuzzFizz6768FizzBuzz71Fizz7374FizzBuzz7677Fizz79Buzz" +
								"Fizz8283FizzBuzz86Fizz8889FizzBuzz9192Fizz94BuzzFizz9798FizzBuzz";
			string result = fizzBuzz.PrintFizzBuzz();

			NUnit.Framework.Assert.AreEqual(testString, result);
		}

		[Test]
		public void Test_That_Fizzbuz_Is_Prints_one_fizz_buzz()
		{
			FizzBuzz fizzBuzz = new FizzBuzz();
			string testString = "1";
			string result = fizzBuzz.PrintFizzBuzz(1);

			NUnit.Framework.Assert.AreEqual(testString, result);
		}

		[Test]
		public void Test_That_Fizzbuz_Is_Prints_20_fizz_buzz()
		{
			FizzBuzz fizzBuzz = new FizzBuzz();
			string testString = "12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz1617Fizz19Buzz";
			string result = fizzBuzz.PrintFizzBuzz(20);

			NUnit.Framework.Assert.AreEqual(testString, result);
		}

		[Test]
		public void Test_That_Fizzbuz_Is_Prints_5_fizz_buzz()
		{
			FizzBuzz fizzBuzz = new FizzBuzz();
			string testString = "12Fizz4Buzz";
			string result = fizzBuzz.PrintFizzBuzz(5);

			NUnit.Framework.Assert.AreEqual(testString, result);
		}
	}


}