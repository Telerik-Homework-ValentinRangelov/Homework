

namespace Homework_Defining_Classes___Part_1
    
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Call
    {
        private DateTime date;
        private DateTime time;
        private string dialedPhone;
        private string number;
        private double duration;

        public Call(DateTime date, DateTime time, string dialedPhone, string number, double duration) : base()
        {
            this.date = date;
            this.time = time;
            this.dialedPhone = dialedPhone;
            this.number = number;
            this.duration = duration;
        }
        public DateTime Date
        {
            get
            {
                return this.date;
            }
            private set
            {
                this.date = value;
            }
        }

        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        public string DialedPhone
        {
            get { return this.dialedPhone; }
        }

        public string Number
        {
            get { return this.number; }
        }
        public double Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                this.duration = value;
            }
        }
    }
}