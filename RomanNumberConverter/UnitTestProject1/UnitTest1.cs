using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Test_That_I_Returns_one_negative()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("");

			Assert.AreEqual(result, -1);
		}

		[TestMethod]
		public void Test_That_I_Returns_one_postive()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("I");

			Assert.AreEqual(result, 1);
		}

		[TestMethod]
		public void Test_That_II_Returns_two_postive()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("II");

			Assert.AreEqual(result, 2);
		}

		[TestMethod]
		public void Test_That_III_Returns_Three_postive()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("III");

			Assert.AreEqual(result, 3);
		}

		[TestMethod]
		public void Test_That_IV_Returns_4_postive()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("IV");

			Assert.AreEqual(result, 4);
		}


		[TestMethod]
		public void Test_That_V_Returns_5_postive()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("V");

			Assert.AreEqual(result, 5);
		}

		[TestMethod]
		public void Test_That_VI_Returns_6_postive()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("VI");

			Assert.AreEqual(result, 6);
		}

		[TestMethod]
		public void Test_That_VII_Returns_7_postive()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("VII");

			Assert.AreEqual(result, 7);
		}

		[TestMethod]
		public void Test_That_VIII_Returns_8_postive()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("VIII");

			Assert.AreEqual(result, 8);
		}

		[TestMethod]
		public void Test_That_IX_Returns_9_postive()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("IX");

			Assert.AreEqual(result, 9);
		}

		[TestMethod]
		public void Test_That_X_Returns_10_postive()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("X");

			Assert.AreEqual(result, 10);
		}

		[TestMethod]
		public void Test_That_IX_Returns_11_postive()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("XI");

			Assert.AreEqual(result, 11);
		}

		[TestMethod]
		public void Test_That_X_Returns_12_postive()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("XII");

			Assert.AreEqual(result, 12);
		}


		[TestMethod]
		public void Test_That_L_Returns_50_postive()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("L");

			Assert.AreEqual(result, 50);
		}

		[TestMethod]
		public void Test_That_C_Returns_100_postive()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("C");

			Assert.AreEqual(result, 100);
		}


		[TestMethod]
		public void Test_That_D_Returns_500_postive()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("D");

			Assert.AreEqual(result, 500);
		}

		[TestMethod]
		public void Test_That_M_Returns_1000_postive()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("M");

			Assert.AreEqual(result, 1000);
		}

		[TestMethod]
		public void Test_That_MMX_Returns_2010_postive()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("MMX");

			Assert.AreEqual(result, 2010);
		}

		[TestMethod]
		public void Test_That_CLXXVIII_Returns_178_postive()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("CLXXVIII");

			Assert.AreEqual(result, 178);
		}

		[TestMethod]
		public void Test_That_XXXIII_Returns_33_postive()
		{
			NumberConverter numberConvert = new NumberConverter();
			var result = numberConvert.convertNumber("XXXIII");

			Assert.AreEqual(result, 33);
		}
	}
}
