using System;

namespace TravelTimeCalculatorPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Travel Time Calculator0 \n");
            Console.Write("Enter Miles: ");
            string miles = Console.ReadLine();
            Console.Write("Enter miles per hour: ");
            string speed = Console.ReadLine();
            int milesint = Int32.Parse(miles);
            int speedint = Int32.Parse(speed);
            int hours = (milesint / speedint);
            int minutes = (milesint % speedint);
            Console.WriteLine();
            Console.WriteLine("Estimated travel time");
            Console.WriteLine("Hours: " + hours);
            Console.Write("Minutes: " + minutes);
        }
    }
}
