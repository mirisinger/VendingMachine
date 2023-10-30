using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Doritos : Snack
    {
        double price;
        public Doritos() : base()
        {
            this.price = 4;
        }
        public string _Doritos()
        {
            return "Doritos";
        }
        public override double GetPrice()
        {
            return price;
        }
    }
}
