using System;
using System.Linq;
namespace Extension_Methods_Delegates_Lambda_LINQ
{
    public static class DivisibleBy7and3
    {
        private static int[] arrOfInts = new int[200];
        private static Random randomInt = new Random();
        
        
        public static int[] GenerateArray()
        {
            for (int i = 0; i < 200; i++)
            {
                arrOfInts[i] = randomInt.Next(200);
            }
            
            return arrOfInts;
        }

        public static int[] AllDevidableNums()
        {

            var result = GenerateArray().Where(a => a % 7 == 0 && a % 3 == 0).ToArray();
            return result;
        }
    }
}
