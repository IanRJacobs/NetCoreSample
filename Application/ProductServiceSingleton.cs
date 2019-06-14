using Domain;
using Infrastructure;
using System;
using System.Collections.Generic;

namespace Application
{
    public class ProductServiceSingleton : IProductServiceSingleton
    {
        private IProductRepositorySingleton _productRepository;

        public ProductServiceSingleton(IProductRepositorySingleton productRepository)
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
