<%@ Page Title="" Language="C#" MasterPageFile="~/Guest.Master" AutoEventWireup="true" CodeBehind="FAQ.aspx.cs" Inherits="LastResortBADPJ.FAQ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .auto-style5 {
        width: 120px;
        height: 92px;
    }
    .auto-style6 {
        width: 160px;
    }
    .auto-style7 {
        width: 160px;
        height: 96px;
    }
    .auto-style8 {
        height: 96px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table class="auto-style2">
    <tr>
        <td class="auto-style7">
            <img id="img_FAQ" alt="FAQ" class="auto-style5" longdesc="https://localhost:44331/FAQ.png" src="FAQ.png" /><asp:Image ID="Image2" runat="server" />
        </td>
        <td class="auto-style8">
            <h1>Ask Us Anything!</h1>
        </td>
    </tr>
    <tr>
        <td class="auto-style6">Gender: </td>
        <td>
            <asp:RadioButtonList ID="rdl_Gender" runat="server">
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td class="auto-style6">Email:</td>
        <td>
            <asp:TextBox ID="tb_Email" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style6">Phone Number: </td>
        <td>
            <asp:TextBox ID="tb_PhoneNo" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style6">Your Question: </td>
        <td>
            <asp:TextBox ID="tb_Question" runat="server" Height="148px" Width="769px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style6">
            <asp:Button ID="btn_Submit" runat="server" OnClick="btn_Submit_Click" Text="Submit" />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
