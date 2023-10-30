using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns.State
{
    internal class PayOrderState:IMachineState
    {

   
        //private readonly FoodMachineContext context;
        private Form1 form=new Form1();
        public PayOrderState(Form1 form)
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
            form.Bag.Enabled = false;
            form.GiftWrapper.Enabled = false;
            form.Payment.Enabled = false;
            form.Price.Enabled = false;
            form.Money.Enabled = true;
            form.Money.Visible = true;
            form.Confirm.Enabled = false;
            form.FinishPayment.Enabled = true;
            form.FinishPayment.Visible = true;
            form.Caramel.Enabled = false;
            form.WhiteChocolate.Enabled = false;
            form.WippedCream.Enabled = false;
            form.PayHere.Visible = true;
            form.Process.Visible = false;
        }
        public void Order()
        {
            form.state.Text= "Order  is not allowed in the payment state..";
        }
        public void Pay()
        {
            form.state.Text = "Enter sum of money";
        }

        public void Process()
        {
            form.state.Text = "Process  is not allowed in the payment state..";
        }

    }
    }
