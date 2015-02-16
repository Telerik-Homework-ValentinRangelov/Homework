using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Comparing_Floats_Sterred_
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue;
            double secondValue;
            
            Console.WriteLine("Comparing two floating point numbers:");
            Console.WriteLine("Insert your first floating value:");
            if (double.TryParse(Console.ReadLine(), out firstValue))
            { }
            
            Console.WriteLine("Insert your second floating value:");

            if (double.TryParse(Console.ReadLine(), out secondValue))
            { }
            
            double thirdValue = (double)firstValue - (double)secondValue;
            Console.WriteLine("third value is:"+(double)thirdValue);
            bool comparingNumbers =  ((double)thirdValue<0.000001);
            if (comparingNumbers)
            {
                Console.WriteLine("Difference between first and second value: "+ (double)thirdValue);
                Console.WriteLine("They are equal.");
            }
            else{
                Console.WriteLine("Difference between first and second value: " + (double)thirdValue);
            Console.WriteLine("They are not equal.");
            }
            
        }
    }
}
