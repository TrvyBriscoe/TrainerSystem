using System;
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

    
}
