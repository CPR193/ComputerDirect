using System;

protected partial class AnCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}

public void BtnOK_Click(object sender, EventArgs e)
{   //create a new instance of clsCustomer
    clsCustomer AnCustomer = new clsCustomer();
    //capture the house no
    AnCustomer.CustomerName = txtCustomerName.Text;
    //store the address in the session obejct 
    Session["AnCustomer"] = AnCustomer;
    //redirect to the viewer page 
    Response.Redirect("CustomerViewer.aspx");
}