using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.The_Biggest_of_Five_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that finds the biggest of five numbers by using only five if statements.*/
            int firstNumber, secondNumber, thirdNumber,fourthNumber, fifthNumber,changableValue1,changableValue2, biggestNumber;
            Console.WriteLine("Please enter first number:");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter third number:");
            thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter fourth number:");
            fourthNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter fifth number:");
            fifthNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("First number:{0}", firstNumber);
            Console.WriteLine("Second number:{0}", secondNumber);
            Console.WriteLine("Third number:{0}", thirdNumber);
            Console.WriteLine("Fourth number:{0}", fourthNumber);
            Console.WriteLine("Fifth number:{0}", fifthNumber);
            if (firstNumber > secondNumber)
            {
                changableValue1 = firstNumber;
            }
            else
            {
                changableValue1 = secondNumber;
            }
            if (thirdNumber > fourthNumber)
            {
                changableValue2 = thirdNumber;
            }
            else
            {
                changableValue2 = fourthNumber;
            }
            if (changableValue1 > changableValue2)
            {
                if (changableValue1 > fifthNumber)
                {
                    biggestNumber = changableValue1;
                }
                else
                {
                    biggestNumber = fifthNumber;
                }
            }
            else
            {
                if(changableValue2>fifthNumber)
                {
                    biggestNumber = changableValue2;
                }
                else
                {
                    biggestNumber = fifthNumber;
                }
            }
            Console.WriteLine("The biggest number is:{0}",biggestNumber);
        }
    }
}
