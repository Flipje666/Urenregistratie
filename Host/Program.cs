using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using UrenregistratieService;

namespace Host
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(UrenregistratieService.UrenregistratieService)))
            {
                host.Open();
                Console.WriteLine("Urenregistratieservice wordt gehost...");
                Console.WriteLine("Druk op een toets om af te sluiten.");
                Console.ReadKey();
            }
        }
    }
}
