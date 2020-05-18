using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }
    void DisplayOrders()
    {
        TrainerClasses.clsOrderCollection Orders = new TrainerClasses.clsOrderCollection();
        ListBox_Order.DataSource = Orders.OrderList;
        ListBox_Order.DataValueField = "ONumber";
        ListBox_Order.DataTextField = "CustomerID";
        ListBox_Order.DataBind();
    }

    protected void Button_OAdd_Click(object sender, EventArgs e)
    {
        Session["AnOrder"] = -1;
        Response.Redirect("AnOrder.aspx");
    }

    protected void Button_ODel_Click(object sender, EventArgs e)
    {
        Int32 ONumber;
        if (ListBox_Order.SelectedIndex != -1)
        {
            ONumber = Convert.ToInt32(ListBox_Order.SelectedValue);
            Session["ONumber"] = ONumber;
            Response.Redirect("DeleteOrder.aspx");

        }
        else
        {
            Label_OEr.Text = "Please select a record from the list to delete";
        }
    }

    protected void ListBox_Order_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}