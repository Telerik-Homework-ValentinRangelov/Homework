using System.Collections.Generic;
namespace School_classes
{
    public class Class : OptionalComments
    {
        private List<Students> students = new List<Students>();
        private List<Teachers> teachers = new List<Teachers>();
        public string uniqueTextIndetifier { get; set; }
    }
}
