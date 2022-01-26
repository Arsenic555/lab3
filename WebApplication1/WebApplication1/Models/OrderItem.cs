using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public int Ammount { get; set; }
    }
}
