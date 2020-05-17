using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainerClasses;

public partial class Stock : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ClsStock Stock = new ClsStock();

            Stock = (ClsStock)Session["Stock"];

            if (Stock != null )
            {
                Response.Write(Stock.ShoeID);
            }
            
        }
           


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ClsStock Stock = new ClsStock
        {
            ShoeID = Convert.ToInt16(TextBox5.Text),

            Name = TextBox1.Text,

            Release = Convert.ToDateTime(TextBox2.Text),

            QuantityStock = Convert.ToInt16(TextBox6.Text),

            PriceStock = Convert.ToInt16(TextBox4.Text),

            Size = Convert.ToInt16(DropDownList1.Text)
        };

        Session["Stock"] = Stock;

        Response.Redirect("Stock.aspx");

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    /**protected void Button3_Click(object sender, EventArgs e)
    {
        ClsStock Stock = new ClsStock();

        Int32 ShoeID;

        Boolean Found = false;

        ShoeID = Convert.ToInt16(TextBox5.Text);

        Found = Stock.Find(ShoeID);

        if (Found == true)
        {
            TextBox1.Text = Stock.Name;
            TextBox2.Text = Stock.Release.ToShortDateString;
            TextBox6.Text = Stock.QuantityStock;
            TextBox4.Text = Stock.PriceStock;
            DropDownList1.Text = Stock.Size.ToString;




        }
    }**/
}