using MyService;
using System;
using System.ServiceModel;

namespace MyServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            {
                host.Open();
                Console.WriteLine("CalculatorService is now running. Press Enter to stop...");
                Console.ReadLine();
            }
        }
    }
}
