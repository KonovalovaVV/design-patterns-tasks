using System;

namespace Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            YesterdayRate realSubject = new YesterdayRate();
            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            ProxyYesterdayRate proxy = new ProxyYesterdayRate(realSubject);
            client.ClientCode(proxy);
        }
    }
}