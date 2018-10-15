using product_catalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace product_catalog.Providers
{
    public interface IProductProvider
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
