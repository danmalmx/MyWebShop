﻿using MyWebShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebShop.Core.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Product { get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
    }
}
