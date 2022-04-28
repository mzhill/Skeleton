using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayShoeValue();
        }
    }

    void DisplayShoeValue()
    {
        //create an instance of the shoe value collection
        clsShoeValueCollection ShoeValue = new clsShoeValueCollection();
        //set the data source to list of stock in the collection
        lstShoeValueList.DataSource = ShoeValue.ShoeValueList;
        //set the name of the primary key
        lstShoeValueList.DataValueField = "ShoeID";
        //set the data field to display
        lstShoeValueList.DataTextField = "Catergory ";
        //bind the data to the list
        lstShoeValueList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ShoeID"] = -1;
        //redirect to the data entry page
        Response.Redirect("ShoeValueDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 ShoeID;
        //if a record has been selected from the list
        if (lstShoeValueList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ShoeID = Convert.ToInt32(lstShoeValueList.SelectedValue);
            //store the data in the session object
            Session["ShoeID"] = ShoeID;
            //redirect to the edit page
            Response.Redirect("ShoeValueDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 ShoeID;
        //if a record has been selected from the list
        if (lstShoeValueList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ShoeID = Convert.ToInt32(lstShoeValueList.SelectedValue);
            //store the data in the session object
            Session["ShoeID"] = ShoeID;
            //redirect to the delete page
            Response.Redirect("ShoeValueConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the shoe value collection
        clsShoeValueCollection ShoeValue = new clsShoeValueCollection();
        ShoeValue.ReportByCatergory(txtFilter.Text);
        //set the data source to list of stock in the collection
        lstShoeValueList.DataSource = ShoeValue.ShoeValueList;
        //set the name of the primary key
        lstShoeValueList.DataValueField = "ShoeID";
        //set the name of the field to display
        lstShoeValueList.DataTextField = "Catergory ";
        //bind the data to the list
        lstShoeValueList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the Stock collection
        clsShoeValueCollection ShoeValue = new clsShoeValueCollection();
        ShoeValue.ReportByCatergory("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to list of stock in the collection
        lstShoeValueList.DataSource = ShoeValue.ShoeValueList;
        //set the name of the primary key
        lstShoeValueList.DataValueField = "ShoeID";
        //set the name of the field to display
        lstShoeValueList.DataTextField = "Catergory ";
        //bind the data to the list
        lstShoeValueList.DataBind();
    }
}