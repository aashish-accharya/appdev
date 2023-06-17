using System.Collections.Generic;

namespace week18;
class DayCount
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter list of integers representing days (1-7, where 1=Monday, 2=Tuesday, etc.) separated by commas:");
        string input = Console.ReadLine();
        string[] inputArr = input.Split(',');
        List<int> daysList = new List<int>();

        foreach (string str in inputArr)
        {
            daysList.Add(Int32.Parse(str));
        }
        Console.WriteLine("Enter start date (yyyy-MM-dd):");
        DateTime startDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter end date (yyyy-MM-dd):");
        DateTime endDate = DateTime.Parse(Console.ReadLine());

        List<Tuple<DateTime, string>> datesList = new List<Tuple<DateTime, string>>();
        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        {
            int dayOfWeek = (int)date.DayOfWeek + 1;
            if (daysList.Contains(dayOfWeek))
            {
                string dayOfWeekStr = Enum.GetName(typeof(DayOfWeek), date.DayOfWeek);
                datesList.Add(new Tuple<DateTime, string>(date, dayOfWeekStr));
            }
        }

        Console.WriteLine("\nDates and days on which specified days occur between start and end dates:");
        foreach (Tuple<DateTime, string> tuple in datesList)
        {
            Console.WriteLine($"{tuple.Item1.ToString("yyyy-MM-dd")} ({tuple.Item2})");
        }
        Console.ReadLine();
    }
}