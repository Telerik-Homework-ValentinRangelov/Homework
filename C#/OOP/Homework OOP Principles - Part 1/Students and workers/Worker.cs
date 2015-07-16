namespace Students_and_workers
{
    public class Worker : Human
    {
        public int WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }
        public int MoneyPerHour()
        {
            int moneyPerHour = (this.WeekSalary / 7) / this.WorkHoursPerDay;
            return moneyPerHour;
        }
        public override string ToString()
        {
            return string.Format(this.FirstName + " " + this.LastName + " Money Per Hour:" + this.MoneyPerHour()+"лв.");
        }
    }
}
