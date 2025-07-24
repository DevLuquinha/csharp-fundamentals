using System.Globalization;
using System.Xml.Linq;

namespace Course
{
    internal class Product
    {
        private string? _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length > 1)
                    _name = value;
            }
        }

        public double Price { get; private set; }

        public int Quantity { get; private set; }


        public Product()
        {

        }

        public Product(string name, double price, int quantity)
        {
            _name = name;
            Price = price;
            Quantity = quantity;
        }

        public double TotalInStock()
        {
            return Price * Quantity;
        }

        public void AddProduct()
        {
            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            Quantity += int.Parse(Console.ReadLine()!);
        }

        public void RemoveProduct()
        {
            Console.Write("\nDigite o número de produtos a ser removidos do estoque: ");
            Quantity -= int.Parse(Console.ReadLine()!);
        }

        public override string ToString()
        {
            return _name
                + ", $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantity
                + " unidades, Total: $ "
                + TotalInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
