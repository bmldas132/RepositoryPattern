using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductApp.core;
using ProductApp.core.Interface;
using System.Collections;
using System.Data.Entity;
namespace productApp.Infrastructure
{
   public class ProductRepository: IProductRepository
    {
       ProductContext context = new ProductContext();
       public void Add(Product p)
       {
           context.Products.Add(p);
           context.SaveChanges();
       }
       public void Edit(Product p)
       {
           context.Entry(p).State = EntityState.Modified;       
       }

       public Product FindById(int Id)
       {
           ////var result = context.Products.Find(Id);
           var result = (from r in context.Products where r.ProdId == Id select r).FirstOrDefault();
           return result;
           //var obj = context.Products.Find(Id);
           //return obj;
       }

       public List<Product> GetProducts() { 
           return context.Products.ToList();
       }

       public void Remove(int Id)
       {
           var obj = context.Products.Find(Id);
           context.Products.Remove(obj);
           context.SaveChanges();
       }


       //IEnumerable IProductRepository.GetProducts()
       //{
       //    throw new NotImplementedException();
       //}
    }
}
