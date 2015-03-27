namespace Students_and_workers
{
    public class Student : Human
    {
        public int Grade { get; set; }
        public override string ToString()
        {
            return string.Format(this.FirstName + " " + this.LastName + " Grade:" + this.Grade);
        }
    }
}
