using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Product
    {
        public string? Name;
        public double Price;
        public int Quantity;

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

        public void ShowUpdatedData()
        {
            Console.WriteLine($"\nDados atualizados: {Name}," +
           $" $ {Price.ToString("F2", CultureInfo.InvariantCulture)}," +
           $" {Quantity} unidades," +
           $" Total: $ {TotalInStock().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
