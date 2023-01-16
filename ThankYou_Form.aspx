<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThankYou_Form.aspx.cs" Inherits="LastResortBADPJ.ThankYou_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h2>Thank you for your questions!</h2>
            <p>
                We have received your information and question:</p>
            <p>
                Gender:
                <asp:Label ID="lbl_Gender" runat="server" Text="[lbl_Gender]"></asp:Label>
            </p>
            <p>
                Email:
                <asp:Label ID="lbl_Email" runat="server" Text="[lbl_Email]"></asp:Label>
            </p>
            <p>
                Phone Number:
                <asp:Label ID="lbl_PhoneNumber" runat="server" Text="[lbl_PhoneNumber]"></asp:Label>
            </p>
            <p>
                Your Question:
                <asp:Label ID="lbl_YourQuestion" runat="server" Text="[lbl_YourQuestion]"></asp:Label>
            </p>
            <p>
                We will get back to you shortly! <p>
                <asp:Button ID="Button1" runat="server" OnClick="btnBack_Click" Text="Back" />
            </p>
        </div>
    </form>
</body>
</html>
