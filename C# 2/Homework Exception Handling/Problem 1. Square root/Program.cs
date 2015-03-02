using System;
//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

namespace Problem_1.Square_root
{
    class Program
    {
        static void Main()
        {
            
            SquareRoot();
        }
        static void SquareRoot()
        {
            double sqrtNum;
            try
            {
                Console.WriteLine("Please enter your number:");
                double number = double.Parse(Console.ReadLine());
                sqrtNum = Math.Sqrt(number);
                Console.WriteLine("The sqrt of the number is: {0}",sqrtNum);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid input!The number is too big or too small! ");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid input! Can not calculate square root of negaive number!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid input! End of input is wrong!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Data entered is not a valid number!");
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
    }
}
