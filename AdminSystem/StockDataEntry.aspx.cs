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
    Int32 ShoeID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stock to be processed
        ShoeID = Convert.ToInt32(Session["ShoeID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (ShoeID != -1)
            {
                //display the current data for the record
                DisplayStock();
            }
        }
    }

    private void DisplayStock()
    {
        //create a new instance of the stock collection
        clsStockCollection StockList = new clsStockCollection();
        //find the record to update
        StockList.ThisStock.Find(ShoeID);
        //display the data for this record
        txtShoeID.Text = StockList.ThisStock.ShoeID.ToString();
        txtShoeDesc.Text = StockList.ThisStock.ShoeDescription;
        txtShoeColour.Text = StockList.ThisStock.ShoeColour;
        txtQuantity.Text = StockList.ThisStock.Quantity.ToString();
        txtReleaseDate.Text = StockList.ThisStock.InitialReleaseDate.ToString();
        chkAvailability.Checked = StockList.ThisStock.Availability;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();

        //capture the shoe id
        string ShoeID = txtShoeID.Text;

        //capture the shoe description
        string ShoeDesc = txtShoeDesc.Text;

        //capture the shoe colour
        string ShoeColour = txtShoeColour.Text;

        //capture the shoe quantity
        string Quantity = txtQuantity.Text;

        //capture the shoe release date
        string InitialReleaseDate = txtReleaseDate.Text;

        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);

        if (Error == "")
        {
            //capture the shoe id
            AStock.ShoeID = Convert.ToInt32(txtShoeID.Text);

            //capture the shoe description
            AStock.ShoeDescription = txtShoeDesc.Text;

            //capture the shoe colour
            AStock.ShoeColour = txtShoeColour.Text;

            //capture the shoe quantity
            AStock.Quantity = Convert.ToInt32(txtQuantity.Text);

            //capture the shoe release date
            AStock.InitialReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);

            //capture the shoe availability
            AStock.Availability = Convert.ToBoolean(chkAvailability.Checked);

            //create a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();

            //if this is a new record i.e. ShoeID = -1 then add the data
            if (Convert.ToInt32(txtShoeID.Text) == -1)
            {
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //add the new record
                StockList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StockList.ThisStock.Find(Convert.ToInt32(txtShoeID.Text));
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //update the record
                StockList.Update();
            }
            

            //redirect back to the listpage
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of clsStock
        clsStock AStock = new clsStock();
        //variable to store the primary key
        Int32 ShoeID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ShoeID = Convert.ToInt32(txtShoeID.Text);
        //find the record
        Found = AStock.Find(ShoeID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtShoeDesc.Text = AStock.ShoeDescription;
            txtShoeColour.Text = AStock.ShoeColour;
            txtQuantity.Text = AStock.Quantity.ToString();
            txtReleaseDate.Text = AStock.InitialReleaseDate.ToString();
            chkAvailability.Checked = AStock.Availability;
            lblError.Text = "";
        }
        else
        {
            txtShoeDesc.Text = "";
            txtShoeColour.Text = "";
            txtQuantity.Text = "";
            txtReleaseDate.Text = "";
            chkAvailability.Checked = AStock.Availability;
            lblError.Text = "Error: No stock has been found with the Shoe ID " + ShoeID;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}