using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneDevice.Software;

namespace MobilePhoneDevice.Hardware
{
    class GSM
    {
        public string Model {get; private set;}
        public string Manfacturer { get; private set; }
        private decimal? price;
        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }
        private static GSM iPhone4S = new GSM("i-Phone 4S", "Apple", 140, null, new Battery("Apple battery", 100), new Display(new uint[] { 6, 8 }));
        private List<Call> callHistory = new List<Call>();
        //constructors
        public GSM(string model, string manufacterer)
            : this(model, manufacterer, null, null, null, null)
        {
        }
        public GSM(string model, string manufacterer, decimal? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manfacturer = manufacterer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;

        }
        //property IPhone4S
        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
            set
            {
                iPhone4S = value;
            }
        }
        //property price
        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid price");
                }
                this.price = value;
            }
        }
        
        //property call history
        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(this.callHistory);
                
            }
            set
            {
                this.callHistory = value;
            }
        }

        public void AddCall(Call call)
        {            
            this.callHistory.Add(call);
        }
        public void RemoveCall(int index)
        {
            this.callHistory.RemoveAt(index);
        }
        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }
        public decimal GetTotalCost(decimal pricePerMinute)
        {
            int totalLengthInSeconds = 0;
            foreach (var call in callHistory)
            {
                totalLengthInSeconds += call.Duration;
            }
            float totalTime = (totalLengthInSeconds / 60.0f);
            decimal totalCost = (decimal)totalTime * pricePerMinute;
            return totalCost;
        }

        public int GetLongestCallIndex()
        {
            int maxDuration = 0;
            int index = 0;
            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                if (this.CallHistory[i].Duration > maxDuration)
                {
                    maxDuration = this.CallHistory[i].Duration;
                    index = i;
                }
            }
            return index;
        }
        public override string ToString()
        {
            string newLine = Environment.NewLine;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("GSM:");
            sb.AppendLine(string.Format("[Model:{0}]",this.Model));
            sb.AppendLine(string.Format("[Manufacturer: {0}]", this.Manfacturer));
            if (price.HasValue)
            {
                sb.AppendLine(string.Format("[Price: {0}]",this.price));
            }
            if(!string.IsNullOrEmpty(Owner))
            {
                sb.AppendLine(this.Owner);
            }
            if(this.Battery!=null)
            {
                sb.AppendLine(this.Battery.ToString());
            }
            if (this.Display!=null)
            {
                sb.AppendLine(this.Display.ToString());
            }
            return sb.ToString();
        }
    }
}
