using System;

namespace LabNUnit
{
	internal class FizzBuzz
	{
		private string str;

		public FizzBuzz() { }

		public string PrintFizzBuzz()
		{
			str = str + "12";
			for (int i = 3; i <= 100; i++)
			{
				if ((i % 3) == 0 && (i % 5) == 0)
					str = str + "FizzBuzz";
				else if ((i % 3) == 0)
				{
					str = str + "Fizz";
				}
				else if ((i % 5) == 0)
				{
					str = str + "Buzz";
				}
				else
					str = str + i.ToString();
			}

			return str;
		}

		public string PrintFizzBuzz(int j)
		{
			{
				if (j == 1)
					str = "1";
				else
				{
					str = str + "12";
					for (int i = 3; i <= j; i++)
					{
						if ((i % 3) == 0 && (i % 5) == 0)
							str = str + "FizzBuzz";
						else if ((i % 3) == 0)
						{
							str = str + "Fizz";
						}
						else if ((i % 5) == 0)
						{
							str = str + "Buzz";
						}
						else
							str = str + i.ToString();
					}
				}
				return str;
			}
		}
	}
}