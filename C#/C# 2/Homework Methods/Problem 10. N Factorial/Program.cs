using System;
using System.Numerics;
class Program
{
    //          Write a program to calculate n! for each n in the range [1..100].
    //          Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
    static BigInteger NFactorialForEachNum(BigInteger n) 
    {
        BigInteger sum=1;
        
        for (BigInteger i = n; i >= 1; i--)
        {
            sum = sum * i;
        }
        return sum;
    }
    static void Main()
    {

        BigInteger n = 1;
        while (n < 101)
        {

            Console.WriteLine("N Factorial of {0} is : {1}", n, NFactorialForEachNum(n));
            Console.WriteLine();
            n++;
        }
    }
}

