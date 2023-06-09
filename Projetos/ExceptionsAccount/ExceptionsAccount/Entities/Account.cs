using ExceptionsAccount.Entities.Exceptions;
namespace ExceptionsAccount.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WitchdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double witchdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WitchdrawLimit = witchdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Witchdraw(double amount)
        {
            if (amount > WitchdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }

            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }          

            Balance -= amount;
        }
    }
}
