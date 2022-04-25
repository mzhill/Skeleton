using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderID != -1)
            {
                //display the current data for the record
                DisplayOrders();
            }
        }
    }
    private void DisplayOrders()
    {
        //create a new instance of the Order collection
        clsOrderCollection OrderList = new clsOrderCollection();
        //find the record to update
        OrderList.ThisOrder.Find(OrderID);
        //display the data for this record
        txtOrderID.Text = OrderList.ThisOrder.OrderID.ToString();
        txtCustomerUsername.Text = OrderList.ThisOrder.CustomerUsername;
        txtQuantity.Text = OrderList.ThisOrder.Quantity.ToString();
        txtOrderDate.Text = OrderList.ThisOrder.OrderDate.ToString();
        chkNDD.Checked = OrderList.ThisOrder.NextDayDelivery;
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

            //create a new instance of the stock collection
            clsOrderCollection OrderList = new clsOrderCollection();

            //if this is a new record i.e. OrderID = -1 then add the data
            if (Convert.ToInt32(txtOrderID.Text) == -1)
            {
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(Convert.ToInt32(txtOrderID.Text));
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("OrderList.aspx");
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