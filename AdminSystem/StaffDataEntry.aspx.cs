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
    Int32 StaffID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Staff to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffID != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }

    private void DisplayStaff()
    {
        //create a new instance of the Staff collection
        clsStaffCollection StaffList = new clsStaffCollection();
        //find the record to update
        StaffList.ThisStaff.Find(StaffID);
        //display the data for this record
        txtStaffID.Text = StaffList.ThisStaff.StaffID.ToString();
        txtStaffName.Text = StaffList.ThisStaff.StaffName;
        txtPosition.Text = StaffList.ThisStaff.Position;
        txtStaffSalary.Text = StaffList.ThisStaff.StaffSalary.ToString();
        txtDateJoined.Text = StaffList.ThisStaff.DateJoined.ToString();
        chkCurrentlyWorking.Checked = StaffList.ThisStaff.CurrentlyWorking;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();

        //capture the shoe id
        string StaffID = txtStaffID.Text;

        //capture the shoe description
        string ShoeDesc = txtStaffName.Text;

        //capture the shoe colour
        string Position = txtPosition.Text;

        //capture the shoe StaffSalary
        string StaffSalary = txtStaffSalary.Text;

        //capture the shoe release date
        string DateJoined = txtDateJoined.Text;

        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = AStaff.Valid(ShoeDesc, Position, StaffSalary, DateJoined);

        if (Error == "")
        {
            //capture the shoe id
            AStaff.StaffID = Convert.ToInt32(txtStaffID.Text);

            //capture the shoe description
            AStaff.StaffName = txtStaffName.Text;

            //capture the shoe colour
            AStaff.Position = txtPosition.Text;

            //capture the shoe StaffSalary
            AStaff.StaffSalary = Convert.ToInt32(txtStaffSalary.Text);

            //capture the shoe release date
            AStaff.DateJoined = Convert.ToDateTime(txtDateJoined.Text);

            //capture the shoe CurrentlyWorking
            AStaff.CurrentlyWorking = Convert.ToBoolean(chkCurrentlyWorking.Checked);

            //create a new instance of the Staff collection
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record i.e. StaffID = -1 then add the data
            if (Convert.ToInt32(txtStaffID.Text) == -1)
            {
                //set the ThisStaff property
                StaffList.ThisStaff = AStaff;
                //add the new record
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(Convert.ToInt32(txtStaffID.Text));
                //set the ThisStaff property
                StaffList.ThisStaff = AStaff;
                //update the record
                StaffList.Update();
            }
            

            //redirect back to the listpage
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //variable to store the primary key
        Int32 StaffID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = AStaff.Find(StaffID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStaffName.Text = AStaff.StaffName;
            txtPosition.Text = AStaff.Position;
            txtStaffSalary.Text = AStaff.StaffSalary.ToString();
            txtDateJoined.Text = AStaff.DateJoined.ToString();
            chkCurrentlyWorking.Checked = AStaff.CurrentlyWorking;
            lblError.Text = "";
        }
        else
        {
            txtStaffName.Text = "";
            txtPosition.Text = "";
            txtStaffSalary.Text = "";
            txtDateJoined.Text = "";
            chkCurrentlyWorking.Checked = AStaff.CurrentlyWorking;
            lblError.Text = "Error: No Staff has been found with the Shoe ID " + StaffID;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}