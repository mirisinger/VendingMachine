using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Wafers : Snack
    {
        double price;
        public Wafers() : base()
        {
            this.price = 9;
        }
        public string _Wafers()
        {
            return "Wafers";
        }
        public override double GetPrice()
        {
            return price;
        }
    }
}
