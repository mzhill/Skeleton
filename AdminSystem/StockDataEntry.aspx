<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblShoeID" runat="server" Text="Shoe ID:" width="119px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtShoeID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblShoeDesc" runat="server" Text="Shoe Description:" width="119px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtShoeDesc" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblShoeColour" runat="server" Text="Shoe Colour:" width="119px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtShoeColour" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity:" width="119px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblReleaseDate" runat="server" Text="Initial Release Date:"></asp:Label>
            &nbsp;<asp:TextBox ID="txtReleaseDate" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chkAvailability" runat="server" Text="Availability" TextAlign="Left" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <br />
        </div>
    </form>
</body>
</html>
