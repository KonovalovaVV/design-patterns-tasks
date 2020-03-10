using System;

namespace Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            string currency = "euro";

            Console.WriteLine("Client: Executing the client code with a real subject:");
            YesterdayRate realSubject = new YesterdayRate();
            Console.WriteLine("{0} exchange rate is {1}", currency, client.ClientCode(realSubject, currency));

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            ProxyYesterdayRate proxy = new ProxyYesterdayRate(realSubject);
            Console.WriteLine("{0} exchange rate is {1}", currency, client.ClientCode(proxy, currency));


            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy for the second time:");
            Console.WriteLine("{0} exchange rate is {1}", currency, client.ClientCode(proxy, currency));

        }
    }
}