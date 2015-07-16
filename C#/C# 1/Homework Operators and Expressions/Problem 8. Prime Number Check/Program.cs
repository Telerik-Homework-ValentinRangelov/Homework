using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Prime_Number_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("This program checks if  given positive integer number n (n <= 100) is prime \n(i.e. it is divisible without remainder only to itself and 1).");
            Console.WriteLine("\nWrite a positive number ( number should be from 1 to 100 ):");
            number = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int i=2; i<=Math.Sqrt(number);i++)
            {
                if(number%i==0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime);
        
            
        }
    }
}
