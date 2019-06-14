using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCexample.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; private set; }

        public ProductListViewModel(List<Product> products)
        {
            Products = products;
        }
    }
}
