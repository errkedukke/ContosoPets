using System;
using System.Collections.Generic;

namespace ContosoPets.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFullFilled { get; set; }
        public int CustoemrId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}