using AccountTransactions.Interface;

namespace AccountTransactions
{
    internal class SmsService:IMessageService
    {
        public void SendMessageForCreatingAccount(int accountNumber, string customerName)
        {
            Console.WriteLine($"SMS: This account number  {accountNumber}  has been successfully opened for this customer {customerName}   ");
        }
        public void SendMessageForDepositMoney(decimal balance,decimal amount)
        {
            Console.WriteLine($"SMS: This Money {amount} have been deposited into this account and you have {balance} money in your account ");
        }
        public void SendMessageForWithdrawMoney(decimal balance, decimal amount)
        {
            Console.WriteLine($"SMS: This Money {amount} have been withdraw  this account and you have {balance}   money in your account ");
        }
        public void SendMessageForShowBalance(decimal balance, decimal amount)
        {
            Console.WriteLine($"SMS: You balance is :{balance}   ");
        }
    }
}
