using System;
namespace strategy
{
    public abstract class MarketSource
    {
        public MarketSource()
        {
            Console.WriteLine("開店囉！！");
        }

        public abstract void FindMarket();
    }
}
