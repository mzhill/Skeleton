﻿using System;
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
        AStock.ShoeID = txtShoeID.MaxLength;

        //capture the shoe description
        AStock.ShoeDescription = txtShoeDesc.Text;

        //capture the shoe colour
        AStock.ShoeColour = txtShoeColour.Text;

        //capture the shoe quantity
        AStock.Quantity = txtQuantity.MaxLength;



        //store the stock in the session object
        Session["AStock"] = AStock;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }
}