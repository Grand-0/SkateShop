using System.Collections.Generic;

namespace Skate.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string PhoneName { get; set; }
        public string Address { get; set; }
        public decimal TotalPrice { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
