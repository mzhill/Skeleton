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
        //create a new instance of clsStock
        clsStock AStock = new clsStock();

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

        //store the stock in the session object
        Session["AStock"] = AStock;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
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
            txtShoeDesc.Text = "--";
            txtShoeColour.Text = "--";
            txtQuantity.Text = "--";
            txtReleaseDate.Text = "--";
            chkAvailability.Checked = AStock.Availability;
            lblError.Text = "Error: No stock has been found with the Shoe ID " + ShoeID;
        }
    }
}