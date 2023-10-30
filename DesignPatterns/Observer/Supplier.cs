using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Supplier:IQuantityObserver
    {
        VendingMachine vendingMachine;
        public Supplier(VendingMachine vendingMachine)
        {
            this.vendingMachine = vendingMachine;
        }
        public void UpdateQuantity(Product product)
        {
            if (vendingMachine.StockList.ContainsKey(product))
            {
                vendingMachine.StockList[product] = 20;
                MessageBox.Show($"Restocking {product.Name}");
            }
        }
    }
}
