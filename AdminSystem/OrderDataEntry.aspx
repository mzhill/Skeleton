<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblOrder" runat="server" Text="Order ID"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" Text="Find" />
        <div>
            <asp:Label ID="lblCustomerUsername" runat="server" Text="Customer Username" width="57px"></asp:Label>
            <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblOrderDate" runat="server" Text="Order Date" width="57px"></asp:Label>
            <asp:TextBox ID="txtCustomerUsername" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblQuantity" runat="server" Text="Quantity" width="57px"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkNDD" runat="server" Text="Next Day Delivery" width="57px" />
        </p>
        <asp:Label ID="lblError" runat="server" Text="[lblError]" width="57px"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>