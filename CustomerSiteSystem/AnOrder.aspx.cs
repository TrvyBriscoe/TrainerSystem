using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainerClasses;

public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button_OFind_Click(object sender, EventArgs e)
    {
        ClsOrder AnOrder = new ClsOrder();
        Int32 ONumber;
        Boolean Found = false;
        ONumber = Convert.ToInt32(TextBox_ONum.Text);
        Found = AnOrder.Find(ONumber);

        if (Found == true)
        {
            TextBox_CID.Text = AnOrder.CustomerID.ToString();
            TextBox_Notes.Text = AnOrder.Notes;
            TextBox_DateA.Text = AnOrder.Date.ToString();
            CheckBox_OComplete.Checked = AnOrder.Complete;
        }
    }

    protected void Button_OK_Click(object sender, EventArgs e)
    {
        ClsOrder AnOrder = new ClsOrder();
        string ONumber = TextBox_ONum.Text;
        string CustomerID = TextBox_CID.Text;
        string Notes = TextBox_Notes.Text;
        string Date = TextBox_DateA.Text;
        bool Comp = CheckBox_OComplete.Checked;
        string Error = "";
        Error = AnOrder.Valid(CustomerID, Notes,Date);
        if (Error == "")
        {
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            AnOrder.Notes = Convert.ToString(Notes);
            AnOrder.Date = Convert.ToDateTime(Date);
            AnOrder.Complete = Comp;
            clsOrderCollection OrderList = new clsOrderCollection();
            OrderList.ThisOrder = AnOrder;
            OrderList.Add();
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            Label_OError.Text = Error;
        }
    }
}