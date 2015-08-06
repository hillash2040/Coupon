﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminHomePage.aspx.cs" Inherits="CouponWebSite.AdminHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1> Welcome to the admin Page</h1>

    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Create New Coupon </asp:LinkButton>
    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Create New Business </asp:LinkButton>
    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">View Coupons </asp:LinkButton>


    <br />

    <div id="editCouponDiv" runat="server" visible="false" >
        <asp:Label ID="Label1" runat="server" Text="Edit Selected Coupon"></asp:Label>
        <fieldset>
            <ol>
                <li>
                    <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
                <asp:TextBox ID="txt_Name" runat="server"></asp:TextBox>
                </li>

                <li>
                     <asp:Label ID="Label3" runat="server" Text="Description:"></asp:Label>
                <asp:TextBox ID="txt_Description" runat="server"></asp:TextBox>
                </li>

                <li>
                     <asp:Label ID="Label4" runat="server" Text="OriginalPrice:"></asp:Label>
                <asp:TextBox ID="txt_OriginalPrice" runat="server"></asp:TextBox>
                </li>

                <li>
                     <asp:Label ID="Label5" runat="server" Text="DiscountPrice:"></asp:Label>
                <asp:TextBox ID="txt_DiscountPrice" runat="server"></asp:TextBox>
                </li>

                <li>
                     <asp:Label ID="Label6" runat="server" Text="Last Use Date:"></asp:Label>
                <asp:TextBox ID="txt_LastUseDate" runat="server"></asp:TextBox>
                </li>

                <li>
                     <asp:Label ID="Label7" runat="server" Text="CouponType:"></asp:Label>
                <asp:TextBox ID="txt_Type" runat="server"></asp:TextBox>
                </li>

                <li>
                    <asp:Button ID="submit_edit" runat="server" Text="Save changes" OnClick="submit_edit_Click" />
                </li>

            </ol>
        </fieldset>

        

    </div>
    



    





</asp:Content>
