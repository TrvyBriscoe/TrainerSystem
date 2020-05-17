using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainerClasses;

public partial class DeleteOrderline : System.Web.UI.Page
{
    Int32 OLineNumber;
    protected void Page_Load(object sender, EventArgs e)
    {
        OLineNumber = Convert.ToInt32(Session["OLineNumber"]);
    }

    protected void ButtonYes_Click(object sender, EventArgs e)
    {
        clsOrderlineCollection OrderlineBook = new clsOrderlineCollection();
        OrderlineBook.ThisOrderline.Find(OLineNumber);
        OrderlineBook.Delete();
        Response.Redirect("OrderlineList.aspx");
    }
}