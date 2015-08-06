<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BusinessManagerHomePage.aspx.cs" Inherits="CouponWebSite.BusinessManagerHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1> Welcome to the business mamnager's Page</h1>

    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Create New Coupon</asp:LinkButton>
    <asp:LinkButton ID="LinkButton2" runat="server">Edit Coupons</asp:LinkButton>
    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Add Businesses</asp:LinkButton>
</asp:Content>
