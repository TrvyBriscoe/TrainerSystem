using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        TrainerClasses.clsOrderCollection Stock = new TrainerClasses.clsOrderCollection();

        IstStockList.DataSource = Stock.Count;

        IstStockList.DataValueField = "ShoeID";

        IstStockList.DataTextField = "Name";

        IstStockList.DataBind();

    }

    protected void IstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["ShoeID"] = -1;

        Response.Redirect("Stock.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ShoeID;

        if (IstStockList.SelectedIndex != -1)
        {
            ShoeID = Convert.ToInt32(IstStockList.SelectedIndex);

            Session["ShoeID"] = ShoeID;

            Response.Redirect("DeleteShoe.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ShoeID;

        if (IstStockList.SelectedIndex != -1)
        {
            ShoeID = Convert.ToInt32(IstStockList.SelectedIndex);

            Session["ShoeID"] = ShoeID;

            Response.Redirect("DeleteShoe.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }


    }
}