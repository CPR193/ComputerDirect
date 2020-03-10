using ComputerDirect_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write("Order ID: " + AnOrder.OrderId);
        Response.Write("\nOrder Date: " + AnOrder.OrderDate);
        Response.Write("\nOrder Lines: " + AnOrder.OrderLines);
        Response.Write("\nOrder Status: " + AnOrder.OrderStatus);
    }
}