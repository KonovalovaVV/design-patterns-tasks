namespace Proxy
{
    public class Client
    {
        private readonly IYesterdayRate _yesterdayRate;

        public Client(IYesterdayRate yesterdayRate)
        {
            _yesterdayRate = yesterdayRate;
        }

        public double GetCurrencyRate(string currency)
        {
            return _yesterdayRate.GetRate(currency);
        }
    }
}
