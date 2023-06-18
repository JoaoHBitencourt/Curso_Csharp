using System.Globalization;

namespace Linq2_Csharp.Entities
{
    class Product
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Price.ToString("F2", CI)}, {Category.Name}, {Category.Tier}";
        }
    }
}