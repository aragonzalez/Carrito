using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using Logic;

namespace UI.Web.ASPNET
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void GetDatos()
        {

            ProductsLogic pl = new ProductsLogic();
            GridViewProductos.DataSource = pl.GetAllProducts();
            GridViewProductos.DataBind();
        }
    }
}