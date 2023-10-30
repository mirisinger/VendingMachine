using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Pretzels : Snack
    {
        double price;
        public Pretzels() : base()
        {
            this.price = 10;
        }
        public string _Pretzels()
        {
            return "Pretzels";
        }
        public override double GetPrice()
        {
            return price;
        }
    }
}
