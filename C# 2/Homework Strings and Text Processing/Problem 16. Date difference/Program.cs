using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your first date:[dd.mm.yyyy]");
            string datetimeOne = Console.ReadLine();
            Console.WriteLine("Enter your second date:[dd.mm.yyyy]");
            string datetimeTwo = Console.ReadLine();
            string[] datetimeOneSplit = datetimeOne.Split('.');
            string[] datetimeTwoSplit = datetimeTwo.Split('.');
            int year;
            int month;
            int day;
            day = int.Parse(datetimeOneSplit[0]) - int.Parse(datetimeTwoSplit[0]);
            month = int.Parse(datetimeOneSplit[1]) - int.Parse(datetimeTwoSplit[1]);
            year = int.Parse(datetimeOneSplit[2]) - int.Parse(datetimeTwoSplit[2]);
            day = Math.Abs(day);
            month = Math.Abs(month);
            year = Math.Abs(year);

            Console.Write("{0} years {1} months {2} days.", year, month, day);
            Console.WriteLine();
        }
    }

