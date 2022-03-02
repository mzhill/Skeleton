<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShoeValueDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 105px;
        }
    </style>
</head>
<body style="width: 1485px; height: 846px">
    <form id="IblStock" runat="server">
        <div id="chkStock" style="height: 247px">
            <asp:Label ID="lblShoeValue" runat="server" Text="Shoe"></asp:Label>
            <asp:TextBox ID="txtShoe" runat="server" OnTextChanged="Unnamed1_TextChanged" Width="110px"></asp:TextBox>
            <br />
            <asp:Label ID="IblRetailPrice" runat="server" Text="RetailPrice"></asp:Label>
            <asp:TextBox ID="txtRetailPrice" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="IblResalePrice" runat="server" Text="ResalePrice"></asp:Label>
            <asp:TextBox ID="txtResalePrice" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="IblCatergory" runat="server" Text="Catergory "></asp:Label>
            <asp:TextBox ID="txtCatergory" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="IblReleaseDate" runat="server" Text="ReleaseDate"></asp:Label>
            <asp:TextBox ID="txtReleaseDate" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Stock" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="IblError" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
