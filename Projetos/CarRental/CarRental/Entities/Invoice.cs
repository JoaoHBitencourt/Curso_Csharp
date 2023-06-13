using System.Globalization;

namespace CarRental_Csharp.Entities
{
     class Invoice
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return $"Basic Payment: {BasicPayment.ToString("F2", CI)}" +
                $"\nTax: {Tax.ToString("F2", CI)}" +
                $"\nTotalPayment: {TotalPayment.ToString("F2", CI)}";
        }
    }
}
