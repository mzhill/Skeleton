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

  
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the orderID
        AnOrder.OrderID = Convert.ToInt32(txtOrderID.Text);
        //store the orderID in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderID;
        //variable to store the result of find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderID = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = AnOrder.Find(OrderID);
        //if found
        if (Found == true)
        {
            //display the values
            txtOrderID.Text = AnOrder.OrderID.ToString();
            txtCustomerUsername.Text = AnOrder.CustomerUsername;
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtQuantity.Text = AnOrder.Quantity.ToString();
            chkNDD.Text = AnOrder.NextDayDelivery.ToString();



        }
    
}
}