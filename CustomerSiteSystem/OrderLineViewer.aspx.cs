using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainerClasses;

public partial class OrderLineViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrderline AnOrderline = new clsOrderline();
        AnOrderline = (clsOrderline)Session["AnOrderLine"];
        Response.Write(AnOrderline.ONumber);
    }
}