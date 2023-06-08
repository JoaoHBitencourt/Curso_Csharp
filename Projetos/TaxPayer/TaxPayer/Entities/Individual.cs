namespace TaxPayer.Entities
{
    class Individual : TaxPayers
    {
        public double HearthExpenditures { get; set; }

        public Individual(double hearthExpenditures, string name, double anualIncome) : base(name, anualIncome)
        {
            HearthExpenditures = hearthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.00)
            {
                return AnualIncome * 0.15 - HearthExpenditures * 0.50;
            }
            else
            {
                return AnualIncome * 0.25 - HearthExpenditures * 0.50;
            }
        }
    }
}
