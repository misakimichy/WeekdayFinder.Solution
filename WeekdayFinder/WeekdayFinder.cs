using System;
using WeekdayFinder.Models;

namespace WeekdayFinder
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the date Weekday Finder");
            Console.WriteLine("Please input a day of the year and we'll return the date.");
            Console.WriteLine("Which day (dd)");
            int dayInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Which month (mm)");
            int monthInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Which year (yyyy)");
            int yearInput = int.Parse(Console.ReadLine());
            Console.WriteLine($"It's {Date.GetDate(dayInput, monthInput, yearInput)}.");
        }
    }
}