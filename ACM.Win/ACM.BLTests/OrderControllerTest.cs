using System;
using ACM.BL;
using Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class OrderControllerTest
    {
        [TestMethod]
        public void PlaceOrderTest()
        {
            //-- Arrange
            var orderController = new OrderController();
            var customer = new Customer() { EmaiAddress = "flpsno@hotmail.com" };
            var order = new Order();
            var payment = new Payment() { PaymentType = 1 };

            //-- Act
            OperationResult op = orderController.PlaceOrder(customer, order, payment, allowSplitOrders: true, emailReceipt: true);

            //-- Assert
            Assert.AreEqual(true, op.Success);
            Assert.AreEqual(0, op.MessageList.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PlaceOrderTestNullCustomer()
        {
            //-- Arrange
            var orderController = new OrderController();
            Customer customer = null;
            var order = new Order();
            var payment = new Payment() { PaymentType = 1 };

            //-- Act
            OperationResult op = orderController.PlaceOrder(customer, order, payment, allowSplitOrders: true, emailReceipt: true);

            //-- Assert
        }

        [TestMethod]
        public void PlaceOrderTestInvalidEmail()
        {
            //-- Arrange
            var orderController = new OrderController();
            var customer = new Customer() { EmaiAddress = "" };
            var order = new Order();
            var payment = new Payment() { PaymentType = 1 };

            //-- Act
            OperationResult op = orderController.PlaceOrder(customer, order, payment, allowSplitOrders: true, emailReceipt: true);

            //-- Assert
            Assert.AreEqual(true, op.Success);
            Assert.AreEqual(1, op.MessageList.Count);
            Assert.AreEqual("Email address is null", op.MessageList[0]);
        }
    }
}
