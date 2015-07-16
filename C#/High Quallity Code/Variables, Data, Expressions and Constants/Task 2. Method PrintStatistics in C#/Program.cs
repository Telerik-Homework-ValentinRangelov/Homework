using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Statistic
    {
        private static void PrintMax(double max)
        {
            Console.WriteLine(max);
        }
        private void PrintMin(double min)
        {
            Console.WriteLine(min);

        }
        private void PrintAvg(double average)
        {
            Console.WriteLine(average);
        }
        public void PrintStatistics(double[] arr, int count)
        {
            double max = double.MinValue;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Statistic.PrintMax(max);

            double min = double.MaxValue;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            PrintMin(min);

            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += arr[i];
            }
            PrintAvg(sum / count);
        }






    }




    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 2.3, 3.4, 4.1 ,7.1,6.2,10.1, 1.0};
            var statistic = new Statistic();
            statistic.PrintStatistics(arr, arr.Length);
        }
    }
}
