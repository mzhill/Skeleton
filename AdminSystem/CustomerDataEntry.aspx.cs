using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void bntOK_Click(object sender, EventArgs e)
    {
        //create a new instance for clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the CustomerID
        AnCustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //store the address in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
        
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsCustomer AnCustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result of find operation
        Boolean Found = false;
        //get tje primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = AnCustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the values
            txtCustomerForename.Text = AnCustomer.CustomerForename;
            txtCustomerSurname.Text = AnCustomer.CustomerSurname;
            txtCustomerDOB.Text = AnCustomer.CustomerDOB.ToString();
            txtCustomerEmail.Text = AnCustomer.CustomerEmail;
            txtCustomerTel.Text = AnCustomer.CustomerTel;
            chkCustomerMembership.Text = AnCustomer.CustomerMembership.ToString();



        }
    }
}