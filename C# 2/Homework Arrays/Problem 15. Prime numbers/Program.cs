using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm. */
            bool[] primes = new bool[10000000];

            // Find all prime numbers in the range [1...10 000 000]
            for (int i = 2; i < Math.Sqrt(primes.Length); i++)
            {
                // Skip those that are not prime
                if (primes[i] == false)
                {
                    for (int j = i * i; j < primes.Length; j += i)
                    {
                        primes[j] = true;
                    }
                }
            }

            // Print all prime numbers in the range [1...10 000 000]
            for (int i = 2; i < primes.Length; i++)
            {
                if (!primes[i]) Console.Write(i + " ");
            }

        }
    }
}
