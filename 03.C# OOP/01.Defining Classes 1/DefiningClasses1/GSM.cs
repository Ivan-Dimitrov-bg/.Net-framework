using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneClass
{
    class GSM
    {
        private string model = " ";
        private string manufacturer = " ";
        private string owner = "";
        private float price = 0f;
        public Battery testBattery = new Battery();
        public Display testDisplay = new Display();
        static GSM iPhone4S = new GSM("IPhone4S", "Apple", "Ivan", 850); // task 6
        private List<Call> callHistory = new List<Call>();


        public GSM()
        { 
            this.model = "IPhone";
            this.manufacturer = "Apple";
            this.owner = "Irenaa";
            this.price = 645;
        }
        public GSM(string model, string manufacturer, float price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }
        public GSM(string model, string manufacturer, string owner, float price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.owner = owner;
            this.price = price;
        }

        public override string ToString()
        {
            StringBuilder fullClassInfo = new StringBuilder();
            fullClassInfo.Append("Model:" + model + "\n");
            fullClassInfo.Append("Manufacturer:" + manufacturer + "\n");
            fullClassInfo.Append("Owner:" + owner + "\n");
            fullClassInfo.Append("Price:" + price + "\n");
            fullClassInfo.Append("Battery Model:" + testBattery.Model + "\n");
            fullClassInfo.Append("Hours Idle:" + testBattery.HoursIdle + "\n");
            fullClassInfo.Append("Hours Talk:" + testBattery.HoursTalk + "\n");
            fullClassInfo.Append("Display colors:" + testDisplay.NumberOfColors + "\n");
            fullClassInfo.Append("Display size:" + testDisplay.Size + "\n");
            string classData = fullClassInfo.ToString();
            return classData;
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public static GSM IPhone4S             //task6
        {
            get { return iPhone4S; }
        }

        public List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }
         // methods task 10
        public void AddCalls(Call call)
        {
            callHistory.Add(call);
        }

        public void DeleteCalls(int callToBeRemoved)
        {
            callHistory.Remove(callHistory[callToBeRemoved]);
        }

        public void ClearCallHistory()
        {
            callHistory.Clear();
        }

        public float CalculatePriceForCalls(float callPrice)  //task 11
        {
            float totalDuration = 0f;
            foreach (var call in callHistory)
            {
                totalDuration += call.CallDuration;

            }
            return totalDuration * callPrice;
        }


    }
}
