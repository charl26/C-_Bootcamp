using System;


namespace Lab2
{
    class Program
    {
        private static long[] InputNumbers = new long[5];

        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {

                Console.Write("Please input a number {0} =  ", i + 1);
                InputNumbers[i] = Convert.ToInt64(Console.ReadLine());
            }
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(InputNumbers[i]);
            }
            Console.WriteLine("Thank you. Bye");
        }
    }
}