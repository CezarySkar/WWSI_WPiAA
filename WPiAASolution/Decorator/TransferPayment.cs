using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class TransferPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"{amount} bank transfer payment.");
        }
    }
}
