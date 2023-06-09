using ExceptionsAccount.Entities;
using ExceptionsAccount.Entities.Exceptions;
using System.Globalization;

namespace ExceptionsAccount
{
    class Program
    {
        static void Main(string[] args)
        {
           
                CultureInfo CI = CultureInfo.InvariantCulture;

                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CI);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CI);

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CI);
            try
            {
                account.Witchdraw(withdraw);
                Console.Write($"New balance: {account.Balance.ToString("F2", CI)}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }          
        }
    }
}