using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
	public class HomeStead
	{
		private string name;
		private string district;
		private string province;
		private string country;

		public HomeStead(string name, string district, string province, string country)
		{
			this.name = name;
			this.district = district;
			this.province = province;
			this.country = country;
		}

		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}

		public string District
		{
			get { return this.district; }
			set { this.district = value; }
		}

		public string Province
		{
			get { return this.province; }
			set { this.province = value; }
		}

		public string Country
		{
			get { return this.country; }
			set { this.country = value; }
		}

		public void accept(Visitor visitor)
		{
			if (visitor != null)
				visitor.Visit(this);
		}

		public new string ToString()
		{
			return "HomeStead:" +
					" Name { " + this.name +
					" } District { " + this.district +
					" } Province { " + this.province +
					" } Country { " + this.country +
					" }";
		}
	}
}
