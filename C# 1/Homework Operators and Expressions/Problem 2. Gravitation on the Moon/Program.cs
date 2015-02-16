using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Gravitation_on_the_Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            int gravitationMoon = 100*17/100;
            int weightOnEarth;
            Console.WriteLine("Please enter weight on earth:");
            weightOnEarth = int.Parse(Console.ReadLine());
            int weightOnMoon = (weightOnEarth*gravitationMoon/100 );
            Console.WriteLine("The weight on moon is:"+weightOnMoon);


        }
    }
}
