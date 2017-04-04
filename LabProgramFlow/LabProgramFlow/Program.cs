using System;

namespace LabProgramFlow
{
    class Program
    {
        private static int price, paid, change;

        public static void Main()
        {
            Console.Write("Price? ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Paid? ");
            paid = Convert.ToInt32(Console.ReadLine());

            change = paid - price;
            Console.Write("Your change is {0}: \n", change);
            while (change > 0)
            {
                if (change >= 100)
                {
                    Console.WriteLine("100");
                    change -= 100;
                }
                else if (change >= 50)
                {
                    Console.WriteLine("50");
                    change -= 50;
                }
                else if (change >= 20)
                {
                    Console.WriteLine("20");
                    change -= 20;
                }
                else if (change >= 5)
                {
                    Console.WriteLine("5");
                    change -= 5;
                }
                else if (change >= 2)
                {
                    Console.WriteLine("2");
                    change -= 2;
                }
                else
                {
                    Console.WriteLine("1");
                    change -= 1;
                }

            }
        }
    }
}