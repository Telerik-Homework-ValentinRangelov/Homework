using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
             Use a sequence of if operators.*/
            int firstNumber, secondNumber, thirdNumber;
            Console.WriteLine("Please enter your first number:");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number:");
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your third number:");
            thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("First number:{0}",firstNumber);
            Console.WriteLine("Second number:{0}",secondNumber);
            Console.WriteLine("Third number:{0}",thirdNumber);

            if (firstNumber>0) 
            {
                if (secondNumber>0)
                {
                    if (thirdNumber>0)
                    {
                        Console.WriteLine("The sign is: ' + ' ");
                    }
                    else
                    {
                        if(thirdNumber==0)
                        {
                            Console.WriteLine("The sign is: ' 0 ' ");
                        }
                        else
                        {
                            Console.WriteLine("The sign is: ' - ' ");

                        }
                    }
                }
                else
                {
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("The sign is: ' 0 ' ");
                    }
                    else
                    {
                        if (thirdNumber < 0)
                        {
                            Console.WriteLine("The sign is: ' + ' ");
                        }
                        else
                        {
                            Console.WriteLine("The sign is: ' - ' ");
                        }

                    }
                        
                }

            }
            else
            {
                if (firstNumber == 0)
                {
                    Console.WriteLine("The sign is: ' 0 ' ");
                }
                else
                {
                    if(secondNumber<0)
                    {
                        if(thirdNumber<0)
                        {
                            Console.WriteLine("The sign is: ' - ' ");
                        }
                        else
                        {
                            Console.WriteLine("The sign is: ' + ' ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The sign is: ' - ' ");
                    }
                }
            }

            
        }
    }
}
