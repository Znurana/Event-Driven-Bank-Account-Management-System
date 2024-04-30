
namespace AccountTransactions
{
    internal class MenuManagement
    {

       
        public static int SelectMenu()
        {
            Console.WriteLine("1.Create account");
            Console.WriteLine("2.Money Depozit");
            Console.WriteLine("3.Money Withdraw");
            Console.WriteLine("4.Show balance");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Select from menu");
            int selectedMenu = int.Parse(Console.ReadLine());
            return selectedMenu;
        }
    }
}
 //Static oldugu ucun class seviyesindedir