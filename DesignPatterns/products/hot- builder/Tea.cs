using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Tea : HotDrinkBuilder
    {
        double price;
        public Tea() : base()
        {
            this.price = 4;
        }
        public override double GetPrice()
        {
            return price;
        }
        public string PrepareHotCup()
        {
            return "preparing Hot Cup";
        }
        public string AddTheTeaBag()
        {
            return "Adding Tea Essance";
        }

        public string AddSugar(double? spoonsOfSugar)
        {
            return $"Adding {spoonsOfSugar} spoons of Sugar";
        }
        public string WarmUpWaterAndAdd()
        {
            return "Warming Up the Water, adding hot water";
        }

        public override List<string> GetResult(bool milk = false, double spoonsOfSugar = 0)
        {
            var result = new List<string>();

            result.Add(PrepareHotCup());
            result.Add(AddTheTeaBag());
            result.Add(AddSugar(spoonsOfSugar));
            result.Add(WarmUpWaterAndAdd());

            return result;
        }
    }
}

