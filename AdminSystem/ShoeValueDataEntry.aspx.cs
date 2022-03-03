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

    protected void txtRetailPrice_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsShoeValue
        clsShoeValue AnShoeValue = new clsShoeValue();
        //capture the Shoe
        AnShoeValue.ShoeID = Convert.ToInt32(txtShoe.Text);
        //store the shoevalue in the session object
        Session["AnShoeValue"] = AnShoeValue;
        //naviagte to viewer page
        Response.Redirect("ShoeValueViewer.aspx");
    }
}