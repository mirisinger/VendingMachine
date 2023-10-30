using DesignPatterns;
using DesignPatterns.Decorator;
using DesignPatterns.Decorator.WrappingDecorator;
using DesignPatterns.products;
using DesignPatterns.State;
using DesignPatterns.Template_Method;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using DesignPatterns.products.snacks;

namespace DesignPatterns
{
    public partial class Form1 : Form
    {
        private VendingMachine vendingMachine;
        internal object giftWrapper;
        public Product product;
        Product oldProduct;
        public Form1()
        {
            InitializeComponent();
            vendingMachine = new VendingMachine(this);
            oldProduct = product;
        }

        //hot drinks
        public void ChocMilk_CheckedChanged(object sender, EventArgs e)
        {
            ChocMilk choc = new ChocMilk();
            this.Price.Text = choc.GetPrice().ToString();
            product = choc;
        }

        public void Coffee_CheckedChanged(object sender, EventArgs e)
        {
            Coffee coffee = new Coffee();
            this.Price.Text = coffee.GetPrice().ToString();
            product = coffee;
        }


        private void Tea_CheckedChanged_2(object sender, EventArgs e)
        {
            Tea tea = new Tea();
            this.Price.Text = tea.GetPrice().ToString();
            product = tea;
        }

        //cold drinks
        private void IceCoffee_CheckedChanged(object sender, EventArgs e)
        {
            IceCoffee iceCoffee = new IceCoffee();
            this.Price.Text = iceCoffee.GetPrice().ToString();
            product = iceCoffee;
            UpdatePrice();
        }

        private void WippedCream_CheckedChanged(object sender, EventArgs e)
        {
            if (WippedCream.Checked)
            {
                product = new WippedCream(product);
            }
            else
            {
                product = ((IceCoffeeDecorator)product).RemoveDecorator(typeof(WippedCream));
            }
            UpdatePrice();
        }

        private void WhiteChocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (WhiteChocolate.Checked)
            {
                product = new WhiteChocolate(product);
            }
            else
            {
                product = ((IceCoffeeDecorator)product).RemoveDecorator(typeof(WhiteChocolate));
            }
            UpdatePrice();
        }

        private void Caramel_CheckedChanged(object sender, EventArgs e)
        {
            if (Caramel.Checked)
            {
                product = new Caramel(product);

            }
            else
            {
                product = ((IceCoffeeDecorator)product).RemoveDecorator(typeof(Caramel));
            }
            UpdatePrice();

        }

        private void UpdatePrice()
        {
            double price = (product).GetPrice();
            this.Price.Text = price.ToString();
        }

        private void OrangeJuice_CheckedChanged(object sender, EventArgs e)
        {
            OrangeJuice orangeJuice = new OrangeJuice();
            this.Price.Text = orangeJuice.GetPrice().ToString();
            product = orangeJuice;
        }

        private void Lemonade_CheckedChanged(object sender, EventArgs e)
        {
            Lemonade lemonade = new Lemonade();
            this.Price.Text = lemonade.GetPrice().ToString();
            product = lemonade;
        }

        private void CokaCola_CheckedChanged(object sender, EventArgs e)
        {
            Coke coke = new Coke();
            this.Price.Text = coke.GetPrice().ToString();
            product = coke;
        }

        //snacks

        private void Bisli_CheckedChanged(object sender, EventArgs e)
        {
            Product bisli = new Bisli();
            this.Price.Text = bisli.GetPrice().ToString();
            product = bisli;
        }

        private void Doritos_CheckedChanged(object sender, EventArgs e)
        {
            Doritos doritos = new Doritos();
            this.Price.Text = doritos.GetPrice().ToString();
            product = doritos;
        }

        private void Wafers_CheckedChanged(object sender, EventArgs e)
        {
            Product wafers = new Wafers();
            this.Price.Text = wafers.GetPrice().ToString();
            product = wafers;
        }

        private void Pretzels_CheckedChanged(object sender, EventArgs e)
        {
            Product pretzels = new Pretzels();
            this.Price.Text = pretzels.GetPrice().ToString();
            product = pretzels;
        }

        private void Nashnashim_CheckedChanged(object sender, EventArgs e)
        {
            Nishnooshim nashnashim = new Nishnooshim();
            this.Price.Text = nashnashim.GetPrice().ToString();
            product = nashnashim;
        }
        private void Payment_Click(object sender, EventArgs e)
        {
            oldProduct = product;
            if (Bag.Checked) { product = new BagDecorator(product); }
            else if (GiftWrapper.Checked) { product = new GiftWrapperDecorator(product); }
            UpdatePrice();
            vendingMachine.selectedProduct = oldProduct;
            vendingMachine.SetState(new PayOrderState(this));
        }


        private void Confirm_Click(object sender, EventArgs e)
        {
            vendingMachine.SetState(new ProcessOrderState(this));
        }


        private void Money_TextChanged(object sender, EventArgs e)
        {
            GetChange();
        }
        public async void GetChange()
        {
            double money = 0;
            money = double.Parse(Money.Text);
            double price = double.Parse(Price.Text);

            if (money >= price)
            {
                Change.Text = (money - price).ToString();
            }
            else
            {
                Change.Text = "Not enough money entered. Please try again.";
            }
        }
        public double spoonsOfSugar;
        private async void FinishPayment_Click(object sender, EventArgs e)
        {
            if (Change.Text != "Not enough money entered. Please try again." && Change.Text != "Change")
            {
                vendingMachine.DecreaseQuantity(vendingMachine.selectedProduct);

                string data = oldProduct.GetType().ToString();
                data = data.Substring(data.LastIndexOf('.') + 1);

                vendingMachine.InsertProductToFile($"{data} was bought");

                DrinkProcess();
            }
        }
        public void DrinkProcess()
        {
            if (vendingMachine.selectedProduct is HotDrinkBuilder)
            {
                bool milk = Milk.Checked;
                if (sugar.SelectedItem != null)
                {
                    double.TryParse(sugar.SelectedItem.ToString(), out spoonsOfSugar);
                }
                HotDrinkBuilder hotDrink = (HotDrinkBuilder)vendingMachine.selectedProduct;
                if (hotDrink != null)
                {
                    var results = hotDrink.GetResult(milk, spoonsOfSugar);
                    WriteToProcess(results);
                }
            }
            else if (vendingMachine.selectedProduct is ColdDrink)
            {
                bool caramel = Caramel.Checked;
                bool whiteChocolate = WhiteChocolate.Checked;
                bool wippedCream = WippedCream.Checked;
                ColdDrinkBuilder coldDrink = (ColdDrinkBuilder)vendingMachine.selectedProduct;
                if (coldDrink != null)
                {
                    var results = coldDrink.GetResult();
                    WriteToProcess(results);
                }
            }
            else
            {
                MessageBox.Show("Successful Payment. Have An Amaizing Day!");
            }
        }
        public async void WriteToProcess(List<string> results)
        {
            Process.Visible = true;
            var builder = new StringBuilder();
            foreach (var result in results)
            {
                builder.AppendLine(result);
                Process.Text = builder.ToString();
                await Task.Delay(1000);
            }
            MessageBox.Show("Successful Payment. Have An Amaizing Day!!");
        }
    }
}