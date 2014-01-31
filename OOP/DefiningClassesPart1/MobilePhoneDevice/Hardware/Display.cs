using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice.Hardware
{
    class Display
    {
        private uint[] size = new uint[2]; //intentional use of an array, to practice it (suggest it`s [width,height])
        public uint? NumberOfColors { get; set; }

        //default constructor
        public Display()
        {
        }

        //constructor
        public Display(uint[] size)
            : this(null, size)
        {
        }

        //constructor
        public Display(uint? numberOfColors,uint[] size)
        {
            this.NumberOfColors = numberOfColors;           

            this.Size[0] = size[0];
            this.Size[1] = size[1];            
        }

        //property size
        public uint[] Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = new uint[2];
                this.size[0] = value[0];
                this.size[1] = value[1];
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Size: [{0}:{1}]",this.Size[0],this.Size[1]));
            if(this.NumberOfColors.HasValue)
            {
                sb.AppendLine(string.Format("Number of colors: {0}",this.NumberOfColors));
            }
            return sb.ToString();
        }
    }
    
}
