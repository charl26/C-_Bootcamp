using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
	class Nkandla : HomeStead
	{
		private ChickenRun chickenRun;
		private SwimmingPool swimmingPool;
		private Amphitheatre amphitheatre;

		public Nkandla(string name, string district, string province, string country) : base(name, district, province, country) { }

		public ChickenRun ChickenRun
		{
			get { return this.chickenRun; }
			set { this.chickenRun = value; }
		}

		public SwimmingPool SwimmingPool
		{
			get { return this.swimmingPool; }
			set { this.swimmingPool = value; }
		}

		public Amphitheatre Amphitheatre
		{
			get { return this.amphitheatre; }
			set { this.amphitheatre = value; }
		}
	}
}
