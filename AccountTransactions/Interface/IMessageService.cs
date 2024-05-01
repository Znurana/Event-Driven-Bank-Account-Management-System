using System;
namespace AccountTransactions.Interface
{
	internal  interface IMessageService
	{
        public void SendMessageForCreatingAccount(int accountNumber, string customerName);

        public void SendMessageForDepositMoney(decimal balance, decimal amount);

        public void SendMessageForWithdrawMoney(decimal balance, decimal amount);

        public void SendMessageForShowBalance(decimal balance, decimal amount);
       
    }
}

