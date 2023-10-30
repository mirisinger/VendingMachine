using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Coke : ColdDrinkBuilder
    {
        double price;
        public Coke() : base()
        {
            this.price = 6;
        }
        public string PreparePlasticCup()
        {
            return "Preparing Cup";
        }
        public string PrepareStraw()
        {
            return "Puting Straw In Cup";
        }
        public string GetIceCubes()
        {
            return "Adding Ice Cubes";
        }
        public override List<string> GetResult()
        {
            var result = new List<string>();

            result.Add(PreparePlasticCup());
            result.Add(PrepareStraw());
            result.Add(GetIceCubes());

            return result;
        }
        public override double GetPrice()
        {
            return price;
        }
    }
}
