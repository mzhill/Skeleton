using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
        clsShoeValueCollection ShoeValue = new clsShoeValueCollection();
        //find the record to delete
        ShoeValue.ThisShoeValue.Find(ShoeID);
        //delete the record
        ShoeValue.Delete();
        //redirect back to the main page
        Response.Redirect("ShoeValueList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {

    }
}