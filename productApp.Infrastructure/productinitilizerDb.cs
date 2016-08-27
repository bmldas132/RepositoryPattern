using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProductApp.core;
namespace productApp.Infrastructure
{
    public class ProductInitalizeDB : CreateDatabaseIfNotExists<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            context.Products.Add(new Product { ProdId = 1, ProductName = "Rice", Instock = true, ProductPrice = 30 });
            context.Products.Add(new Product { ProdId = 2, ProductName = "Sugar", Instock = false, ProductPrice = 40 });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}