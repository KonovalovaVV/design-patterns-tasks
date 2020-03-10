using System;
using System.Collections.Generic;

namespace Proxy
{
    public class YesterdayRate: IYesterdayRate
    {
        private Dictionary<string, double> Rates = new Dictionary<string, double>();

        public double GetRate(string currency)
        {
            if(Rates.ContainsKey(currency))
                return Rates[currency];
            else
            {
                throw new Exception("Invalid currency");
            }
        }

        public YesterdayRate()
        {
            Rates.Add("euro", 26.5);
            Rates.Add("dollar", 21);
            Rates.Add("ruble", 15);
            Rates.Add("pound sterling", 29.8);
            Rates.Add("canadian dollar", 23.3);
            Rates.Add("australian dollar", 22.2);
        }
    }
}
