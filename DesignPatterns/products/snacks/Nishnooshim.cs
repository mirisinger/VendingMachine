using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Nishnooshim : Snack
    {
        double price;
        public Nishnooshim() : base()
        {
            this.price = 8;
        }
        public string _Nishnooshim()
        {
            return "Nishnooshim";
        }
        public override double GetPrice()
        {
            return price;
        }
    }
}

