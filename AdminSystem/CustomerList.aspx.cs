using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }

    }

    void DisplayCustomers()
    {
        //create an instance of customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to list of customers in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set the data field to display
        lstCustomerList.DataTextField = "CustomerEmail";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the sessopm onject to indicate this a new record
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CustomerID;
        //if a record has been selected for the list
        if(lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else//if no record has been selected
        {
            lblError.Text = "please select a record to edit from the list";
        }


    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CustomerID;
        //if a record has been selected from the list
        if(lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByCustomerSurname(txtFilter.Text);
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set the name of the field  to display
        lstCustomerList.DataTextField = "CustomerSurname";
        //bind the data to the list
        lstCustomerList.DataBind();
    }


    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByCustomerSurname("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set the name of the field  to display
        lstCustomerList.DataTextField = "CustomerSurname";
        //bind the data to the list
        lstCustomerList.DataBind();

    }
}
