using Domain;
using Infrastructure;
using System;
using System.Collections.Generic;

namespace Application
{
    public class ProductServiceScoped : IProductServiceScoped
    {
        private IProductRepositoryScoped _productRepository;

        public ProductServiceScoped(IProductRepositoryScoped productRepository)
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
