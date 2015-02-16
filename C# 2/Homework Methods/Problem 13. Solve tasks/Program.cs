using System;
//Write a program that can solve these tasks:
//   Reverses the digits of a number
//   Calculates the average of a sequence of integers
//   Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//   The decimal number should be non-negative
//   The sequence should not be empty
//   a should not be equal to 0

class Program
{
    static void ReverseNumber()
    {
        Console.Write("Please enter your number which you want to reverse:(It cannot be negative)");
        int a = int.Parse(Console.ReadLine());
        
        while (true)
        {
            if (a >= 0)
            {
                break;
            }
            Console.WriteLine("Your number cannot be negative.");
            Console.Write("Enter your value again:");
            a = int.Parse(Console.ReadLine());
        }
        string reversedNum = null;
        string numLenght = a.ToString();
        for (int i = 0; i < numLenght.Length; i++)
        {
            reversedNum += (a % 10);
            a = a / 10;
        }
        Console.WriteLine("Reversed number: {0}.",reversedNum);
    }
    static void CalculatesAvarage()
    {
        Console.Write("How much integer numbers do you want to input? :");
        int n = int.Parse(Console.ReadLine());
        while (true)
        {
            if (n > 0)
            {
                break;
            }
            Console.WriteLine("Your number cannot be zero or less.");
            Console.Write("Enter your value again:");
            n = int.Parse(Console.ReadLine());
        }
        int[] arr = new int[n];
        Console.WriteLine("Enter the values of your {0} numbers",n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("Number {0} :",(i+1));
            arr[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        foreach (var element in arr)
        {
            sum += element;
        }
        sum /= n;
        Console.WriteLine("The avarage of your numbers is: {0}.",sum);
    }
    static void LinearEquation()
    {
        Console.WriteLine("ax + b = 0");
        Console.Write("Enter your 'a' value:");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("Enter your 'b' value:");
        decimal b = decimal.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("0x + b = 0");
            if (b == 0)
            {
                Console.WriteLine("0x = 0");
                Console.WriteLine("Every number is solution.");
            }
            else
            {
                Console.WriteLine("The eaquation does not have a solution.");
            }
        }
        else
        {
            decimal x = (-b / a);
            Console.WriteLine("ax + b = 0");
            Console.WriteLine("x = -b / a");
            Console.WriteLine("x = -{0} / {1}",b,a);
            Console.WriteLine("x = {0:0.00}",x);
        }
    }
    static void Main()
    {
        Console.WriteLine("Please choose which task do you want to solve:");
        Console.WriteLine("1.Reverse a number.");
        Console.WriteLine("2.Calculates the avarage of a sequence of integers.");
        Console.WriteLine("3.Solve a linear equation a * x + b = 0.");
        Console.WriteLine();
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine();

        bool noSuchATask = true;
        while (noSuchATask)
        {
            if (a == 1)
            {
                noSuchATask = false;
                ReverseNumber();
            }
            else if (a == 2)
            {
                noSuchATask = false;
                CalculatesAvarage();
            }
            else if (a == 3)
            {
                noSuchATask = false;
                LinearEquation();
            }
            else
            {
                Console.WriteLine("There is no such a task.Please enter 1 , 2 or 3.");
                Console.Write("Enter your value again:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }

    }
}

