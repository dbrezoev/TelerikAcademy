using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice.Hardware
{
    class Battery
    {        
        private string model;
        private double? hoursIdle; 
        private double? hoursTalk;
        public BatteryType BatteryType { get; set; }

        //constructor
        public Battery(string model)
            : this(model, null)
        {
        }

        //constructor
        public Battery(string model, double? hoursTalk)
            : this(model, null, null, BatteryType.NiCd)
        {
        }
        //constructor
        public Battery(string model, double? hoursIdle, double? hoursTalk, BatteryType batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        //property for model
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
          //property for hours idle
        public double? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {               
                this.hoursIdle = value;
                if (hoursIdle < 0)
                {
                    throw new ArgumentException("Hours idle cannot be negative");
                }           
            }
        }
        public double? HoursTalk
        {
            get { return this.hoursTalk; }
            set 
            {                
                this.hoursTalk = value;
                if (hoursTalk < 0)
                {
                    throw new ArgumentException("Hours talk cannot be negative");
                }
            }
        }
        
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Model: {0}",this.model));
            if (this.HoursIdle.HasValue)
            {
                sb.AppendLine(string.Format("Hours Idle: {0}",this.hoursIdle));
            }
            if(this.HoursTalk.HasValue)
            {
                sb.AppendLine(string.Format("Hours Talk: {0}",this.hoursTalk));
            }
            if(this.BatteryType!=null)
            {
                sb.AppendLine(string.Format("Battery Type: {0}",this.BatteryType));
            }
            return sb.ToString();
        }       
    }
}
