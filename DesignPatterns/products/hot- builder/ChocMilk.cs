using DesignPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DesignPatterns
{

    public class ChocMilk : HotDrinkBuilder
    {
        double price;
        public ChocMilk() : base()
        {
            this.price = 6;
        }

        public override double GetPrice()
        {
            return price;
        }
        public string PrepareHotCup()
        {
            return "preparing Hot Cup";
        }
        public string AddCocohPowder()
        {
            return "Adding cocoh powder";
        }
        public string WarmUpWaterAndAdd()
        {
            return "Warming Up the Water, adding hot water";
        }
        public string AddMilk(bool? milk)
        {
            if (milk == true)
            {
                return $"Adding Milk";
            }
            return "";
        }
        public override List<string> GetResult(bool milk = false, double spoonsOfSugar = 0)
        {
            var result = new List<string>();

            result.Add(PrepareHotCup());
            result.Add(AddCocohPowder());
            result.Add(WarmUpWaterAndAdd());
            result.Add(AddMilk(milk));

            return result;
        }
    }
}