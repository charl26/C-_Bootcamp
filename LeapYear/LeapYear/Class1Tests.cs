using LeapYear;
using Xunit;

namespace LeapYear
{
	public class leapYearCheckertests
	{
		private static LeapYearChecker leapYearChecker = new LeapYearChecker();

		[Fact]
		public void Test_Should_Be_true_div_by_4()
		{
			var year = 1996;

			bool result = leapYearChecker.CheckYear(year);

			Assert.True(result);
		}

		[Fact]
		public void Test_Should_Be_true_div_by_400()
		{
			var year = 4000;

			bool result = leapYearChecker.CheckYear(year);

			Assert.True(result);
		}

		[Fact]
		public void Test_Should_Be_false()
		{
			var year = 1997;

			bool result = leapYearChecker.CheckYear(year);

			Assert.False(result);
		}

		[Fact]
		public void Test_Should_Be_False_1900()
		{
			var year = 1900;

			bool result = leapYearChecker.CheckYear(year);

			Assert.False(result);
		}

		[Fact]
		public void Test_Should_Be_False_negative_number()
		{
			var year = -1900;

			bool result = leapYearChecker.CheckYear(year);

			Assert.False(result);
		}
	}
}