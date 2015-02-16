using System;

    class Program
    {
        static void CalculatesMinimum(int[] arr)
        {
            int minNumber = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minNumber)
                {
                    minNumber = arr[i];
                }
            }
            Console.WriteLine("Minimum number : {0}",minNumber);
        }
        static void CalculatesMaximum(int[] arr)
        {
            int maxNumber = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxNumber)
                {
                    maxNumber = arr[i];
                }
            }
            Console.WriteLine("Maximum number : {0}", maxNumber);

        }
        static void CalculatesAvarage(int[] arr)
        {
            decimal sum = 0;
            
            foreach (var element in arr)
            {
                sum += element;
            }
            decimal avarage = sum / arr.Length;
            Console.WriteLine("The avarage is: {0}",avarage);
        }
        static void CalculatesSum(int[] arr)
        {
            decimal sum = 0;

            foreach (var element in arr)
            {
                sum += element;
            }
            
            Console.WriteLine("The sum is: {0}", sum);
        }
        static void CalculatesProduct(int[] arr)
        {
            int product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            Console.WriteLine("The product is: {0}",product);
        }
        static void Main()
        {
            Console.Write("How much elements do you want to calculate? :");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter your {0} values",n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Number {0}:", (i + 1));
                arr[i] = int.Parse(Console.ReadLine());
            }
            CalculatesMinimum(arr);
            CalculatesMaximum(arr);
            CalculatesAvarage(arr);
            CalculatesSum(arr);
            CalculatesProduct(arr);
        }
    }

