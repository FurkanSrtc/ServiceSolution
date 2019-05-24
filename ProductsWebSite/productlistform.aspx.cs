using ProductsWebSite.ProductServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductsWebSite
{
    public partial class productlistform : System.Web.UI.Page
    {
        ProductServiceReference.ProductServiceClient client = new ProductServiceReference.ProductServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
           var products=client.GetProducts();

            string s = string.Empty;

            foreach (var p in products)
            {
                s += p.ProductName + "</br>";
            }

            Literal1.Text = s;
        }
    }
}