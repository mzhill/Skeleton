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
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        //create an instance of the Stock collection
        clsStockCollection Stock = new clsStockCollection();
        //set the data source to list of stock in the collection
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "ShoeID";
        //set the data field to display
        lstStockList.DataTextField = "ShoeDescription";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ShoeID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 ShoeID;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ShoeID = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["ShoeID"] = ShoeID;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 ShoeID;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ShoeID = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["ShoeID"] = ShoeID;
            //redirect to the delete page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the Stock collection
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByShoeColour(txtFilter.Text);
        //set the data source to list of stock in the collection
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "ShoeID";
        //set the name of the field to display
        lstStockList.DataTextField = "ShoeColour";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the Stock collection
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByShoeColour("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to list of stock in the collection
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "ShoeID";
        //set the name of the field to display
        lstStockList.DataTextField = "ShoeColour";
        //bind the data to the list
        lstStockList.DataBind();
    }
}