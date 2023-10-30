using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.products;

namespace DesignPatterns
{
    public abstract class IceCoffeeDecorator : IceCoffee
    {
        protected IceCoffee iceCoffee;
        Product product;
        protected IceCoffeeDecorator(Product product) : base()
        {
            this.product = product;
            this.iceCoffee = iceCoffee;
        }
        public IceCoffeeDecorator RemoveDecorator(Type decoratorType)
        {
            if (decoratorType.IsInstanceOfType(this))
            {
                return (IceCoffeeDecorator)this.product;
            }
            else
            {
                return this;
            }
        }
    }
}
