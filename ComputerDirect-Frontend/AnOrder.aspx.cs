using ComputerDirect_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder.OrderId = Int32.Parse(TextBox1.Text);
        AnOrder.OrderDate = Convert.ToDateTime(TextBox2.Text);
        AnOrder.OrderLines = Int32.Parse(TextBox4.Text);
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
    }
}