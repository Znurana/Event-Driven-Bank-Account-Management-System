using AccountTransactions;
using System.Net;
using System.Net.Mail;

namespace EventTask;
class Program
{
    static void Main(string[] args)
    {

        MailMessage mailMessage = new MailMessage();
        mailMessage.From = new MailAddress("emailfrom"); 
        mailMessage.To.Add("emailTo");
        mailMessage.Subject = "Test Subject";
        mailMessage.Body = "This is test email";

        SmtpClient smtpClient = new SmtpClient();
        smtpClient.Host = "smtp.gmail.com";
        smtpClient.Port = 587; // or 465 for SSL/TLS

        smtpClient.Credentials = new NetworkCredential("youremail@gmail.com", "yourpassword");
        smtpClient.UseDefaultCredentials = false;
        smtpClient.EnableSsl = true;

        try
        {
            smtpClient.Send(mailMessage);
            Console.WriteLine("Email Sent Successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        int selectedMenu = 0;
        do
        {
            selectedMenu = MenuManagement.SelectMenu();
            AccountOperation accountOperation = new AccountOperation();
            SmsService smsService = new SmsService();
            accountOperation.CreateAccountProcessCompleted += smsService.SendSmsForCreatingAccount;
            accountOperation.MoneyDepositProcessCompleted += smsService.SendSmsForDepositMoney;
            accountOperation.MoneyWithdrawProcessCompleted += smsService.SendSmsForWithdrawMoney;
            accountOperation.ShowBalanceProcessCompleted += smsService.SendSmsForShowBalance;
            MailService mailService = new MailService();
            accountOperation.CreateAccountProcessCompleted += mailService.SendMailForCreatingAccount;
            accountOperation.MoneyDepositProcessCompleted += mailService.SendMailForDepositMoney;
            accountOperation.MoneyWithdrawProcessCompleted += mailService.SendMailForWithdrawMoney;
            accountOperation.ShowBalanceProcessCompleted += mailService.SendMailForShowBalance;


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



}
