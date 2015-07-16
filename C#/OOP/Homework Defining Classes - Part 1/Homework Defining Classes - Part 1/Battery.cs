namespace Homework_Defining_Classes___Part_1
{
    public class Battery
    {
        private string model;
        private string hoursIdle;
        private decimal hoursTalk;
        private enum BatteryType
        {
            LiIon,
            NiMH,
            NiCd
        }
        public Battery(string model,string hoursIdle,decimal hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public string HoursIdle
        {
            get
            {
                return this.HoursIdle;
            }
            set
            {
                this.HoursIdle = value;
            }
        }
      

    }
}
