namespace AccountTransactions
{
    internal class SmsService
    {
        public void SendSmsForCreatingAccount(object source, AccountEventArgs e)
        {
            Console.WriteLine($"SMS: This account number  {e.Customer.BankAccount.AccountNumber}  has been successfully opened for this customer {e.Customer.Name}   ");
        }
        public void SendSmsForDepositMoney(object source, AccountEventArgs e)
        {
            Console.WriteLine($"SMS: This Money {e.Amount} have been deposited into this account and you have {e.Customer.BankAccount.Balance} money in your account ");
        }
        public void SendSmsForWithdrawMoney(object source, AccountEventArgs e)
        {
            Console.WriteLine($"SMS: This Money {e.Amount} have been withdraw  this account and you have {e.Customer.BankAccount.Balance}   money in your account ");
        }
        public void SendSmsForShowBalance(object source, AccountEventArgs e)
        {
            Console.WriteLine($"SMS: You balance is :{e.Customer.BankAccount.Balance}   ");
        }
    }
}
