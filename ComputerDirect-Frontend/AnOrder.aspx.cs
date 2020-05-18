using ComputerDirect_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrder : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            if (OrderId != -1)
            {
                DisplayOrder();
            }
        }
    }

    private void DisplayOrder()
    {
        clsOrderCollection OrderList = new clsOrderCollection();
        OrderList.ThisOrder.Find(OrderId);
        txtOrderId.Text = OrderList.ThisOrder.OrderId.ToString();
        txtOrderDate.Text = OrderList.ThisOrder.OrderDate.ToString();
        txtOrderTotal.Text = OrderList.ThisOrder.OrderTotal.ToString();
        txtCustomerId.Text = OrderList.ThisOrder.CustomerId.ToString();
        txtStaffId.Text = OrderList.ThisOrder.StaffId.ToString();
        txtOrderProgress.Text = OrderList.ThisOrder.OrderProgress;
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        string Error = "";
        clsOrder AnOrder = new clsOrder();
        string OrderDate = txtOrderDate.Text;
        string CustomerId = txtCustomerId.Text;
        string StaffId = txtStaffId.Text;
        string OrderTotal = txtOrderTotal.Text;
        string OrderProgress = txtOrderProgress.Text;
        Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, OrderTotal, OrderProgress);
        if (Error == "")
        {
            AnOrder.OrderId = OrderId;
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.OrderTotal = Convert.ToDecimal(OrderTotal);
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);
            AnOrder.StaffId = Convert.ToInt32(StaffId);
            AnOrder.OrderProgress = OrderProgress;
            AnOrder.OrderStatus = chkOrderStatus.Checked;
            clsOrderCollection OrderList = new clsOrderCollection();
            if (OrderId == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderId);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            Response.Redirect("OrderList.aspx");
        }

        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderId;
        Boolean Found = false;
        OrderId = Convert.ToInt32(txtOrderId.Text);
        Found = AnOrder.Find(OrderId);
        if (Found == true)
        {
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtOrderTotal.Text = AnOrder.OrderTotal.ToString();
            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            txtStaffId.Text = AnOrder.StaffId.ToString();
            txtOrderProgress.Text = AnOrder.OrderProgress;
            lblError.Text = "";
        }
        else
        {
            lblError.Text = "Order Not Found; ";
        }
        
    }


    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        if (AnOrder.OrderStatus == false) {
            AnOrder.OrderStatus = true;
        }
        else
        {
            AnOrder.OrderStatus = false;
        }
    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderLineList.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }

}