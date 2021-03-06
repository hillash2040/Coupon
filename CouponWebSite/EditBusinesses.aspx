﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditBusinesses.aspx.cs" Inherits="CouponWebSite.EditBusinesses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=fituxeoqua.database.windows.net;Initial Catalog=coupons;Integrated Security=False;User ID=haimi;Password=shit123!;MultipleActiveResultSets=True;Connect Timeout=60;TrustServerCertificate=False;Application Name=EntityFramework" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [Name], [Address], [City], [ID] ,[Description] FROM [Coupon]"></asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand" DataKeyNames="ID">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField HeaderText="Name" DataField="Name" SortExpression="Name" />
            <asp:BoundField HeaderText="Description" DataField="Description" SortExpression="Description" />
            <asp:BoundField HeaderText="City" DataField="City" SortExpression="City" />
            <asp:BoundField HeaderText="Address" DataField="Address" SortExpression="Address" />
            <asp:ButtonField CommandName="Edit" Text="Edit" />
            <asp:ButtonField CommandName="Delete" Text="Delete" />
            <asp:CommandField DeleteText="Delete" ShowDeleteButton="True"></asp:CommandField>
        </Columns>
    </asp:GridView>


        <div id="editBusinessDiv" runat="server" visible="false" >
        <asp:Label ID="Label1" runat="server" Text="Edit Selected Business"></asp:Label>
        <fieldset>
            <ol>
                <li>
                    <asp:Label ID="Label6" runat="server" Text="ID:"></asp:Label>
                </li>
                <li>
                    <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
                <asp:TextBox ID="txt_Name" runat="server"></asp:TextBox>
                </li>

                <li>
                     <asp:Label ID="Label3" runat="server" Text="Description:"></asp:Label>
                <asp:TextBox ID="txt_Description" runat="server"></asp:TextBox>
                </li>

                <li>
                     <asp:Label ID="Label4" runat="server" Text="City:"></asp:Label>
                <asp:TextBox ID="txt_City" runat="server"></asp:TextBox>
                </li>

                <li>
                     <asp:Label ID="Label5" runat="server" Text="Address:"></asp:Label>
                <asp:TextBox ID="txt_Address" runat="server"></asp:TextBox>
                </li>

                <li>
                    <asp:Button ID="submit_edit" runat="server" Text="Save changes" OnClick="submit_edit_Click" />
                </li>

            </ol>
        </fieldset>

        

    </div>
</asp:Content>
