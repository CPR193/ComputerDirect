using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ComputerDirect_Classes;

public partial class AnOrderLine : System.Web.UI.Page
{
    Int32 OrderLineId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderLineId = Convert.ToInt32(Session["OrderLineId"]);
        if (IsPostBack == false)
        {
            if (OrderLineId != -1)
                {
                    DisplayOrderLine();
                }
            }
        }

    private void DisplayOrderLine()
    {
        clsOrderLineCollection OrderLineList = new clsOrderLineCollection();
        OrderLineList.ThisOrderLine.Find(OrderLineId);
        txtOrderId.Text = OrderLineList.ThisOrderLine.OrderId.ToString();
        txtItemNo.Text = OrderLineList.ThisOrderLine.ItemNo.ToString();
        txtItemDescription.Text = OrderLineList.ThisOrderLine.ItemDescription.ToString();
        txtQuantity.Text = OrderLineList.ThisOrderLine.Quantity.ToString();
        txtUnitCost.Text = OrderLineList.ThisOrderLine.UnitCost.ToString();
    }

protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderLineList.aspx");
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        string Error = "";
        clsOrderLine AnOrderLine = new clsOrderLine();
        string OrderId = txtOrderId.Text;
        string ItemNo = txtItemNo.Text;
        string ItemDescription = txtItemDescription.Text;
        string Quantity = txtQuantity.Text;
        string UnitCost = txtUnitCost.Text;
        Error = AnOrderLine.Valid(OrderId, ItemNo, ItemDescription, Quantity, UnitCost);
        if (Error == "")
        {
            AnOrderLine.OrderLineId = OrderLineId;
            AnOrderLine.OrderId = Convert.ToInt32(OrderId);
            AnOrderLine.ItemNo = Convert.ToInt32(ItemNo);
            AnOrderLine.ItemDescription = ItemDescription;
            AnOrderLine.Quantity = Convert.ToInt32(Quantity);
            AnOrderLine.UnitCost = Convert.ToDecimal(UnitCost);
            clsOrderLineCollection OrderLineList = new clsOrderLineCollection();
            if (OrderLineId == -1)
            {
                OrderLineList.ThisOrderLine = AnOrderLine;
                OrderLineList.Add();
            }
            else
            {
                OrderLineList.ThisOrderLine.Find(OrderLineId);
                OrderLineList.ThisOrderLine = AnOrderLine;
                OrderLineList.Update();
            }
            Response.Redirect("OrderLineList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }
}