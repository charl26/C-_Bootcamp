using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
	class Politician : Person, Visitor
	{

		public Politician(string name, int age, Gender gender, PersonType type, PartyType politicalParty) :
			base(name, age, gender, type, politicalParty)
		{ }

		public void Visit(HomeStead homeStead)
		{
			if (base.Type.Equals(PersonType.Politician) && !base.PoliticalParty.Equals(PartyType.ANC))
			{
				Console.WriteLine(base.Name + ": Pay back the money!");
				throw new ArgumentException("Not the President");
			}
			else
				Console.WriteLine(base.Name + ", welcome to Nkandla!");
		}

		public new string ToString()
		{
			return "Politician" + base.ToString();
		}
	}
}
