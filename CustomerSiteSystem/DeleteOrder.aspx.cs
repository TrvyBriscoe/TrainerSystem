using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainerClasses;

public partial class DeleteOrder : System.Web.UI.Page
{
    Int32 ONumber;
    protected void Page_Load(object sender, EventArgs e)
    {
        ONumber = Convert.ToInt32(Session["ONumber"]); 

    }

    protected void Button_Yes_Click(object sender, EventArgs e)
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(ONumber);
        OrderBook.Delete();
        Response.Redirect("OrderList.aspx");
    }
}