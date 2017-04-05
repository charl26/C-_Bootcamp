using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
	class Person
	{
		private int age;
		private Gender gender;
		private string name;
		private PersonType type;
		private PartyType party;

		public Person(string name, int age, Gender gender, PersonType type, PartyType politicalParty)
		{
			this.name = name;
			this.age = age;
			this.gender = gender;
			this.type = type;
			this.party = politicalParty;
		}

		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}

		public int Age
		{
			get { return this.age; }
			set { this.age = value; }
		}

		public Gender Gender
		{
			get { return this.gender; }
			set { this.gender = value; }

		}

		public PersonType Type
		{
			get { return this.type; }
			set { this.type = value; }
		}

		public PartyType PoliticalParty
		{
			get { return this.party; }
			set { this.party = value; }
		}

		public new string ToString()
		{
			return " Person:" + " Name { "
					+ this.name + " }, Age { "
					+ this.age + " }, Gender { "
					+ this.gender + " }, Type { "
					+ this.type + " }, PoliticalParty { "
					+ this.party + " }";
		}

	}

	public enum Gender { MALE, FEMALE }

	public enum PersonType
	{
		Lawyer,
		Architect,
		Politician,
		President
	}

	public enum PartyType
	{
		ANC,
		DA,
		EFF,
		Other
	}
}
