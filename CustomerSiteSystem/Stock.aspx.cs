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
        ClsStock Stock = new ClsStock();
        
            //ShoeID = Convert.ToInt16(TextBox5.Text),

            //Name = TextBox1.Text,

            string Name = TextBox1.Text;

        //Release = Convert.ToDateTime(TextBox2.Text),

            string Release = Convert.ToString(TextBox2.Text);

        //QuantityStock = Convert.ToInt16(TextBox6.Text),

            string QuantityStock = Convert.ToString(TextBox4.Text);

        //PriceStock = Convert.ToInt16(TextBox4.Text),

            string PriceStock = Convert.ToString(TextBox4.Text);

        //Size = Convert.ToInt16(DropDownList1.Text)

        string Size = Convert.ToString(DropDownList1.Text);



        string Error = "";
        Error = Stock.Valid(Name, Release, QuantityStock, PriceStock, Size);
        if (Error == "")
        {
            Stock.Name = Name;
            Stock.Release = Convert.ToDateTime(Release);
            Stock.QuantityStock = Convert.ToInt32(QuantityStock);
            Stock.PriceStock = Convert.ToInt32(PriceStock);
            Stock.Size = Convert.ToInt32(Size);

            TrainerTesting.ClsStockCollection StockList = new TrainerTesting.ClsStockCollection();

            Int32 ShoeID = 0;
            if (ShoeID == -1)
            {
                StockList.ThisStock = ShoeID;

                StockList.Add();
            }

            else
            {
                StockList.ThisStock.Find(ShoeID);

                StockList.ThisStock = ShoeID;

                StockList.Update();
            }
            StockList.ThisStock = Stock;

            StockList.Add();

        //Session["Stock"] = Stock;

        Response.Redirect("Stock.aspx");
        }

        else
        {
            //lblError.Text = Error;
            
        }




    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        ClsStock Stock = new ClsStock();

        int ShoeID;

        Boolean Found = false;

        ShoeID = Convert.ToInt32(TextBox5.Text);

        Found = Stock.Find(ShoeID);

        if (Found == true)
        {
            TextBox1.Text = Stock.Name;
            TextBox2.Text = Stock.Release.ToString();
            TextBox6.Text = Stock.QuantityStock.ToString();
            TextBox4.Text = Stock.PriceStock.ToString();
            DropDownList1.Text = Stock.Size.ToString();




        }
    }
}