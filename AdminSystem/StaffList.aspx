<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" Height="371px" Width="460px"></asp:ListBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        &nbsp;<asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            &nbsp;<asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblFilter" runat="server" Text="Enter a staff position: "></asp:Label>
&nbsp;&nbsp;&nbsp;
&nbsp;<asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
&nbsp;<asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>