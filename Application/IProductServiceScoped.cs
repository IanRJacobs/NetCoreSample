﻿using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public interface IProductServiceScoped
    {
        List<Product> GetAll();
        void Add();
    }
}
