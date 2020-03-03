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
        
        Session["AnOrderLine"] = AnOrderL;
        Response.Redirect("OrderLineViewer.aspx");



    }

    protected void TextBox_OrderLQuantity_TextChanged(object sender, EventArgs e)
    {
        
        
        
    }

    protected void Button_Find_Click(object sender, EventArgs e)
    {
        clsOrderline AnOrderline = new clsOrderline();
        Int32 OLineNumber;
        Boolean Found = false;
        OLineNumber = Convert.ToInt32(TextBox_Find.Text);
        Found = AnOrderline.Find(OLineNumber);
        
        if (Found == true)
        {
            TextBox_OrderLQuantity.Text = AnOrderline.Quantity.ToString();
            TextBox_OrderLONumber.Text = AnOrderline.ONumber.ToString();
            TextBox_ShoeID.Text = AnOrderline.ShoeID.ToString();

        }

    }
}