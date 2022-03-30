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
        //capture ShoeID
        string ShoeID = txtShoeID.Text;
        //capture ResalePrice
        string RetailPrice = txtRetailPrice.Text;
        //capture ResalePrice
        string ResalePrice = txtResalePrice.Text;
        //capture  Catergory
        string Catergory = txtCatergory.Text;
        //capture ReleaseDate 
        string ReleaseDate = txtReleaseDate.Text;
        //variable the data 
        String Error = "";
        Error = AnShoeValue.Valid(ReleaseDate, RetailPrice, ResalePrice, Catergory);
        if (Error == "")
        {

            //capture the shoe id
            AnShoeValue.ShoeID = Convert.ToInt32(txtShoeID.Text);

            //capture the shoe description
            AnShoeValue.RetailPrice = txtRetailPrice.Text;

            //capture the shoe colour
            AnShoeValue.ResalePrice = txtResalePrice.Text;

            //capture the shoe quantity
            AnShoeValue.Catergory = txtCatergory.Text;

            //capture the shoe release date
            AnShoeValue.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);

            //capture the shoe availability
            AnShoeValue.Stock = Convert.ToBoolean(chkStock.Checked);

            //store the stock in the session object
            Session["AShoeValue"] = AnShoeValue;
            //navigate to the viewer page
            Response.Redirect("ShoeValueViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
  



    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsShoeValue AnShoeVlaue = new clsShoeValue();
        //variable to store the primary key 
        Int32 ShoeID;
        //variable to store the result of the find operation
        Boolean Found = false;
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