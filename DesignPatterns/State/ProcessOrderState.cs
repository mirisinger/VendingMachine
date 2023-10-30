using DesignPatterns.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    internal class ProcessOrderState : IMachineState
    {
        private Form1 form;
        public ProcessOrderState(Form1 form)
        {
            form.Coffee.Enabled = false;
            form.ChocMilk.Enabled = false;
            form.Tea.Enabled = false;
            form.IceCoffee.Enabled = false;
            form.OrangeJuice.Enabled = false;
            form.Lemonade.Enabled = false;
            form.CokaCola.Enabled = false;
            form.Doritos.Enabled = false;
            form.Bisli.Enabled = false;
            form.Wafers.Enabled = false;
            form.Pretzels.Enabled = false;
            form.Nashnashim.Enabled = false;
            form.Milk.Enabled = false;
            form.sugar.Enabled = false;
            form.Bag.Visible = true;
            form.GiftWrapper.Visible = true;
            form.Payment.Visible = true;
            form.Price.Enabled = false;
            form.Money.Enabled = false;
            form.Confirm.Enabled = false;
            form.FinishPayment.Enabled = false;
            form.Caramel.Enabled = false;
            form.WhiteChocolate.Enabled = false;
            form.WippedCream.Enabled = false;
            form.Process.Visible = false;

            if (form.product is IceCoffee)
            {
                form.IceCoffeeToppings.Visible = true;
                form.Caramel.Visible = true;
                form.WhiteChocolate.Visible = true;
                form.WippedCream.Visible = true;
                form.Caramel.Enabled = true;
                form.WhiteChocolate.Enabled = true;
                form.WippedCream.Enabled = true;
            }
            if (form.product is HotDrinkBuilder)
            {
                form.HotDrinkLable.Visible = true;
                form.Milk.Visible = true;
                form.sugar.Visible = true;
                form.Milk.Enabled = true;
                form.sugar.Enabled = true;
            }
        }
        public void Order()
        {
            form.state.Text = "Order is not allowed in the process state.";
        }
        public void Pay()
        {
            form.state.Text = "Payment is not allowed in the process state.";
        }
        public void Process()
        {
            form.state.Text = "Processing.";
        }

    }
}
