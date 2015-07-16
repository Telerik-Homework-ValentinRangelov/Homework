using System.Linq;
using System.Collections.Generic;
namespace ClassLibrary2
{
    public class Dog : Animal
    {
        public Dog()
        {

        }
        public Dog(int age,string name,string sex)
        {
            base.Age = age;
            base.Name = name;
            base.Sex = sex;
        }
        public static int CalculateAvarageAge(List<Dog> dog)
        {
            int AvarageAge = (int)dog.Average(a => a.Age);
            return AvarageAge;
        }
    }
}
