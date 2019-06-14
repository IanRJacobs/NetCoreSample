using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Infrastructure
{
    //Dependency injection -- dependent on a IProductRepository
    //That means ProductRepository can be switched out for ProductRepository2 with no issues
    public class ProductRepositoryTransient : IProductRepositoryTransient
    {
        //service that can be exchanged for Entity Framework in the future
        private List<Product> _products;
        private int productCount;

        public ProductRepositoryTransient()
        {
            _products = new List<Product>();
        }
        public void Add()
        {
            productCount++;
            _products.Add(new Product() { ProductId = productCount, ProductName = "Laptop " + productCount, UnitPrice = 1500 });
        }

        public List<Product> GetAll()
        {
            return _products;
        }
    }
}
