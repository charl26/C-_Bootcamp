using System;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        private static float distance;
        private static float hours, minutes, seconds;
        private static float metersPerSecond;
        private static float kilometersPerHour, milesPerHour;
        private static float timeSec;

        static void Main()
        {
            /*
             * input feed
            */
            Console.Write("Enter distance(meters): ");
            distance = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter timeSec(hour): ");
            hours = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter timeSec(minutes): ");
            minutes = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter timeSec(seconds): ");
            seconds = Convert.ToSingle(Console.ReadLine());

            /*
             * calculations
            */
            timeSec = (hours * 3600) + (minutes * 60) + seconds;
            metersPerSecond = distance / timeSec;
            kilometersPerHour = (distance / 1000.0f) / (timeSec / 3600.0f);
            milesPerHour = kilometersPerHour / 1.609f;

            /*
             * output with 5 sec wait
             */
            Console.WriteLine("this will take 5 second to load ;)");
            System.Threading.Thread.Sleep(5000);

            Console.WriteLine("Your speed in meters/sec is {0}", metersPerSecond
                + "\nYour speed in km/h is {0}", kilometersPerHour
                + "Your speed in miles/h is {0}", milesPerHour);

        }
    }
}