using System;
using System.Collections.Generic;

namespace Proxy
{
    public class YesterdayRate: IYesterdayRate
    {
        private readonly Dictionary<string, double> _rates = new Dictionary<string, double>
        {
            {"euro", 26.5},
            {"dollar", 21},
            {"ruble", 15},
            {"pound sterling",29.8},
            {"canadian dollar", 23.3},
            {"australian dollar", 22.2}
        };

        public double GetRate(string currency)
        {
            if(_rates.ContainsKey(currency))
                return _rates[currency];
            else
            {
                throw new Exception("Invalid currency");
            }
        }
    }
}
