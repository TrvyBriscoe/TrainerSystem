using System;
using TrainerClasses;
public partial class AnOrderLine : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button_OrderLOK_Click(object sender, EventArgs e)
    {
        clsOrderline AnOrderL = new clsOrderline();
        AnOrderL.ONumber = TextBox_OrderLONumber.Text;
        Session["AnOrderL"] = AnOrderL;
        Response.Redirect("AnOrderLine.aspx");
    }
}