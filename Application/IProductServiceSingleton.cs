using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public interface IProductServiceSingleton
    {
        List<Product> GetAll();
        void Add();
    }
}
