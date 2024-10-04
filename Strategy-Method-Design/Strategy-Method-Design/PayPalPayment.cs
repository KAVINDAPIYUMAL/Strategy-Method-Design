﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Method_Design
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void ProcessPayment(float amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount} dollars.");
            // Additional PayPal-specific logic
        }
    }
}
