using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Entities
{
    public class Product:BaseEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal SalePrice { get; set; }
        public decimal CostPrice { get; set; }

        public Category Category { get; set; }
    }
}
