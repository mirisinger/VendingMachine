using DesignPatterns.Template_Method;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Product
    {
        public string Name { get; set; }
        public Product()
        {
        }
        public virtual double GetPrice()
        {
            return 0;
        }
    }
}
