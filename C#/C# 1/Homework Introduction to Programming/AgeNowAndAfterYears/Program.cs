using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeNowAndAfterYears
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write your Birthday (date.month.year)");
            DateTime YourBirthDay = DateTime.Parse(Console.ReadLine());
            DateTime TimeNow = DateTime.Today;
            int CurrentAge = TimeNow.Year - YourBirthDay.Year;
            ;
            if (TimeNow.Month <= YourBirthDay.Month && TimeNow.Day <= YourBirthDay.Day)
            {
                Console.WriteLine("Your current age is:" + (CurrentAge - 1) );
                Console.WriteLine("After 10 years you will be {0}", CurrentAge + 9);
            }
            else
            {
                Console.WriteLine("Your current age is:" + CurrentAge);
                Console.WriteLine("After then years you will be {0}", CurrentAge + 10);
            }
            Console.ReadLine();
        }
    }
}
