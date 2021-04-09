using System;
using System.Collections.Generic;
using System.Text;

namespace DietKuy
{
    class User
    {
        private string name;
        private double bodyHeight;
        private double bodyWeight;
        private int orderId;
        private int paymentId;
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public string Name { get; set; }
        public double BodyHeight { get; set; }
        public double BodyWeight { get; set; }

        //composition mengambil orderID dan paymentID untuk user
        Order orderObj = new Order();
        public void ShowUserOrderId()
        {
            OrderId = orderObj.GetOrderId();
            Console.WriteLine(" Order ID: {0}", OrderId);
        }
        Payment paymentObj = new Payment();
        public void ShowUserPaymentId()
        {
            PaymentId = paymentObj.GetPaymentId();
            Console.WriteLine(" Payment ID: {0}", PaymentId);
        }

    }
}