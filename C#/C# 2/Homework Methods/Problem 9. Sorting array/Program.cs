using System;
class Program
{
    //      Write a method that return the maximal element in a portion of array of integers starting at given index.
    //      Using it write another method that sorts an array in ascending / descending order.
    static int[] ArraySortedInDescendingOrder(int[] arr)
    {
        ArraySortedInAscendingOrder(arr);
        Array.Reverse(arr);
        return arr;
    }
    static int[] ArraySortedInAscendingOrder(int[] arr)
    {

        Array.Sort(arr);
        return arr;

    }
    static int MaxElementInArrayFromGivenIndex(int index, int[] arr)
    {
        int maxElement = int.MinValue;
        for (int i = index; i < arr.Length; i++)
        {
            if (arr[i] > maxElement)
            {
                maxElement = arr[i];
            }
        }
        return maxElement;
    }
    static void Main()
    {
        Console.Write("How much elements do you want to have the array:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Random randomNumber = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = randomNumber.Next(100);
        }
        for (int k = 0; k < n; k++)
        {
            Console.WriteLine("Index[{0}] : {1}",k,arr[k]);
        }
        Console.Write("From which Index do you want to start the search of the max element? :");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("The maximum element starting from index[{0}] is {1}",index,MaxElementInArrayFromGivenIndex(index,arr));
        Console.WriteLine("Array sorted in ascending order:");
        ArraySortedInAscendingOrder(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Index[{0}]: {1}.", i, arr[i]);
        }
        Console.WriteLine("Array sorted in descending order:");

        ArraySortedInDescendingOrder(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Index[{0}]: {1}.", i, arr[i]);
        }
        
    }
}

