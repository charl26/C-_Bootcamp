using System;
using System.Text;

namespace UnitTestProject1
{
	internal class NumberConverter
	{
		internal object convertNumber(string v)
		{
			int result = 0;
			int index = 0;

			while (index != v.Length)
			{
				if ('I' == v[index])
				{
					result += 1;
				}

				else if ('V' == v[index])
				{
					if (v == "IV")
						result += 3;
					else
						result += 5;
				}

				else if ('X' == v[index])
				{
					if (v == "IX")
						result += 8;
					else
						result += 10;
				}

				else if ('L' == v[index])
				{
					result += 50;
				}

				else if ('C' == v[index])
				{
					result += 100;
				}

				else if ('D' == v[index])
				{
					result += 500;
				}

				else if ('M' == v[index])
				{
					result += 1000;
				}
				index++;
			}
			if (result > 0)
				return result;
			else
				return -1;
		}
	}
}