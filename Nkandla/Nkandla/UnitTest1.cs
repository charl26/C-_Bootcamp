using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nkandla
{
	[TestClass]
	public class UnitTest1
	{
		HomeStead home = new HomeStead("Zuma", "Wierda", "Gauteng", "ZA");
		Nkandla nkandla = new Nkandla("Zuma", "Wierda", "Gauteng", "ZA");

		Politician JacobZuma = new Politician("Jacob Zuma", 43, Gender.MALE, PersonType.President, PartyType.ANC);
		Politician HelenZille = new Politician("Hellen Zille", 50, Gender.FEMALE, PersonType.Politician, PartyType.DA);
		Politician JuliusMalema = new Politician("Julius Malema", 38, Gender.MALE, PersonType.Politician, PartyType.EFF);

		Lawer BarryRoux = new Lawer("Barry Roux", 55, Gender.MALE, PersonType.Lawyer, PartyType.ANC);
		Architect GregWright = new Architect("Greg Wright", 62, Gender.MALE, PersonType.Architect, PartyType.ANC);

		[TestMethod]
		public void test_Person_setup()
		{
			Assert.AreEqual("Politician Person: Name { Jacob Zuma }, Age { 43 }, Gender { MALE }, Type { President }, PoliticalParty { ANC }", JacobZuma.ToString());
			Assert.AreEqual("Politician Person: Name { Hellen Zille }, Age { 50 }, Gender { FEMALE }, Type { Politician }, PoliticalParty { DA }", HelenZille.ToString());
			Assert.AreEqual("Politician Person: Name { Julius Malema }, Age { 38 }, Gender { MALE }, Type { Politician }, PoliticalParty { EFF }", JuliusMalema.ToString());
			Assert.AreEqual("Lawyer Person: Name { Barry Roux }, Age { 55 }, Gender { MALE }, Type { Lawyer }, PoliticalParty { ANC }", BarryRoux.ToString());
			Assert.AreEqual("Architect Person: Name { Greg Wright }, Age { 62 }, Gender { MALE }, Type { Architect }, PoliticalParty { ANC }", GregWright.ToString());
		}

		[TestMethod]
		public void test_homestead_setup()
		{
			Assert.AreEqual("HomeStead: Name { Zuma } District { Wierda } Province { Gauteng } Country { ZA }", home.ToString());
			Assert.AreEqual("HomeStead: Name { Zuma } District { Wierda } Province { Gauteng } Country { ZA }", nkandla.ToString());
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException), "Not the President")]
		public void Test_HelenZille()
		{
			home.accept(HelenZille);
		}

		[TestMethod]
		public void Test_JacobZuma()
		{
			home.accept(JacobZuma);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException), "Not the President")]
		public void Test_Julius_Malema()
		{
			home.accept(JuliusMalema);
		}
	}
}

