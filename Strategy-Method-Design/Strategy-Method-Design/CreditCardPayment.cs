using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Method_Design
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void ProcessPayment(float amount)
        {
            Console.WriteLine($"Processing Credit Card payment of {amount} dollars.");
            // Additional Credit Card-specific logic
        }
    }
}
