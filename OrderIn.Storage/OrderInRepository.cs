using OrderIn.Domain.Models;

namespace OrderIn.Storage
{
    public class OrderInRepository
    {
        private OrderInContext _db;
        public OrderInRepository(OrderInContext context)
        {
            _db = context;
        }

        public void SaveOrder(Order order)
        {
            _db.Orders.Add(order);
            _db.SaveChanges();
        }
    }
}