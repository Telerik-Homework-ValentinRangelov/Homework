using System.Linq;
using System.Collections.Generic;
namespace ClassLibrary2
{
    public class Cat : Animal
    {
        public Cat()
        {

        }
        public Cat(int age,string name,string sex)
        {
            base.Age = age;
            base.Name = name;
            base.Sex = sex;
        }
        public static int CalculateAvarageAge(List<Cat> cat)
        {
            int AvarageAge = (int)cat.Average(a => a.Age);
            return AvarageAge;
        }
    }
}
