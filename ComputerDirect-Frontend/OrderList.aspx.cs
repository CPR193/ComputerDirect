using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ComputerDirect_Classes;

public partial class OrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        ComputerDirect_Classes.clsOrderCollection Orders = new ComputerDirect_Classes.clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "OrderProgress";
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderId"] = -1;
        Response.Redirect("AnOrder.aspx");
    }

    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("DeleteOrder.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list; ";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("AnOrder.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }    
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByOrderProgress(txtFilter.Text);
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "OrderProgress";
        lstOrderList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByOrderProgress("");
        txtFilter.Text = "";
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "OrderProgress";
        lstOrderList.DataBind();
    }
}