using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class PaymentFactory
    {
        public abstract IPaymentProcessor Create();

        public void Process(Order order) { var p = Create(); p.Pay(order); }
    }
}
