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
            using (NorthwindEntities db = new NorthwindEntities())
            {
                return db.Products.ToList();
            }
        }
    }
}
