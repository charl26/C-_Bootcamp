using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
	class Lawer : Person
	{
		public Lawer(string name, int age, Gender gender, PersonType type, PartyType politicalParty) : base(name, age, gender, type, politicalParty)
		{ }

		public new string ToString()
		{
			return "Lawyer" + base.ToString();
		}
	}
}
