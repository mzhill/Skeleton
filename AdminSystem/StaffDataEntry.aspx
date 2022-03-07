<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 529px">
            <asp:Label ID="lblStaffID" runat="server" Text="Staff ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblStaffName" runat="server" Text="Staff Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPosition" runat="server" Text="Position"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPosition" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblStaffTel" runat="server" Text="Staff Telephone"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffTel" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDateJoined" runat="server" Text="Date Joined"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDateJoined" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkCurrentlyWorking" runat="server" OnCheckedChanged="chkCurrentlyWorking_CheckedChanged" Text="   CurrentlyWorking" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="lblStaffSalary" runat="server" Text="StaffSalary"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffSalary" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
