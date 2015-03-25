using System.Collections.Generic;
using System.Linq;
namespace Extension_Methods_Delegates_Lambda_LINQ
{
    public class Student
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string fn { get; set; }
        public uint tel { get; set; }
        public List<int> marks = new List<int>();
        public uint groupNumber { get; set; }

        public Student(string firstname,string lastname,uint tel,uint groupNumber)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.tel = tel;
            this.groupNumber = groupNumber;
        }
        public static void GroupTwo(List<Student> list)
        {
            var result = list.Where(s => s.groupNumber == 2).ToArray();
            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }
        }
        
        public override string ToString()
        {
            return this.firstname + " " + this.lastname + " " + this.groupNumber + " group.";
        }
    }
}
