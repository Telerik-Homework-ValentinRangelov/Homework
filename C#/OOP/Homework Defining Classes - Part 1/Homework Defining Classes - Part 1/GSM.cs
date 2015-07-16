using System.Collections.Generic;
namespace Homework_Defining_Classes___Part_1
{
    public class GSM
    {
        private const double PricePerMin = 0.37;
        private Battery battery;
        private Display display;
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        public static string IPhone4SInfo = "iPhone 4S is a phone that has been released in 2011 with iOS version 5.0. Now iPhone" +
                                  "4S supports the newest iOS version (8.1) and still performs pretty well and fluent.";
        private List<Call> callHistory = new List<Call>(); 

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }
        public void DeleteCall(Call number)
        {
            this.callHistory.Remove(number);
        }
        public void AddCall(Call number)
        {
            this.callHistory.Add(number);
        }
        public void RemoveAllCalls(Call number)
        {
            int index = callHistory.IndexOf(number);
            if (index != -1)
            {
                this.callHistory.RemoveAt(index);
            }
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
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public GSM(string model,string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer,decimal price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public void ShowInformation()
        {
            System.Console.WriteLine("Model:{0} , Manufacturer:{1} , Price:{3}",this.model,this.manufacturer,this.price);
        }
        public override string ToString()
        {
            return this.model;
        }
        public double CalculateTotalPrice(double pricePerMinute)
        {
            double spentMoney = 0.0;
            double entireDuration = 0.0;
            for (int i = 0; i < CallHistory.Count; i++)
            {
                entireDuration += CallHistory[i].Duration;
            }
            spentMoney += (entireDuration * pricePerMinute);
            return spentMoney;
        }
    }
}
