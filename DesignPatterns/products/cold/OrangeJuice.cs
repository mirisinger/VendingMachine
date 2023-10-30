using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class OrangeJuice : ColdDrinkBuilder
    {
        double price;
        public OrangeJuice() : base()
        {
            this.price = 8;
        }
        public override double GetPrice()
        {
            return price;
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
        public string AddOrangeJuice()
        {
            return "sqeezing Oranges Into The Cup";
        }

        public string AddAOrangeSlice()
        {
            return "Adding An Orange Slice";
        }
        public override List<string> GetResult()
        {
            var result = new List<string>();

            result.Add(PreparePlasticCup());
            result.Add(PrepareStraw());
            result.Add(GetIceCubes());
            result.Add(AddOrangeJuice());
            result.Add(AddAOrangeSlice());

            return result;
        }
    }
}
