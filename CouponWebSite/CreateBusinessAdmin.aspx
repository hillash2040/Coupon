<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateBusinessAdmin.aspx.cs" Inherits="CouponWebSite.CreateBusinessAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <fieldset>
        <ol>
            <li>
                <asp:Label ID="lbl_name" runat="server" Text="Business Name"></asp:Label>
                <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Type Business Name" ControlToValidate="txt_name"></asp:RequiredFieldValidator>
            </li>
            <li>
                <asp:Label ID="lbl_Address" runat="server" Text="Address"></asp:Label>
                <asp:TextBox ID="txt_Address" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Type Address" ControlToValidate="txt_Address"></asp:RequiredFieldValidator>
             </li>
            <li>
                <asp:Label ID="lbl_city" runat="server" Text="City"></asp:Label>
                <asp:TextBox ID="txt_city" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Type City" ControlToValidate="txt_city"></asp:RequiredFieldValidator>
            </li>
            <li>
                <asp:Label ID="lbl_desciption" runat="server" Text="Description"></asp:Label>
                <asp:TextBox ID="txt_description" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please Type Description" ControlToValidate="txt_description"></asp:RequiredFieldValidator>
             </li>
            <li>
                <asp:Label ID="lbl_Lat" runat="server" Text="Lat Coordinate"></asp:Label>
                <asp:TextBox ID="txt_Lat" runat="server"></asp:TextBox>
            </li>

            <li>
                <asp:Label ID="lbl_long" runat="server" Text="Long Coordinate"></asp:Label>
                <asp:TextBox ID="txt_long" runat="server"></asp:TextBox>
            </li>

            <li>
                <asp:Button ID="btn_Submit" runat="server" Text="Submit" OnClick="btn_Submit_Click" />
            </li>

        </ol>




    </fieldset>


</asp:Content>
