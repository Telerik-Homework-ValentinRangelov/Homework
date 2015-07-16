
namespace ClassLibrary2
{
    public class Kitten : Cat
    {
        public Kitten()
        {

        }
        public Kitten(string name, int age)
        {
            base.Age = age;
            base.Name = name;
            base.Sex = "famale";
        }
    }
}
