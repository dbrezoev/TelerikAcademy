using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneDevice.Hardware;
using MobilePhoneDevice.Software;
namespace MobilePhoneDevice
{
    class GSMCallHistoryTest
    {
        public const decimal pricePerMinute = 0.37m;
        public static void Test()
        {
            GSM gsm = new GSM("Nokia", "China");
            gsm.AddCall(new Call(DateTime.Now,"0889888888",45));
            gsm.AddCall(new Call(DateTime.Now,"0889884388",60));
            gsm.AddCall(new Call(DateTime.Now,"0889321988",130));
            gsm.AddCall(new Call(DateTime.Now,"0889884583",34));            
            foreach (Call call in gsm.CallHistory)
            {
                Console.WriteLine(call);
            }
            
            //print total cost of all calls
            Console.WriteLine("{0:C2}",gsm.GetTotalCost(pricePerMinute));

            int longestCallIndex = gsm.GetLongestCallIndex();
            gsm.RemoveCall(longestCallIndex);
           
            foreach (Call call in gsm.CallHistory)
            {
                Console.WriteLine(call);
            }

            //clear all the call history
            gsm.ClearCallHistory();
            foreach (var item in gsm.CallHistory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
