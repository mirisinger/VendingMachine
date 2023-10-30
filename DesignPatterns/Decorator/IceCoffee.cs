using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class IceCoffee : ColdDrinkBuilder
    {
        private double price;

        public IceCoffee() : base()
        {
            this.price = 6;
        }

        public override double GetPrice()
        {
            return price;
        }
        public override List<string> GetResult()
        {
            var result = new List<string>();

            result.Add(PreparePlasticCup());
            result.Add(PrepareStraw());
            result.Add(GetIceCubes());

            return result;
        }

    }
}