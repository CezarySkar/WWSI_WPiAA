using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class SmsNotificationDecorator : PaymentDecorator
    {
        public SmsNotificationDecorator(IPayment payment) : base(payment) { }

        public override void Pay(decimal amount)
        {
            base.Pay(amount);
            Console.WriteLine($"SMS Notification: Payment of {amount:C} has been made successfully.");
        }
    }
}
