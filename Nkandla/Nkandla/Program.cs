using System;

namespace Nkandla
{
	class Program
	{
		static void Main(string[] args)
		{
			HomeStead home = new HomeStead("Zuma", "Wierda", "Gauteng", "ZA");
			Nkandla nkandla = new Nkandla("Zuma", "Wierda", "Gauteng", "ZA");

			string temp = "HomeStead:" + " Name { Zuma } District { Wierda } Province { Gauteng } Country { ZA }";
			if (temp.Equals(home.ToString()))
				Console.WriteLine("HomeStead initiated correctly done");

			Politician JacobZuma = new Politician("Jacob Zuma", 43, Gender.MALE, PersonType.President, PartyType.ANC);
			Politician HelenZille = new Politician("Hellen Zille", 50, Gender.FEMALE, PersonType.Politician, PartyType.DA);
			Politician JuliusMalema = new Politician("Julius Malema", 38, Gender.MALE, PersonType.Politician, PartyType.EFF);

			Lawer BarryRoux = new Lawer("Barry Roux", 55, Gender.MALE, PersonType.Lawyer, PartyType.ANC);
			Architect GregWright = new Architect("Greg Wright", 62, Gender.MALE, PersonType.Architect, PartyType.ANC);

			Console.WriteLine(JacobZuma.ToString());
			Console.WriteLine(HelenZille.ToString());
			Console.WriteLine(JuliusMalema.ToString());
			Console.WriteLine(BarryRoux.ToString());
			Console.WriteLine(GregWright.ToString());

			home.accept(HelenZille);
			home.accept(JuliusMalema);
			home.accept(JacobZuma);

			Console.Read();
		}
	}
}
