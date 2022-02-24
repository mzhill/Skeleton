<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerID" runat="server" Text="CustomerID" width="120px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerForename" runat="server" Text="CustomerForename"></asp:Label>
            <asp:TextBox ID="txtCustomerForename" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerSurname" runat="server" Text="CustomerSurname" width="120px"></asp:Label>
            <asp:TextBox ID="txtCustomerSurname" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerEmail" runat="server" Text="CustomerEmail" width="120px"></asp:Label>
            <asp:TextBox ID="txtCustomerEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerTel" runat="server" Text="CustomerTel" width="120px"></asp:Label>
            <asp:TextBox ID="txtCustomerTel" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerDOB" runat="server" Text="CustomerDOB" width="120px"></asp:Label>
            <asp:TextBox ID="txtCustomerDOB" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chkCustomerMembership" runat="server" Text="CustomerMembership" TextAlign="Left" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="bntOK" runat="server" OnClick="bntOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
        </div>
    </form>
</body>
</html>
