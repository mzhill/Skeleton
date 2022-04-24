<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffID" runat="server" Text="Staff ID:" width="119px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;<asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblStaffName" runat="server" Text="Staff Name:" width="119px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtStaffName" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblposition" runat="server" Text="position:" width="119px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtPosition" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblstaffsalary" runat="server" Text="Staff Salary:" width="119px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtStaffSalary" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblDateJoined" runat="server" Text="Date Joined:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtDateJoined" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:CheckBox ID="chkCurrentlyWorking" runat="server" Text="CurrentlyWorking" TextAlign="Left" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <br />
        </div>
    </form>
</body>
</html>
