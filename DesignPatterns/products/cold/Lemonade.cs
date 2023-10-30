using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Lemonade : ColdDrinkBuilder
    {
        double price;
        public Lemonade() : base()
        {
            this.price = 7;
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
        public string AddLemonJuice()
        {
            return "Pouring Lemon Juice";
        }
        public string AddSugar()
        {
            return "Adding Sugar";
        }
        public string AddALemonSlice()
        {
            return "Adding A Lemon Slice";
        }
        public override List<string> GetResult()
        {
            var result = new List<string>();

            result.Add(PreparePlasticCup());
            result.Add(PrepareStraw());
            result.Add(GetIceCubes());
            result.Add(AddLemonJuice());
            result.Add(AddSugar());
            result.Add(AddALemonSlice());

            return result;
        }
    }
}
