
namespace ClassLibrary2
{
    public class Tomcats : Cat
    {
        public Tomcats()
        {

        }
        public Tomcats(string name, int age)
        {
            base.Age = age;
            base.Name = name;
            base.Sex = "male";
        }

    }
}
