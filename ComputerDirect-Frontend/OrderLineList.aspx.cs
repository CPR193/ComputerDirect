using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ComputerDirect_Classes;

public partial class OrderLineList : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack == false)
        {

            DisplayOrderLines();

        }
    }

    private void DisplayOrderLines()
    {
        clsOrderLineCollection Lines = new clsOrderLineCollection();
        lstOrderLineList.DataSource = Lines.OrderLineList;
        lstOrderLineList.DataValueField = "OrderLineId";
        lstOrderLineList.DataTextField = "ItemDescription";
        lstOrderLineList.DataBind();
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("AnOrder.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderLineId"] = -1;
        Response.Redirect("AnOrderLine.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderLineId; 
        if (lstOrderLineList.SelectedIndex != -1)
        {
            OrderLineId = Convert.ToInt32(lstOrderLineList.SelectedValue);
            Session["OrderLineId"] = OrderLineId;
            Response.Redirect("DeleteOrderLine.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list; ";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderLineId;
        if (lstOrderLineList.SelectedIndex != -1)
        {
            OrderLineId = Convert.ToInt32(lstOrderLineList.SelectedValue);
            Session["OrderLineId"] = OrderLineId;
            Response.Redirect("AnOrderLine.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list; ";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection Lines = new clsOrderLineCollection();
        try
        {
            Lines.FilterByOrderId(Convert.ToInt32(txtFilter.Text));
            lstOrderLineList.DataSource = Lines.OrderLineList;
            lstOrderLineList.DataValueField = "OrderLineId";
            lstOrderLineList.DataBind();
        }
        catch
        {
            lblError.Text = "Please Insert an Order Id";
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection Lines = new clsOrderLineCollection();
        lstOrderLineList.DataSource = Lines.OrderLineList;
        lstOrderLineList.DataValueField = "OrderLineId";
        lstOrderLineList.DataTextField = "ItemDescription";
        lstOrderLineList.DataBind();
    }
}