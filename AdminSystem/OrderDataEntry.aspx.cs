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

        //capture the order id
        string OrderID = txtOrderID.Text;

        //capture the customer username
        string CustomerUsername = txtCustomerUsername.Text;


        //capture the quantity
        string Quantity = txtQuantity.Text;

        //capture the order date
        string OrderDate = txtOrderDate.Text;

        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);

        if (Error == "")
        {
            //capture the order id
            AnOrder.OrderID = Convert.ToInt32(txtOrderID.Text);

            //capture the customer username
            AnOrder.CustomerUsername = txtCustomerUsername.Text;


            //capture the quantity
            AnOrder.Quantity = Convert.ToInt32(txtQuantity.Text);

            //capture the order date
            AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);

            //capture the next day delivery
            AnOrder.NextDayDelivery = Convert.ToBoolean(chkNDD.Checked);

            //store the order in the session object
            Session["AnOrder"] = AnOrder;
            //navigate to the viewer page
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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