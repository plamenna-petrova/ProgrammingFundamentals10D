using System;
using System.Globalization;

namespace HolidaysBetweenTwoDates
{
    // Debugging and Code fixing - Task #2
    public class Program
    {
        static void Main(string[] args)
        {
            /*
                example input

                1)
                    Start Date: 1.05.2016
                    End Date: 15.05.2016
                2)
                    Start Date: 1.5.2016
                    End Date: 2.5.2016
                3)
                    Start Date: 15.5.2020
                    End Date: 10.5.2020
                4)
                    Start Date: 22.2.2020
                    End Date: 1.3.2020

                The format is d.M.yyyy because some of
                the input values don't have leading zeroes for
                the days or months
            */
            var startDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);

            var holidaysCount = 0;

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }

            Console.WriteLine(holidaysCount);
        }
    }
}
