using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.WrappingDecorator
{
    public class BagDecorator : ProductDecorator
    {
        private double price;
        public BagDecorator(Product product) : base(product)
        {
            this.Name = product.Name;
            price = 0.1;
        }
        public override double GetPrice()
        {
            return product.GetPrice() + price;
        }
        public override string Wrapper()
        {
            return "this is wrapped with a bag.";
        }
        public void GetResult()
        {

        }
    }
}
