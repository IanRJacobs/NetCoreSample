using Domain;
using Infrastructure;
using System;
using System.Collections.Generic;

namespace Application
{
    public class ProductServiceTransient : IProductServiceTransient
    {
        private IProductRepositoryTransient _productRepository;

        public ProductServiceTransient(IProductRepositoryTransient productRepository)
        {
            _productRepository = productRepository;
        }
        public void Add()
        {
            _productRepository.Add();
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }
    }
}
