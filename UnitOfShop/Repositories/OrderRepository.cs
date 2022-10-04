using UnitOfShop.Data;
using UnitOfShop.Models;

namespace UnitOfShop.Repositories
{
    public interface IOrderRepository
    {
        void Save(Order order);
    }

    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;
        }
        public void Save(Order order)
        {
            _context.Orders.Add(order);             
        }
    }
}