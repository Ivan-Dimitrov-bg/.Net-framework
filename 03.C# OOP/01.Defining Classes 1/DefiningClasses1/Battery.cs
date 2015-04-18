using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneClass
{
    class Battery
    {
        private string model = "";
        private int hoursTalk = 0;
        private int hoursIdle = 0;
        private enum BatteryType { LiIon, NiMH, NiCd };

        public Battery()
        {
            this.Model = null;
            this.HoursTalk = 0;
            this.HoursIdle = 0;
        }

        public Battery(string model, int hoursTalk, int hoursIdle)
        {
            this.Model = model;
            this.HoursTalk = hoursTalk;
            this.HoursIdle = hoursIdle;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }

        public int HoursIdle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }
    }
}
