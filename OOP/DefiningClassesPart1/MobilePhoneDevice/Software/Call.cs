using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MobilePhoneDevice.Software
{
    class Call
    {
        private DateTime date;
        private string dialedPhoneNumber;
        private int duration;

        //constructors
        public Call(DateTime date, string phoneNumber, int duration)
        {
            this.Date = date;
            this.DialedPhoneNumber = phoneNumber;
            this.Duration = duration;
        }

        //properties
        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                if (this.date>DateTime.Now)
                {
                    throw new ArgumentException("Wrong date");
                }
                this.date = value;
            }
        }

        public string DialedPhoneNumber
        {
            get
            {
                return this.dialedPhoneNumber;
            }
            set
            {
                this.dialedPhoneNumber = value;
                string pattern = @"[0]{1}[0-9]{9}"; // 08881234567 
                if (!Regex.IsMatch(dialedPhoneNumber,pattern))
                {
                    throw new ArgumentException("Wrong phone number");
                }
                
            }
        }
        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Duration cannot be less than 0 sec");
                }
                this.duration = value;
            }
        }

        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (this.Date!=null)
            {
                sb.Append("DATE: ");
                sb.Append(this.date);
                sb.Append(" ");
            }
            if (this.DialedPhoneNumber!=null)
            {
                sb.Append("Phone number: ");
                sb.Append(this.dialedPhoneNumber);
                sb.Append(" ");
            }
            sb.Append("Duration: ");
            sb.Append(this.duration);
            sb.Append(" sec.");
            return sb.ToString();
        }
    }
}
