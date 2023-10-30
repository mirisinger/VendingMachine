using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns.State
{
    internal class OrderState : IMachineState
    {
        private Form1 form;
        public OrderState(Form1 form)
        {
            form.ChocMilk.Enabled = true;
            form.Coffee.Enabled = true;
            form.IceCoffee.Enabled = true;
            form.OrangeJuice.Enabled = true;
            form.Lemonade.Enabled = true;
            form.CokaCola.Enabled = true;
            form.Bisli.Enabled = true;
            form.Doritos.Enabled = true;
            form.Wafers.Enabled = true;
            form.Pretzels.Enabled = true;
            form.Nashnashim.Enabled = true;
          
            form.Bag.Visible = false;
            form.GiftWrapper.Visible = false;
            form.Milk.Visible = false;
            form.sugar.Visible = false;
            form.Payment.Visible = false;
            form.Price.Visible = true;
            form.Money.Visible = false;
            form.Confirm.Enabled = true;
            form.FinishPayment.Visible = false;
            form.Caramel.Visible = false;
            form.WhiteChocolate.Visible = false;
            form.WippedCream.Visible = false;
            form.state.Visible=false;
            form.IceCoffeeToppings.Visible = false;
            form.HotDrinkLable.Visible = false;
            form.PayHere.Visible = false;
            form.ProductPrice.Visible = true;
            form.Process.Visible = false;
        }

        public void Order()
        {
            form.state.Text= "Start your order.";
        }
        public void Pay()
        {
            form.state.Text = "Payment is not allowed in the order state.";
        }
        public void Process()
        {
            form.state.Text = "Process is not allowed in the order state.";
        }
    }
    }
