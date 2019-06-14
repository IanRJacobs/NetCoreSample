using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public interface IProductServiceTransient
    {
        List<Product> GetAll();
        void Add();
    }
}
