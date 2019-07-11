using System;
namespace strategy
{
    public class HKM : MarketSource
    {

        public override void FindMarket()
        {
            Console.WriteLine("香港市集\n\t");
        }
    }

    public class Seven : MarketSource
    {

        public override void FindMarket()
        {
            Console.WriteLine("小七\n\t");
        }
    }

    public class Family : MarketSource
    {

        public override void FindMarket()
        {
            Console.WriteLine("全家\n\t");
        }
    }
}
