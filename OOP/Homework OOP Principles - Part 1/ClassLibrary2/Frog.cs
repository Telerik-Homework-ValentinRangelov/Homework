using System.Linq;
using System.Collections.Generic;
namespace ClassLibrary2
{
    public class Frog : Animal
    {
        public Frog()
        {

        }
        public Frog(int age,string name,string sex)
        {
            base.Age = age;
            base.Name = name;
            base.Sex = sex;
        }
        public static int CalculateAvarageAge(List<Frog> frog)
        {
            int AvarageAge = (int)frog.Average(a => a.Age);
            return AvarageAge;
        }
    }
}
