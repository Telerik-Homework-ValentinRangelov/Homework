namespace ClassLibrary1
{
    public class Person
    {
        private int? age;
        private string name;
        public Person(string name)
        {
            this.name = name;
            this.age = null;
        }
        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            if (this.age == null)
            {
                return this.name + " Age: Not specified.";
            }
            else
            {
                return this.name + " Age:" + this.age;
            }
        }
    }
}
