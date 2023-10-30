using DesignPatterns.products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    //Builder
    public abstract class HotDrinkBuilder : HotDrink

    {
        public HotDrinkBuilder() : base()
        {
        }

        public string PrepareHotCup()
        {
            return "preparing Hot Cup";
        }
        public string AddSugar(int spoonsOfSugar)
        {
            return $"Adding {spoonsOfSugar} spoons of Sugar";
        }
        public string WarmUpWaterAndAdd()
        {
            return "Warming Up the Water, adding hot water";
        }
        public string AddMilk(bool? milk)
        {
            return $"Adding Milk: {milk}";

        }
        public string AddCocohPowder()
        {
            return "Adding cocoh powder";
        }
        public string AddCoffee()
        {
            return "Adding coffee";
        }
        public string AddTheTeaBag()
        {
            return "Adding Tea Essance";
        }
        public abstract List<string> GetResult(bool milk = false, double spoonsOfSugar = 0);
    }
}
