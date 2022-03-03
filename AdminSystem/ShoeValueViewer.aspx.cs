using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an new instance of clsShoeValue
        clsShoeValue AnShoeValue = new clsShoeValue();
        //get the data from the session object
        AnShoeValue = (clsShoeValue)Session["AnShoeValue"];
        //display the Shoe from this entry
        Response.Write(AnShoeValue.ShoeID);

    }
}