﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainerClasses;

public partial class OrderViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClsOrder AnOrder = new ClsOrder();
        AnOrder = (ClsOrder)Session["AnOrder"];
        Response.Write(AnOrder.CustomerID);
    }
}