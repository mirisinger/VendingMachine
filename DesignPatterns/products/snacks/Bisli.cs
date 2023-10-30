using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Bisli : Snack
    {
        string name;
        public int price;
        public Bisli() : base()
        {
            this.price = 5;
        }

        public string _bisli()
        {
            return "bisli";
        }
        public override double GetPrice()
        {
            return price;
        }
    }
}
