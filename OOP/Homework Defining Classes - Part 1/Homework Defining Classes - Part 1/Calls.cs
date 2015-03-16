using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Defining_Classes___Part_1
{
    public class Calls
    {
        private string date;
        private DateTime time;
        private uint dialledPhoneNum;
        private uint callDuration;

        public Calls(string date,DateTime time,uint dialledPhoneNum,uint callDuration)
        {
            this.date = date;
            this.time = time;
            this.dialledPhoneNum = dialledPhoneNum;
            this.callDuration = callDuration;
        }
        public uint CallDuration
        {
            get
            {
                return this.callDuration;
            }
        }
    }
}
