using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Shop
    {
        public void Pay(string method, decimal amount)
        {
            IPayment payment = method.ToLower() switch
            {
                "card" => new CardPayment(),
                "cash" => new CashPayment(),
                "transfer" => new TransferPayment(),
                _ => throw new ArgumentException("Invalid payment method.")
            };

            if (method == "card")
            {
                payment = new RedirectToHomeDecorator(payment);
                payment = new SmsNotificationDecorator(payment);
                payment = new LoyaltyPointsDecorator(payment);
            }

            payment.Pay(amount);
        }
    }
}
