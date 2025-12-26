using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order.ToString());
        }
    }
}