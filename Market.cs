using System;
namespace strategy
{
    public class Market
    {
        MarketSource _marketSource;

        public Market(MarketSource strategy)
        {
            _marketSource = strategy;
        }

        public void CreateMarket()
        {
            _marketSource.FindMarket();
        }
    }
}
