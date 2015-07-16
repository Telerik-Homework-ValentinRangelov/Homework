using System;

class Program
{
//       Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//       Use the method from the previous exercise.

    static void FirstLargerThanNeighbours(int[] arr)
    {
        for (int i = 1; i < arr.Length-1; i++)
        {
            if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
            {
                Console.WriteLine("First number larger than its neigbours is:{0} at Index[{1}].",arr[i],i);
                Console.WriteLine("{0} is bigger than {1} and {2}. ", arr[i],arr[i-1],arr[i+1]);
                return;

            }
        }
        Console.WriteLine("-1");
    }
    static void Main()
    {
        Console.Write("How much elements in the array do you want:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        //Random nums to the array
        Random randomNum = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = randomNum.Next(100);
        }
        //Printing the array
        for (int k = 0; k < n; k++)
        {
            Console.WriteLine("Index[{0}] : {1}", k, arr[k]);
        }
        FirstLargerThanNeighbours(arr);
    }
}
