using MyClient.MyServer;
using System;

namespace MyClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (CalculatorClient client = new CalculatorClient())
            {
                double num1 = 10;
                double num2 = 5;

                double resultAdd = client.Add(num1, num2);
                double resultSubtract = client.Subtract(num1, num2);

                Console.WriteLine($"Addition Result: {resultAdd}");
                Console.WriteLine($"Subtraction Result: {resultSubtract}");
            }

            Console.ReadLine();
        }
    }
}
