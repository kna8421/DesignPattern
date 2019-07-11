using System;

namespace strategy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Market mk;

            mk = new Market(new HKM());
            mk.CreateMarket();

            mk = new Market(new Seven());
            mk.CreateMarket();

            mk = new Market(new Family());
            mk.CreateMarket();
        }
    }
}
