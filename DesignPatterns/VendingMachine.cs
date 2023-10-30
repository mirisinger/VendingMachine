using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Observer;
using DesignPatterns.products;
using DesignPatterns.State;
using DesignPatterns.Template_Method;

namespace DesignPatterns
{
    enum SnackType
    {
        Bisli,
        Bamba
    }
    public class VendingMachine
    {
        public IMachineState currentState;
        private Report daylyReport = new TextReport();
        private Dictionary<Product, double> stockList;
        public Product selectedProduct;
        IQuantityObserver quantityObserver;
        Form1 form;

        public VendingMachine(Form1 form)
        {
            this.form = form;
            currentState = new OrderState(form);
            stockList = new Dictionary<Product, double>();
            CreateDictionary();
        }
        public Dictionary<Product, double> StockList { get; set; }

        public void CreateDictionary()
        {
            stockList.Add(new Snack() { name = "bisli" }, 20);
            stockList.Add(new Snack() { name = "doritos" }, 20);
            stockList.Add(new Snack() { name = "nishnooshim" }, 20);
            stockList.Add(new Snack() { name = "pretzels" }, 20);
            stockList.Add(new Snack() { name = "wafers" }, 20);
            stockList.Add(new HotDrink() { name = "chocMilk" }, 20);
            stockList.Add(new HotDrink() { name = "coffee" }, 20);
            stockList.Add(new HotDrink() { name = "tea" }, 20);
            stockList.Add(new ColdDrink() { name = "coke" }, 20);
            stockList.Add(new ColdDrink() { name = "lemonade" }, 20);
            stockList.Add(new ColdDrink() { name = "orangeJuice" }, 3);
        }
        public void InsertProductToFile(string data)
        {
            daylyReport.InsertToFile(data, form);
        }
        public void SetState(IMachineState state)
        {
            currentState = state;
        }

        public void DecreaseQuantity(Product product)
        {
            if (stockList.ContainsKey(product))
            {
                double currentQuantity = stockList[product];
                stockList[product] = currentQuantity - 1;

                if (currentQuantity < 5)
                {
                    quantityObserver.UpdateQuantity(product);
                }
            }
        }
    }
}
