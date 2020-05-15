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

    protected void Button_Find_Click1(object sender, EventArgs e)
    {

    }
    protected void Button_OrderLOK_Click(object sender, EventArgs e)
    {
        clsOrderline AnOrderL = new clsOrderline();
        string ONumber = TextBox_OrderLONumber.Text;
        string Quantity = TextBox_OrderLQuantity.Text;
        string ShoeID = TextBox_ShoeID.Text;
        string Error = "";
        Error = AnOrderL.Valid(ONumber, Quantity, ShoeID);
        if (Error == "")
        {
            AnOrderL.ONumber = Convert.ToInt32(ONumber);
            AnOrderL.Quantity = Convert.ToInt32(Quantity);
            AnOrderL.ShoeID = Convert.ToInt32(ShoeID);
            Session["AnOrderLine"] = AnOrderL;
            Response.Write("OrderLineViewer.aspx");
        }
        else
        {
            Label_OrderLError.Text = Error;
        }
    }


}
