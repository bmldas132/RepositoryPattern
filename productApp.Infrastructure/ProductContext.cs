using ProductApp.core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productApp.Infrastructure
{
  public class ProductContext:DbContext
    {
      public ProductContext() : base("name=ProductConnectionString") {
         // Database.SetInitializer<ProductContext>(new CreateDatabaseIfNotExists<ProductContext>());
      }
      public DbSet<Product> Products { get; set; }
    }
}
