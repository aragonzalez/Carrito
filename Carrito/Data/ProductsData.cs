using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Data
{
    public class ProductsData
    {
        public List<Products> GetAllProducts()
        {
            using (NorthwindEntities context = new NorthwindEntities())
            {
                return context.Products.ToList();
            }
        }

        public Products GetProduct(int id)
        {
            Products prod = new Products();
            using (NorthwindEntities context = new NorthwindEntities())
            {
               prod = (from p in context.Products where p.ProductID == id select p).First();
               return prod;
            }


        }
    }
}
