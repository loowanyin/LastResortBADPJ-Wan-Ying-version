<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="FAQ.aspx.cs" Inherits="LastResortBADPJ.FAQ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h4>You have received some FAQ, please answer it</h4>
<p>
    <asp:GridView ID="gv_FAQ" runat="server" OnSelectedIndexChanged="gvFAQ_SelectedIndexChanged" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="FAQ_ID" HeaderText="FAQ ID" />
            <asp:BoundField DataField="FAQ_Gender" HeaderText="FAQ Gender" />
            <asp:BoundField DataField="FAQ_Email" HeaderText="FAQ Email" />
            <asp:BoundField DataField="FAQ_PhoneNumber" HeaderText="FAQ Phone Number" />
            <asp:BoundField DataField="FAQ_Question" HeaderText="FAQ Question" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
</p>
</asp:Content>