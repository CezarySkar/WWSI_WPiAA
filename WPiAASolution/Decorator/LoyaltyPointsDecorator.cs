using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class LoyaltyPointsDecorator : PaymentDecorator
    {
        public LoyaltyPointsDecorator(IPayment payment) : base(payment) { }

        public override void Pay(decimal amount)
        {
            base.Pay(amount);
            Console.WriteLine($"Loyalty points added to account: {amount * 100}");
        }
    }
}
