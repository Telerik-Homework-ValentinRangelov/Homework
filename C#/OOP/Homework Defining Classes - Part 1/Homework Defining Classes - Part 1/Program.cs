
using System;
namespace Homework_Defining_Classes___Part_1
{

    public class Program
    {
        static void Main()
        {
            Console.WriteLine("How many phones do u want?");
            int numOfPhones = int.Parse(Console.ReadLine());
            GSMTest.CreateGSMs(numOfPhones);
            
            

        }
    }
}
