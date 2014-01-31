using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneDevice.Software;
using MobilePhoneDevice.Hardware;
namespace MobilePhoneDevice
{
    class Program
    {
        static void Main()
        {
            GSMTest.Test();
            Console.WriteLine(new string('-',60));
            Console.WriteLine("SECOND TEST");
            Console.WriteLine(new string('-', 60));
            GSMCallHistoryTest.Test();
        }
    }
}
