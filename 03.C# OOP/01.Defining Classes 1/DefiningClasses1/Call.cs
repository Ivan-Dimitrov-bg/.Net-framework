using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneClass
{

    class Call
    {
        private string date;
        private string time;
        private string dialedPhoneNum;
        private int callDuration;

        public Call(string date, string time, string dialedPhoneNum, int callDuration)
        {
            this.date = date;
            this.time = time;
            this.dialedPhoneNum = dialedPhoneNum;
            this.callDuration = callDuration;
        }
        public string Date
        {
            get { return date; }
            set { this.date = value; }
        }
        public string Time
        {
            get { return time; }
            set { this.time = value; }
        
        }
        public string DialedPhoneNum
        {
            get { return dialedPhoneNum; }
            set { this.dialedPhoneNum = value; }
        }
        public int CallDuration
        {
            get { return callDuration; }
            set { this.callDuration = value; }
        
        }
    }
}