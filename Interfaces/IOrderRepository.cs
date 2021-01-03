using Skate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skate.Interfaces
{
    public interface IOrderRepository
    {
        void MakeOrder(string PhoneNumber, string Address);
        void AddProduct(int id);
        void SaveChanges();
    }
}
