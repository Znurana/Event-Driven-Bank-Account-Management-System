using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTransactions
{
    internal class AccountEventArgs :EventArgs
    {
        public Customer Customer { get; set; }
        public decimal Amount { get; set; }
    }
}
