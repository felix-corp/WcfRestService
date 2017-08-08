using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace RestWCFServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(RestWCFServiceLibrary.RestWCFService)))
            {
                host.Open();
                Console.WriteLine("Host started @ " + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
