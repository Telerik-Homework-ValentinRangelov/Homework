using System.Collections.Generic;
using System.Linq;
namespace ClassLibrary2
{
    public class Animal  
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public static void Sound(Animal animal)
        {
            if (animal is Cat)
            {
                System.Console.WriteLine("Miaau said the Cat.");
            }
            if (animal is Dog)
            {
                System.Console.WriteLine("Bauuu Bauuu said the Dog.");
            }
            if (animal is Frog)
            {
                System.Console.WriteLine("Grop Grop said the Frog.");
            }


        }
        
    }
}
