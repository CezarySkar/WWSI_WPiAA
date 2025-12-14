using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class RedirectToHomeDecorator : PaymentDecorator
    {
        public RedirectToHomeDecorator(IPayment payment) : base(payment) { }
        public override void Pay(decimal amount)
        {
            Console.WriteLine("Redirecting to home page...");
            base.Pay(amount);
        }
    }
}
