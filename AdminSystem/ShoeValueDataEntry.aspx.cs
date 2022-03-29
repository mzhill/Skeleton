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

    protected void txtRetailPrice_TextChanged(object sender, EventArgs e)    {

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsShoeValue
        clsShoeValue AnShoeValue = new clsShoeValue();
        //capture the Shoe
        AnShoeValue.ShoeID = Convert.ToInt32(txtShoeID.Text);
        //store the shoevalue in the session object
        Session["AnShoeValue"] = AnShoeValue;
        //naviagte to viewer page
        Response.Redirect("ShoeValueViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsShoeValue AnShoeVlaue = new clsShoeValue();
        //variable to store the primary key 
        Int32 ShoeID;
        //variable to store the result of the find operation
        Boolean Found=false;
        //get the primary key entered by the user
        ShoeID = Convert.ToInt32(txtShoeID.Text);
        //find the record
        Found = AnShoeVlaue.Find(ShoeID);
        //if found
        if (Found == true) ;
        {
            //display the valyes of the properties in the form
            txtRetailPrice.Text = AnShoeVlaue.ResalePrice;
            txtResalePrice.Text = AnShoeVlaue.ResalePrice;
            txtCatergory.Text = AnShoeVlaue.Catergory;
            txtReleaseDate.Text = AnShoeVlaue.ReleaseDate.ToString();
            chkStock.Text = AnShoeVlaue.Stock.ToString();

}




    }
}