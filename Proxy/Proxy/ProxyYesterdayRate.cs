using System.Collections.Generic;

namespace Proxy
{
    public class ProxyYesterdayRate: IYesterdayRate
    {
        private readonly YesterdayRate _yesterdayRate;
        private readonly Dictionary<string, double> Rates = new Dictionary<string, double>();

        public double GetRate(string currency)
        {
            if (Rates.ContainsKey(currency))
            {
                return Rates[currency];
            }
            else
            {
               double rate =  _yesterdayRate.GetRate(currency);
               Rates.Add(currency, rate);
               return rate;
            }
        }

        public ProxyYesterdayRate(YesterdayRate yesterdayRate)
        {
            this._yesterdayRate = yesterdayRate;
        }
    }
}
