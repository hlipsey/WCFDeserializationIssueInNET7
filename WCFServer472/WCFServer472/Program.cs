using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFServer472
{
    internal class Program
    {
        static void Main()
        {
            WCFHost host = new WCFHost();
            host.StartService();
            Console.ReadLine();
            host.StopService();
        }
    }
}
