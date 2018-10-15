using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace product_catalog.Models
{
    public class Product
{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DetailedDescription { get; set; }
        public Decimal FullPrice { get; set; }
        public Decimal DiscountedPrice { get; set; }
        public string ImageUrl { get; set; }
    }
}
