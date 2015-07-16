namespace Extension_Methods_Delegates_Lambda_LINQ
{
    public class Students
    {
        private string firstName;
        private string lastName;
        private int age;

        public Students(string first,string last,int age)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        public override string ToString()
        {
            return this.firstName + " " + this.lastName +" "+ this.age + " years old.";
        }
    }
}
