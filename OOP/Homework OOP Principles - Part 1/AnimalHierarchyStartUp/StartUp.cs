using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace AnimalHierarchyStartUp
{
    class StartUp
    {
        static void Main()
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog(10, "Bastur", "male"));
            dogs.Add(new Dog(12, "Mars", "male"));
            dogs.Add(new Dog(100, "Max", "famale"));

            List<Cat> cats = new List<Cat>();
            cats.Add(new Cat(15, "Ivka", "famale"));
            cats.Add(new Cat(18, "Mica", "male"));
            cats.Add(new Cat(12, "Jessy", "famale"));

            List<Frog> frog = new List<Frog>();
            frog.Add(new Frog(5, "FrogOne", "famale"));
            frog.Add(new Frog(6, "FrogTwo", "male"));
            frog.Add(new Frog(7, "FrogThree", "famale"));

            Console.WriteLine("Avarage age:" + Dog.CalculateAvarageAge(dogs));
            Console.WriteLine("Avarage age:"+Cat.CalculateAvarageAge(cats));
            Console.WriteLine("Avarage age:" + Frog.CalculateAvarageAge(frog));

            Cat cat = new Cat(5, "Ivan", "male");
            Animal.Sound(cat);
            //Console.WriteLine("Avarage age:"+Animal.CalculateAvarageAge(frog));

            

        }
    }
}
