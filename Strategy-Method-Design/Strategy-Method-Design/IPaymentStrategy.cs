using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Method_Design
{
    public interface IPaymentStrategy
    {
        void ProcessPayment(float amount);
    }
}
