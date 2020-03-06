namespace Proxy
{
    public class ProxyYesterdayRate: IYesterdayRate
    {
        private YesterdayRate yesterdayRate;
        public Rate GetRate()
        {
            if (this.CheckAccess())
            {
                yesterdayRate = new YesterdayRate();
                yesterdayRate.GetRate();

                LogAccess();
            }
            return new Rate();
        }

        public ProxyYesterdayRate(YesterdayRate yesterdayRate)
        {
            this.yesterdayRate = yesterdayRate;
        }

        public bool CheckAccess()
        {
            //Proxy: Checking access prior to firing a real request
            return true;
        }

        public void LogAccess()
        {
            // Proxy: Logging the time of request
        }
    }
}
