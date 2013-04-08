using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("FRED.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("BelFiore.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeNested.aspx");
        }
    }
}