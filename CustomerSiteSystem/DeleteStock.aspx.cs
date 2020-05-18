using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainerTesting;

public partial class DeleteStock : System.Web.UI.Page
{

    Int32 ShoeID;

    protected void Page_Load(object sender, EventArgs e)
    {
        ShoeID = Convert.ToInt32(Session["ShoeID"]);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ClsStockCollection StockBook = new ClsStockCollection();

        StockBook.ThisStock.Find(ShoeID);

        StockBook.Delete();

        Response.Redirect("ShoeList.aspx");

    }
}