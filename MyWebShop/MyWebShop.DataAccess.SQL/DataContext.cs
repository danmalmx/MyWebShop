using MyWebShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebShop.DataAccess.SQL
{
    public class DataContext : DbContext
    {
        public DataContext()
            :base ("DefaultConnection")
        {

        }

        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> Productcategories { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }

    }
}