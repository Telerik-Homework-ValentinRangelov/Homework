using System;
using System.Collections.Generic;
using System.Linq;
namespace Extension_Methods_Delegates_Lambda_LINQ
{
    public  class LongestString
    {
        public static void FindLongestString()
        {
            List<string> myList = new List<string>();
            myList.Add("My first string");
            myList.Add("And this is my second string");
            myList.Add("Anyway this is the longest string in my List of strings");

            var result = myList.Where(x => x.Length > 0).Last();
            Console.WriteLine(result);


        }


    }
}
