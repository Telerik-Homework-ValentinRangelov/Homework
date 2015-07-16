using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Refactor the following class using best practices for organizing straight-line code:
namespace Task_1.Class_Chef_in_CS
{

    public class Vegetable
    {
        public Vegetable() { }
    }

    public class Carrot : Vegetable
    {
        public Carrot() { }
    }

    public class Potato : Vegetable
    {
        public Potato() { }
    }

    public class Bowl
    {
        private List<Vegetable> vegetablesInTheBowl = new List<Vegetable>();
        public Bowl() { }
        public void Add(Vegetable vegetable)
        {
            vegetablesInTheBowl.Add(vegetable);
        }

        public List<Vegetable> Vegetables
        {
            get { return this.vegetablesInTheBowl; }
        }
    }

    public class Chef
    {

        private Bowl GetBowl()
        {
            return new Bowl();
        }
        private Carrot GetCarrot()
        {
            return new Carrot();

        }
        private void Cut(Vegetable potato)
        {
            //...
        }
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl;
            Peel(potato);

            Peel(carrot);
            bowl = GetBowl();
            Cut(potato);
            Cut(carrot);
            bowl.Add(carrot);

            bowl.Add(potato);
            Console.WriteLine("Coocking finished!!");
        }

        private Vegetable Peel(Vegetable vegetable)
        {
            return vegetable;
        }
        private Potato GetPotato()
        {
            return new Potato();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var chef = new Chef();
            chef.Cook();
        }
    }
}
