using System;

namespace Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            YesterdayRate realSubject = new YesterdayRate();
            ProxyYesterdayRate proxy = new ProxyYesterdayRate(realSubject);
            Client realClient = new Client(realSubject);
            Client proxyClient = new Client(proxy);
            string currency = "euro";

            Console.WriteLine("Client: Executing the client code with a real subject:");
            Console.WriteLine("{0} exchange rate is {1}", currency, realClient.GetCurrencyRate(currency));

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            Console.WriteLine("{0} exchange rate is {1}", currency, proxyClient.GetCurrencyRate(currency));

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy for the second time:");
            Console.WriteLine("{0} exchange rate is {1}", currency, proxyClient.GetCurrencyRate(currency));

        }
    }
}