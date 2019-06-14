using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface IProductRepositoryTransient
    {
        List<Product> GetAll();
        void Add();
    }
}
