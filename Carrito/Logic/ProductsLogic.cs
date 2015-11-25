using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;

namespace Logic
{
    public class ProductsLogic
    {
        public List<Products> GetAllProducts()
        {
            ProductsData pd = new ProductsData();
            return pd.GetAllProducts();
        }
    }
}
