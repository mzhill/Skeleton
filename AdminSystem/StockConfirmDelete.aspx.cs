using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 ShoeID;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the id of the shoe to be deleted from the session object
        ShoeID = Convert.ToInt32(Session["ShoeID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create an instance of the Stock collection
        clsStockCollection Stock = new clsStockCollection();
        //find the record to delete
        Stock.ThisStock.Find(ShoeID);
        //delete the record
        Stock.Delete();
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }
}