using AccountTransactions;
using AccountTransactions.Interface;

namespace EventTask;
class Program
{
     
    static void Main(string[] args)
    {
        int selectedMenu = 0;
        do
        {
            selectedMenu = MenuManagement.SelectMenu();
            AccountOperation accountOperation = new AccountOperation();
            accountOperation.CreateAccountProcessCompleted += C_CreateAccountProcessCompleted;
            accountOperation.MoneyDepositProcessCompleted += C_MoneyDepositProcessCompleted;
            accountOperation.MoneyWithdrawProcessCompleted += C_MoneyWithdrawProcessCompleted;
            accountOperation.ShowBalanceProcessCompleted += C_ShowBalanceProcessCompleted;

            switch (selectedMenu)
            {
                case 1:
                    var customer = DataManagement.GetCustomer();
                    accountOperation.CreateBankAccount(customer);
                    break;
                case 2:
                    var customer2 = DataManagement.GetCustomer();
                    Console.WriteLine("Enter deposit money : ");
                    decimal amount = decimal.Parse(Console.ReadLine());
                    accountOperation.MakeDeposit(customer2, amount);
                    break;
                case 3:
                    var customer3 = DataManagement.GetCustomer();
                    Console.WriteLine("Enter withdraw money : ");
                    amount = decimal.Parse(Console.ReadLine());
                    accountOperation.MakeWithDraw(customer3, amount);
                    break;
                case 4:
                    var customer4 = DataManagement.GetCustomer();
                    accountOperation.ShowBalance(customer4);
                    break;
                case 5:
                    Console.WriteLine("You are exiting the program....");

                    break;
                default:
                    Console.WriteLine("Please correct right option!");
                    break;

            }
        } while (selectedMenu != 5);
    }

    private static void C_ShowBalanceProcessCompleted(object? sender, AccountEventArgs e)
    {
        IMessageService service = new SmsService();
        service.SendMessageForShowBalance(e.Customer.BankAccount.Balance, e.Amount);
        service = new MailService();
        service.SendMessageForShowBalance(e.Customer.BankAccount.Balance, e.Amount);
        service = new TelegramService();
        service.SendMessageForShowBalance(e.Customer.BankAccount.Balance, e.Amount);

    }
 
    private static void C_MoneyWithdrawProcessCompleted(object? sender, AccountEventArgs e)
    {
        IMessageService service = new SmsService();
        service.SendMessageForWithdrawMoney(e.Customer.BankAccount.Balance, e.Amount);
        service = new MailService();
        service.SendMessageForWithdrawMoney(e.Customer.BankAccount.Balance, e.Amount);
        service = new TelegramService();
        service.SendMessageForWithdrawMoney(e.Customer.BankAccount.Balance, e.Amount);
    }


    private static void C_MoneyDepositProcessCompleted(object? sender, AccountEventArgs e)
    {
        IMessageService service = new SmsService();
        service.SendMessageForDepositMoney(e.Customer.BankAccount.Balance, e.Amount);
        service = new MailService();
        service.SendMessageForDepositMoney(e.Customer.BankAccount.Balance, e.Amount);
        service = new TelegramService();
        service.SendMessageForDepositMoney(e.Customer.BankAccount.Balance, e.Amount);
    }


    private static void C_CreateAccountProcessCompleted(object? sender, AccountEventArgs e)
    {
        IMessageService service = new SmsService();
        service.SendMessageForCreatingAccount(e.Customer.BankAccount.AccountNumber, e.Customer.Name);
        service = new MailService();
        service.SendMessageForCreatingAccount(e.Customer.BankAccount.AccountNumber, e.Customer.Name);
        service = new TelegramService();
        service.SendMessageForCreatingAccount(e.Customer.BankAccount.AccountNumber, e.Customer.Name);


    }

}
