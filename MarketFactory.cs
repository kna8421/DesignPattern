using System;
namespace strategy
{
    public static class MarketFactory
    {

        public static MarketSource CreateMarket(string name)
        {
            Console.WriteLine("老闆開了一家:");

            MarketSource result;
            switch(name)
            {
                case "HKM":
                    result = new HKM();
                    break;
                case "711":
                    result = new Seven();
                    break;
                case "family":
                    result = new Family();
                    break;
                default:
                    result = new Family();
                    break;
            }
            return result;
        }
    }
}
