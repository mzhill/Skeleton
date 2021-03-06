using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of the class
        clsStock AStock = new clsStock();
        //get the data from the session object
        AStock = (clsStock)Session["AStock"];

        //display the shoe id on the page
        Response.Write(AStock.ShoeID + "\n");

        //display the shoe description on the page
        Response.Write(AStock.ShoeDescription + "\n");

        //display the shoe colour on the page
        Response.Write(AStock.ShoeColour + "\n");

        //display the shoe quantity on the page
        Response.Write(AStock.Quantity + "\n");

        //display the shoe release date on the page
        Response.Write(AStock.InitialReleaseDate + "\n");

        //display the shoe availability on the page
        Response.Write(AStock.Availability + "\n");
    }
}