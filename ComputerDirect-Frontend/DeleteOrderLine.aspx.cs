using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ComputerDirect_Classes;

public partial class DeleteOrderLine : System.Web.UI.Page
{
    Int32 OrderLineId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderLineId = Convert.ToInt32(Session["OrderLineId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection OrderLines = new clsOrderLineCollection();
        OrderLines.ThisOrderLine.Find(OrderLineId);
        OrderLines.Delete();
        Response.Redirect("OrderLineList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderLineList.aspx");
    }
}