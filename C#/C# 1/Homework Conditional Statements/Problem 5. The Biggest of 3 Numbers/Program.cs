using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.The_Biggest_of_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that finds the biggest of three numbers.*/
            int firstNumber, secondNumber, thirdNumber,biggestNumber;
            Console.WriteLine("Please enter first number:");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter third number:");
            thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("First number:{0}",firstNumber);
            Console.WriteLine("Second number:{0}",secondNumber);
            Console.WriteLine("Third number:{0}",thirdNumber);
            if (firstNumber>secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    biggestNumber = firstNumber;
                }
                else
                {
                    biggestNumber = thirdNumber;
                }
            }
            else
            {
                if (secondNumber > thirdNumber)
                {
                    biggestNumber = secondNumber;
                }
                else
                {
                    biggestNumber = thirdNumber;
                }
            }
            Console.WriteLine("The biggest number is:{0}",biggestNumber);


        }
    }
}
