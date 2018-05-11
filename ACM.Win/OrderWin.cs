using ACM.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACM.Win
{
    public partial class OrderWin : Form
    {
        public OrderWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlaceOrder();
        }

        private void PlaceOrder()
        {
            var customer = new Customer();
            // populate the customer instance

            var order = new Order();
            // populate the order instance

            var payment = new Payment();
            // populate the payment instance

            var orderController = new OrderController();
            orderController.PlaceOrder(customer, order, payment, 
                allowSplitOrders: false, 
                emailReceipt: true);
        }

    }
}
