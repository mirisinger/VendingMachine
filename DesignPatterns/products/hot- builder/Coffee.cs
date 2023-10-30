using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Coffee : HotDrinkBuilder
    {
        private double price;
        public Coffee() : base()
        {
            this.price = 7;
        }
        public override double GetPrice()
        {
            return price;
        }
        public string PrepareHotCup()
        {
            return "preparing Hot Cup";
        }
        public string AddCoffee()
        {
            return "Adding coffee";
        }

        public string AddSugar(double? spoonsOfSugar)
        {
            return $"Adding {spoonsOfSugar} spoons of Sugar";
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
            result.Add(AddCoffee());
            result.Add(AddSugar(spoonsOfSugar));
            result.Add(WarmUpWaterAndAdd());
            result.Add(AddMilk(milk));

            return result;
        }
    }
}
