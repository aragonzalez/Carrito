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
        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.GetDatos();
            }

        }

        private void GetDatos()
        {

            ProductsLogic pl = new ProductsLogic();
            GridViewProducts.DataSource = pl.GetAllProducts();
            GridViewProducts.DataBind();
        }

        protected void GridViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.GridViewProducts.SelectedValue;
            int id = this.SelectedID;
            if (id != 0)
            {
                this.GetProduct(id);
            }
            else 
            {
                this.errorLabel.Visible = true;
            }

        }

        private void GetProduct(int id)
        {
            ProductsLogic pl = new ProductsLogic();
            Products p = pl.GetProduct(id);
            ProductPanel.Visible = true;
            idProductTextBox.Text = p.ProductID.ToString();
            productNameTextBox.Text = p.ProductName;          
        }
    }
}