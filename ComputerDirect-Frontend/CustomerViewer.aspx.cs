using System;
using ComputerDirect_TestCases;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Guest(object sender, EventArgs e)
    {
        //create a new instance
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object 
        AnCustomer = (clsCustomer)Session["AnCustomer"]
        //display the Guest for this entry 
        Response.Write(AnCustomer.Guest);
    }

    protected void CustomerName(object sender, EventArgs e)
    {
        //create a new instance
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object 
        AnCustomer = (clsCustomer)Session["AnCustomer"]
        //display the customer name for this entry 
        Response.Write(AnCustomer.CustomerName);
    }

    protected void CustomerId(object sender, EventArgs e)
    {
        //create a new instance 
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object 
        AnCustomer = (clsCustomer)Session["AnCustomer"]
        //display the customer Id for this entry 
        Response.Write(AnCustomer.CustomerId);
    }

    protected void Address(object sender, EventArgs e)
    {
        //create a new instance 
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object 
        AnCustomer = (clsCustomer)Session["AnCustomer"]
        //display the house number for this entry 
        Response.Write(AnCustomer.Address);
    }

    protected void Email(object sender, EventArgs e)
    {
        //create a new instance of clsAddress
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object 
        AnCustomer = (clsCustomer)Session["AnCustomer"]
        //display the Email for this entry 
        Response.Write(AnCustomer.Email);
    }

    protected void DateOfBirth(object sender, EventArgs e)
    {

        //create a new instance 
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object 
        AnCustomer = (clsCustomer)Session["AnCustomer"]
        //display the Date of Birth for this entry 
        Response.Write(AnCustomer.DateOfBirth);
    }

    protected void DateAdded(object sender, EventArgs e)
    {

        //create a new instance of clsAddress
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object 
        AnCustomer = (clsCustomer)Session["AnCustomer"]
        //display the Date Added for this entry 
        Response.Write(AnCustomer.DateAdded);
    }
}

protected void btnOK_Click(object sender, EventArgs e)
{
    //create a new instance of clsCustomer
    clsCustomer AnCustomer = new clsCustomer();
    //capture the Customer name
    AnCustomer.CustomerName = txtCustomerName.Text;
    //capture the CustomerId
    AnCustomer.CustomerId = txtCustomerId.Text;
    //capture the address
    AnCustomer.Address = txtCAddress.Text;
    //capture the Email
    AnCustomer.Email = txtEmail.Text;
    //capture the date of birth
    AnCustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
    //capture the Date Created
    AnCustomer.DateCreated = Convert.ToDateTime(txtDateCreated.Text);
    //store the customer in the session object
    Session["AnCustomer"] = AnCustomer;
    Response.Write("CustomerViewer.aspx");
}