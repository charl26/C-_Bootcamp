using System;

namespace ProgramFlow2
{
    class Program
	{
		private static int numberGiven;
		private static int result;

		static void Main()
		{
			Console.WriteLine("number? ");
			numberGiven = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("number? " + numberGiven);
		while (numberGiven > 0)
		{
			if (0 == (numberGiven % 2)) 
			{ 
				Console.WriteLine("Adding " + numberGiven);
				result += numberGiven;
				numberGiven--;
			}
            else
			{
				Console.WriteLine("Not Adding " + numberGiven);
				numberGiven--;
			}

		}
		Console.WriteLine("Your total is " + result);
        }
    }
}