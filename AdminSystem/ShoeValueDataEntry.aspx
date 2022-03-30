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
        <div style="height: 314px">
            <asp:Label ID="lblShoeID" runat="server" Text="ShoeID" width="76px"></asp:Label>
            <asp:TextBox ID="txtShoeID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            <asp:Label ID="IblRetailPrice" runat="server" Text="RetailPrice" width="76px"></asp:Label>
            <asp:TextBox ID="txtRetailPrice" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="IblResalePrice" runat="server" Text="ResalePrice" width="76px"></asp:Label>
            <asp:TextBox ID="txtResalePrice" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="IblCatergory" runat="server" Text="Catergory " width="76px"></asp:Label>
            <asp:TextBox ID="txtCatergory" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="IblReleaseDate" runat="server" Text="ReleaseDate"></asp:Label>
            <asp:TextBox ID="txtReleaseDate" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:CheckBox ID="chkStock" runat="server" Text="Stock" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" style="height: 26px" />
            &nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
