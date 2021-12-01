using System;

namespace TravelTimeCalculatorPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int milesInt = 0;
            int speedInt = 0;
            do
            {
                try
                {
                    Console.WriteLine("Travel Time Calculator \n");
                    Console.Write("Enter Miles: ");
                    string miles = Console.ReadLine();
                    Console.Write("Enter miles per hour: ");
                    string speed = Console.ReadLine();
                    milesInt = Int32.Parse(miles);
                    speedInt = Int32.Parse(speed);
                    int hours = (milesInt / speedInt);
                    int minutes = (milesInt % speedInt);
                    Console.WriteLine();
                    Console.WriteLine("Estimated travel time");
                    Console.WriteLine("Hours: " + hours);
                    Console.WriteLine("Minutes: " + minutes);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Entered value must be an integer. Error: " + ex.Message);
                    Console.WriteLine();
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Entered value must be less than 2.4 billion. Error: " + ex.Message);
                    Console.WriteLine();
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Enter a value greater than zero. Error: " + ex.Message);
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong. Error: " + ex.Message);
                    Console.WriteLine();
                }
            }
            while (milesInt <= 0 || speedInt <= 0);
        }
    }
}