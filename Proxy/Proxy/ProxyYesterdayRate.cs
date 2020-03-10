using System.Collections.Generic;

namespace Proxy
{
    public class ProxyYesterdayRate: IYesterdayRate
    {
        private readonly YesterdayRate _yesterdayRate;
        private readonly Dictionary<string, double> _rates = new Dictionary<string, double>();

        public double GetRate(string currency)
        {
            if (_rates.TryGetValue(currency, out double value))
            {
                return value;
            }
            else 
            { 
               value =  _yesterdayRate.GetRate(currency);
               _rates.Add(currency, value);
               return value;
            }
        }

        public ProxyYesterdayRate(YesterdayRate yesterdayRate)
        {
            this._yesterdayRate = yesterdayRate;
        }
    }
}
