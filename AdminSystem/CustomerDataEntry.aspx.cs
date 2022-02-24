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
}