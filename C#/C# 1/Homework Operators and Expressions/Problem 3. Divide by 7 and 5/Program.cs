using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Divide_by_7_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueSeven = 7;
            int valueFive = 5;
            int firstGivenInt = 100;
            int secondGivenInt = 140;
            int thirdGivenInt = 35;
            //delene na chisloto 100
            bool dividing100withFive = (firstGivenInt % valueFive ==0);
            bool dividing100withSeven = (firstGivenInt % valueSeven == 0);
            if (dividing100withFive)
            {
                if(dividing100withSeven)
                {
                    Console.WriteLine(firstGivenInt+" can be devided by 7 and 5 at the same time.");
                }
                else
                {
                    Console.WriteLine(firstGivenInt+" cannot be divided by 7 and 5 at the same time.");
                }
            }
            else
            {
                Console.WriteLine(firstGivenInt + " cannot be divided by 7 and 5 at the same time.");
            }
            //delene na chisloto 140
            bool dividing140withFive = (secondGivenInt % valueFive == 0);
            bool dividing140withSeven = (secondGivenInt % valueSeven == 0);
            if (dividing140withFive)
            {
                if (dividing140withSeven)
                {
                    Console.WriteLine(secondGivenInt + " can be devided by 7 and 5 at the same time.");
                }
                else
                {
                    Console.WriteLine(secondGivenInt + " cannot be divided by 7 and 5 at the same time.");
                }
            }
            else
            {
                Console.WriteLine(secondGivenInt + " cannot be divided by 7 and 5 at the same time.");
            }
            //delene na chisloto 35
            bool dividing35withFive = (thirdGivenInt % valueFive == 0);
            bool dividing35withSeven = (thirdGivenInt % valueSeven == 0);
            if (dividing35withFive)
            {
                if (dividing35withSeven)
                {
                    Console.WriteLine(thirdGivenInt + " can be devided by 7 and 5 at the same time.");
                }
                else
                {
                    Console.WriteLine(thirdGivenInt + " cannot be divided by 7 and 5 at the same time.");
                }
            }
            else
            {
                Console.WriteLine(thirdGivenInt + " cannot be divided by 7 and 5 at the same time.");
            }
        }
    }
}
