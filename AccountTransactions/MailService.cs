using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTransactions
{
    internal class MailService
    {
        public void SendMailForCreatingAccount(object source, AccountEventArgs e)
        {
            Console.WriteLine($"MAIL: This account number  {e.Customer.BankAccount.AccountNumber}  has been successfully opened for this customer {e.Customer.Name}   ");
        }
        public void SendMailForDepositMoney(object source, AccountEventArgs e)
        {
            Console.WriteLine($"MAIL: This Money {e.Amount} have been deposited into this account and you have {e.Customer.BankAccount.Balance} money in your account ");
        }
        public void SendMailForWithdrawMoney(object source, AccountEventArgs e)
        {
            Console.WriteLine($"MAIL:  This Money {e.Amount} have been withdraw  this account and you have {e.Customer.BankAccount.Balance}   money in your account ");
        }
        public void SendMailForShowBalance(object source, AccountEventArgs e)
        {
            Console.WriteLine($"MAIL: Your account Balance is : {e.Customer.BankAccount.Balance} ");
        }
    }
}
