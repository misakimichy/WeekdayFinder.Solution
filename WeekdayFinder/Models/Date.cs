using System;
using WeekdayFinder;

namespace WeekdayFinder.Models
{
    public class Date
    {
        public static string GetDate(int day, int month, int year)
        {
            DateTime newDay = new DateTime(year, month, day);
            string date = string.Format("{0:dddd}", newDay);
            return date;
        }
    }
}