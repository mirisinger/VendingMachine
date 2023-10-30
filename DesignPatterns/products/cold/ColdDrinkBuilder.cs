using DesignPatterns.products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class ColdDrinkBuilder : ColdDrink
    {
        public ColdDrinkBuilder() : base()
        {
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
        public abstract List<string> GetResult();
    }
}
