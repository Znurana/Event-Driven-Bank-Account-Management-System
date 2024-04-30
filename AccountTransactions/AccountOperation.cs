using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTransactions
{
    internal class AccountOperation
    {
        public event EventHandler<AccountEventArgs> CreateAccountProcessCompleted;
        public event EventHandler<AccountEventArgs> MoneyDepositProcessCompleted;
        public event EventHandler<AccountEventArgs> MoneyWithdrawProcessCompleted;
        public event EventHandler<AccountEventArgs> ShowBalanceProcessCompleted;

        public void CreateBankAccount(Customer customer)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.AccountNumber = new Random().Next(1, 100);
            bankAccount.Balance = 0;
            customer.BankAccount = bankAccount;
            OnAccountCreateProcessCompleted(customer);
        }

        public void MakeDeposit(Customer customer, decimal amount)
        {
            customer.BankAccount.Balance += amount;
            OnDepositMoneyCompleted(customer, amount);
        }
        public void MakeWithDraw(Customer customer, decimal amount)
        {
            if (customer.BankAccount.Balance >= amount)
            {
                customer.BankAccount.Balance -= amount;
                OnWithdrawMoneyCompleted(customer, amount);
            }

        }
        public void ShowBalance(Customer customer)
        {
            OnShowBalanceCompleted(customer);

        }

        protected virtual void OnAccountCreateProcessCompleted(Customer customer)
        {
            CreateAccountProcessCompleted?.Invoke(this, new AccountEventArgs { Customer = customer });
        }
        protected virtual void OnDepositMoneyCompleted(Customer customer, decimal amount)
        {
            MoneyDepositProcessCompleted?.Invoke(this, new AccountEventArgs { Customer = customer, Amount = amount });
        }
        protected virtual void OnWithdrawMoneyCompleted(Customer customer, decimal amount)
        {
            MoneyWithdrawProcessCompleted?.Invoke(this, new AccountEventArgs { Customer = customer, Amount = amount });
        }
        protected virtual void OnShowBalanceCompleted(Customer customer)
        {
            ShowBalanceProcessCompleted?.Invoke(this, new AccountEventArgs { Customer = customer });
        }

    }
}
