namespace Proxy
{
    public class Client
    {
        public double ClientCode(IYesterdayRate subject, string currency)
        {
            return subject.GetRate(currency);
        }
    }
}
