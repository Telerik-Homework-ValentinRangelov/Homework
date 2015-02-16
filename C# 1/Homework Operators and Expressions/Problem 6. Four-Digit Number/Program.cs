using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Four_Digit_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int digitA, digitB, digitC, digitD;
            Console.WriteLine("Please enter your 4 digits:");
            Console.WriteLine("Your first digit can't be 0!");


            Console.WriteLine("First digit:");
            digitA = int.Parse(Console.ReadLine());
            bool firstDigitZero = digitA == 0;
            while (firstDigitZero)
            {
                Console.WriteLine("Your digit can't be 0, please enter your first digit value again:");
                digitA = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Second digit:");
            digitB = int.Parse(Console.ReadLine());
            Console.WriteLine("Third digit:");
            digitC = int.Parse(Console.ReadLine());
            Console.WriteLine("Fourth digit:");
            digitD = int.Parse(Console.ReadLine());
            int sumOfDigits = digitA + digitC + digitB + digitD;
            Console.WriteLine("The sum of your four digits is:" + digitA + "+" + digitB + "+" + digitC + "+" + digitD + "=" + sumOfDigits);
            string reversedNumbers = "The reversed order of the digits is:" + digitD + digitC + digitB + digitA;
            Console.WriteLine(reversedNumbers);
            string lastDigitFirst = "The last digit in first position:" + digitD + digitA + digitB + digitC;
            Console.WriteLine(lastDigitFirst);
            string secondThirdDigitExchanging = "Exchanging the second and third digit:" + digitA + digitC + digitB + digitD;
            Console.WriteLine(secondThirdDigitExchanging);
            Console.ReadLine();
        }
    }
}
