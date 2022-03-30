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

    protected void chkCurrentlyWorking_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        AStaff.StaffName = txtStaffName.Text;
        AStaff.Position = txtPosition.Text;
        AStaff.StaffTel = Convert.ToInt32(txtStaffTel.Text);
        AStaff.DateJoined = Convert.ToDateTime(txtDateJoined.Text);
        AStaff.CurrentlyWorking = Convert.ToBoolean(txtCurrentlyWorking.Checked);
        AStaff.StaffSalary = Convert.ToInt32(txtStaffSalary.Text);
        Session["AStaff"] = AStaff;
        Response.Redirect("StaffViewer.aspx");
    }
    protected void btnFind_Click(object sender, EventArgs e)
    {

        clsStock AStaff = new clsStaff();
        //variable to store the primary key
        Int32 StaffID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = AStaff.Find(Staff);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStaffName.Text = AStaff.StaffName;
            txtPosition.Text = AStaff.Position;
            txtStaffTel.Text = AStaff.StaffTel.ToString();
            txtDateJoined.Text = AStaff.DateJoined;
            chkCurrentlyWorking.Checked = AStaff.CurrentlyWorking;
            txtStaffSalary.Text = AStaff.StaffSalary;
            lblError.Text = "";
        }
        else
        {
            txtStaffName.Text = "--";
            txtPosition.Text = "--";
            txtStaffTel.Text = "--";
            txtDateJoined.Text = "--";
            chkCurrentlyWorking.Checked = AStaff.CurrentlyWorking;
            lblError.Text = "Error: No staff has been found with the Staff ID " + StaffID;
        }
    }

    



    protected void Button1_Click(object sender, EventArgs e)
    {

        clsStock AStaff = new clsStaff();
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
            txtStaffTel.Text = AStaff.StaffTel.ToString();
            txtDateJoined.Text = AStaff.DateJoined;
            chkCurrentlyWorking.Checked = AStaff.CurrentlyWorking;
            txtStaffSalary.Text = AStaff.StaffSalary;
            lblError.Text = "";
        }
        else
        {
            txtStaffName.Text = "--";
            txtPosition.Text = "--";
            txtStaffTel.Text = "--";
            txtDateJoined.Text = "--";
            chkCurrentlyWorking.Checked = AStaff.CurrentlyWorking;
            lblError.Text = "Error: No staff has been found with the Staff ID " + StaffID;
        }
    }
}