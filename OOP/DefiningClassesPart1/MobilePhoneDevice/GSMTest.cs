using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneDevice.Hardware;
using MobilePhoneDevice.Software;

namespace MobilePhoneDevice
{
    class GSMTest
    {
        public static void Test()
        {           
            GSM[] arr = new GSM[]{
                new GSM("NOKIA","CHINA"),                
                new GSM("SONY","JAPAN",100,"John",new Battery("toshiba"),new Display()),                
                new GSM("Samsung","Korea",120m,"Pesho",new Battery("VARTA",4.50d,0.50d,BatteryType.NiMH),new Display()),
                new GSM("Samsung","Korea",120m,"Pesho",new Battery("model"),new Display(2000,new uint[]{8,4}))
            };

            foreach (GSM gsm in arr)
            {
                Console.WriteLine(gsm);
                Console.WriteLine(new string('-', 60));
            }

            Console.WriteLine(GSM.IPhone4S);

        }
    }
}
