using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_Product
    {
        public List<ProductEntity> ProductyList()
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList();
            }
        }

        public static void CreateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Add(oProduct);
                db.SaveChanges();
            } 
        }

        public static void UpdateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Update(oProduct);
                db.SaveChanges();
            }
        }
    }
}
