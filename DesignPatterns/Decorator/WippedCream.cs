using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class WippedCream : IceCoffeeDecorator
    {
        Product product;
        public WippedCream(Product product) : base(product)
        {
            this.product = product;
        }
        public override double GetPrice()
        {
            return product.GetPrice() + 3;
        }
    }
}
