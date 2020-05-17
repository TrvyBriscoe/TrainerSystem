using System;
using TrainerClasses;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderlineList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrderlines();
        }
    }
        void DisplayOrderlines()
        {
            TrainerClasses.clsOrderlineCollection Orderlines = new TrainerClasses.clsOrderlineCollection();
            ListBox_OL.DataSource = Orderlines.OrderlineList;
            ListBox_OL.DataValueField = "OLineNumber";
            ListBox_OL.DataTextField = "ONumber";
            ListBox_OL.DataBind();
        }



    protected void ListBox_OL_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button_Add_Click(object sender, EventArgs e)
    {
        Session["AnOrderline"] = -1;
        Response.Redirect("AnOrderline.aspx");
    }

    protected void ButtonDel_Click(object sender, EventArgs e)
    {
        Int32 OLineNumber;
        if(ListBox_OL.SelectedIndex != -1)
        {
            OLineNumber = Convert.ToInt32(ListBox_OL.SelectedValue);
            Session["OLineNumber"] = OLineNumber;
            Response.Redirect("DeleteOrderline.aspx");

        }
        else
        {
            Label_Er.Text = "Please select a record from the list to delete";
        }
    }

    protected void Button_Edit_Click(object sender, EventArgs e)
    {
        Int32 OLineNumber;
        if(ListBox_OL.SelectedIndex != -1)
        {
            OLineNumber = Convert.ToInt32(ListBox_OL.SelectedValue);
            Session["OLineNumber"] = OLineNumber;
            Response.Redirect("AnOrderline.aspx");
          }
        else
        {
            Label_Er.Text = "Please select a record";        }
    }
}
