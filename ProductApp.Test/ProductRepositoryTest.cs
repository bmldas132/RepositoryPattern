using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using productApp.Infrastructure;
using ProductApp.core;
namespace ProductApp.Test
{
    /// <summary>
    /// Summary description for ProductRepositoryTest
    /// </summary>
    [TestClass]
    public class ProductRepositoryTest
    {
        ProductRepository repo= new ProductRepository();

         [TestMethod]
        public void TestSetup(){
            ProductInitalizeDB db = new ProductInitalizeDB();
            System.Data.Entity.Database.SetInitializer(db);
            repo = new ProductRepository();
        }


        [TestMethod]
        public void IsRepositoryAddMethods()
        {
            //
            // TODO: Add test logic here
            //
            Product productInsert = new Product
            {
                ProdId=3,
                ProductName="Shirt",
                ProductPrice=250.50,
                Instock=true
            };
            repo.Add(productInsert);
            var result = repo.GetProducts();
            var numberofResult = result.Count;
            Assert.AreEqual(3, numberofResult);
        }
    }
}
