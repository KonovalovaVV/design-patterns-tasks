namespace Proxy
{
    public class YesterdayRate: IYesterdayRate
    {
        public Rate GetRate()
        {
            //connecting to some external resource...
            return new Rate();
        }
    }
}
