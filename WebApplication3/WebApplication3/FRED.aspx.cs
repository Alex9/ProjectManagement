using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DBConnect connect = new DBConnect();
            connect.InsertPHXrnsa(ListBox1);
            connect.InsertPhoeURN(ListBox1);
            connect.InsertMariURN(ListBox1);
            connect.InsertMariPOP(ListBox1);
            connect.InsertMariLFN(ListBox1);
            connect.InsertAZSTHPI(ListBox1);
            connect.InsertSPCS20RSA(ListBox1);
            connect.InsertSPCS20RNSA(ListBox1);
            connect.InsertSPCS20RPSNSA(ListBox1);
            connect.InsertSPCS10RSA(ListBox1);
            connect.InsertSPCS10RNSA(ListBox1);
            connect.InsertSPCS10RPSNSA(ListBox1);
        }
    }
}