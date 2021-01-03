using Skate.Database;
using Skate.Interfaces;
using Skate.Models;

namespace Skate.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly SkateContextDb _db;
        private Order _order;
        public OrderRepository(SkateContextDb db)
        {
            _db = db;
        }

        public Order GetOrder(int id)
        {
            return _db.Orders.Find(id);
        }

        public void MakeOrder(string phoneNumber, string address)
        {
            _order = new Order { PhoneName = phoneNumber, Address = address };
            _db.Orders.Add(_order);
            SaveChanges();
        }

        public void AddProduct(int productId)
        {
            if (_order != null)
            {
                Product product = _db.Products.Find(productId);
                if (product != null)
                {
                    _order.Products.Add(product);
                    SaveChanges();
                }
            }
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
