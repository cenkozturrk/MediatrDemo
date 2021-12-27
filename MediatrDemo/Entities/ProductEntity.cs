using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatrDemo.Entities
{
    public class ProductEntity
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}
