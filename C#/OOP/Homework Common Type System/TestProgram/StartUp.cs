using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace TestProgram
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var person = new Person("Valentin");
            Console.WriteLine(person);
            var anotherPerson = new Person("Petur", 20);
            Console.WriteLine(anotherPerson);
        }
    }
}
