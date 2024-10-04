using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Method_Design
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentContext paymentContext = new PaymentContext(new PayPalPayment());

            paymentContext.ProcessPayment(100.0f);

            // Switching the payment method at runtime
            paymentContext.SetPaymentStrategy(new BitcoinPayment());
            paymentContext.ProcessPayment(50.0f);
        }
    }
}
