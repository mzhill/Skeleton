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
        //get the number of the shoevalue to be processed
        ShoeID = Convert.ToInt32(Session["ShoeID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (ShoeID != -1)
            {
                //display the current data for the record
                DisplayShoeValue();
            }
        }
    }

    private void DisplayShoeValue()
    {
        //create a new instance of the shoe value collection
        clsShoeValueCollection ShoeValueList = new clsShoeValueCollection();
        //find the record to update
        ShoeValueList.ThisShoeValue.Find(ShoeID);
        //display the data for this record
        txtShoeID.Text = ShoeValueList.ThisShoeValue.ShoeID.ToString();
        txtRetailPrice.Text = ShoeValueList.ThisShoeValue.RetailPrice.ToString();
        txtResalePrice.Text = ShoeValueList.ThisShoeValue.ResalePrice.ToString();
        txtCatergory.Text = ShoeValueList.ThisShoeValue.Catergory.ToString();
        txtReleaseDate.Text = ShoeValueList.ThisShoeValue.ReleaseDate.ToString();
        chkStock.Checked = ShoeValueList.ThisShoeValue.Stock;
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

            //create a new instance of the shoe value collection
            clsShoeValueCollection ShoeValueList = new clsShoeValueCollection();

            //if this is a new record i.e. ShoeID = -1 then add the data
            if (Convert.ToInt32(txtShoeID.Text) == -1)
            {
                //set the ThisShoeValue property
                ShoeValueList.ThisShoeValue = AnShoeValue;
                //add the new record
                ShoeValueList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                ShoeValueList.ThisShoeValue.Find(Convert.ToInt32(txtShoeID.Text));
                //set the ThisShoeValue property
                ShoeValueList.ThisShoeValue = AnShoeValue;
                //update the record
                ShoeValueList.Update();
            }

            //navigate to the list page
            Response.Redirect("ShoeValueList.aspx");
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
        clsShoeValue AnShoeValue = new clsShoeValue();
        //variable to store the primary key 
        Int32 ShoeID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ShoeID = Convert.ToInt32(txtShoeID.Text);
        //find the record
        Found = AnShoeValue.Find(ShoeID);
        //if found
        if (Found == true)
        {
            //display the valyes of the properties in the form
            txtRetailPrice.Text = AnShoeValue.ResalePrice;
            txtResalePrice.Text = AnShoeValue.ResalePrice;
            txtCatergory.Text = AnShoeValue.Catergory;
            txtReleaseDate.Text = AnShoeValue.ReleaseDate.ToString();
            chkStock.Text = AnShoeValue.Stock.ToString();
            lblError.Text = "";
        }
        else
        {
            txtRetailPrice.Text = "";
            txtResalePrice.Text = "";
            txtCatergory.Text = "";
            txtReleaseDate.Text = "";
            chkStock.Checked = AnShoeValue.Stock;
            lblError.Text = "Error: No stock has been found with the Shoe ID " + ShoeID;
        }
    }
}