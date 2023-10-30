using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.WrappingDecorator
{
    public abstract class ProductDecorator : Product
    {
        protected Product product;
        public ProductDecorator(Product product)
        {
            this.product = product;
        }
        public override double GetPrice()
        {
            return base.GetPrice();
        }
        public abstract string Wrapper();
    }
}
