using System;

namespace strategy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Market mk;

            Console.WriteLine("輸入市場名稱：HKM,711,family");
            var marketName = Console.ReadLine();

            //工廠模式結合策略模式
            mk = new Market(MarketFactory.CreateMarket("marketName"));

            mk = new Market(new HKM());
            mk.CreateMarket();

            mk = new Market(new Seven());
            mk.CreateMarket();

            mk = new Market(new Family());
            mk.CreateMarket();
        }
    }
}
