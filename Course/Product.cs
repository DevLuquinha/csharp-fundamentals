using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Course
{
    internal class Product
    {
        private string? _name;
        private double _price;
        private int _quantity;

        public Product()
        {

        }

        public Product(string name, double price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            if(!string.IsNullOrEmpty(name) && name.Length > 1)
                _name = name;
        }

        public double GetPrice()
        {
            return _price;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public double TotalInStock()
        {
            return _price * _quantity;
        }

        public void AddProduct()
        {
            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            _quantity += int.Parse(Console.ReadLine()!);
        }

        public void RemoveProduct()
        {
            Console.Write("\nDigite o número de produtos a ser removidos do estoque: ");
            _quantity -= int.Parse(Console.ReadLine()!);
        }

        public override string ToString()
        {
            return _name
                + ", $ "
                + _price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantity
                + " unidades, Total: $ "
                + TotalInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
