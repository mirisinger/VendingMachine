using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class WhiteChocolate : IceCoffeeDecorator
    {
        Product product;
        public WhiteChocolate(Product product) : base(product)
        {
            this.product = product;
        }
        public override double GetPrice()
        {
            return product.GetPrice() + 2;
        }
    }
}
