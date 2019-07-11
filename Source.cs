using System;
namespace strategy
{
    public class HKM : MarketSource
    {

        public override void findMarket()
        {
            Console.WriteLine("香港市集");
        }
    }

    public class Seven : MarketSource
    {

        public override void findMarket()
        {
            Console.WriteLine("小七");
        }
    }

    public class Family : MarketSource
    {

        public override void findMarket()
        {
            Console.WriteLine("全家");
        }
    }
}
