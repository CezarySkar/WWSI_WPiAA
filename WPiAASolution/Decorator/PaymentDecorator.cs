using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class PaymentDecorator : IPayment
    {
        private readonly IPayment _basePayment;
        public PaymentDecorator(IPayment basePayment)
        {
            _basePayment = basePayment;
        }
        public virtual void Pay(decimal amount)
        {
            _basePayment.Pay(amount);
        }
    }
}
