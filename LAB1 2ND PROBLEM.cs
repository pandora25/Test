using System;

namespace ConsoleApp25
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number in the following format - MM/DD/YYYY");

            DateTime? firstDate = TryParseDate(Console.ReadLine());

            Console.WriteLine("Please enter a 2nd number in the following format - MM/DD/YYYY");

            DateTime? secondDate = TryParseDate(Console.ReadLine());

            if (firstDate.HasValue && secondDate.HasValue)
            {
                TimeSpan difference = secondDate.Value - firstDate.Value;

                Console.WriteLine("The result is " + Environment.NewLine + difference.TotalDays + " days " +
                                  Environment.NewLine + difference.TotalHours + " hours " + Environment.NewLine +
                                  difference.TotalMinutes + " minutes");
            }
            else
            {
                Console.WriteLine("You have not followed the instructions!");
            }

            Console.ReadLine();
        }

        private static DateTime? TryParseDate(string dateEntered)
        {
            DateTime date;
            if (DateTime.TryParse(dateEntered, out date))
            {
                return date;
            }
            else
            {
                return null;
            }
        }
    }
}

