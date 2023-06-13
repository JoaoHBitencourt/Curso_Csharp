using System.Globalization;

namespace ContractProcessing.Entities
{
     class Installment
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{DueDate.ToString("dd/MM/yyyy")} - {Amount.ToString("F2", CI)}";
        }
    }
}
