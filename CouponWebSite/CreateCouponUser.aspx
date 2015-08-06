<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateCouponUser.aspx.cs" Inherits="CouponWebSite.CreateCouponUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <fieldset>
            <ol>
                <li>
                    <asp:Label runat="server" >Category</asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Food</asp:ListItem>
                        <asp:ListItem>Family</asp:ListItem>
                    </asp:DropDownList>
                </li>
                <li>
                    <asp:Label ID="Label8" runat="server" AssociatedControlID="description">Description</asp:Label>
                     <asp:TextBox runat="server" ID="description" TextMode="MultiLine" />
                </li>
                <li>
                    <asp:Label ID="Label1" runat="server" AssociatedControlID="name_txt">Name</asp:Label>
                     <asp:TextBox runat="server" ID="name_txt"  />

                    <asp:Label ID="Label2" runat="server" AssociatedControlID="org_price">Original Price</asp:Label>
                     <asp:TextBox runat="server" ID="org_price" TextMode="Number" />
                </li>
                 <li>
                    <asp:Label ID="Label3" runat="server" AssociatedControlID="dis_price">Discount Price</asp:Label>
                     <asp:TextBox runat="server" ID="dis_price" TextMode="Number"  />
                </li>
                 <li>
                    <asp:Label ID="Label4" runat="server" AssociatedControlID="last_Use">Last Use Date</asp:Label>
                     <asp:TextBox runat="server" ID="last_Use" TextMode="DateTime"  />
                </li>

                
            </ol>

         <asp:Button runat="server" ID="btn_coupon" OnClick="btn_coupon_Click" Text="Create Coupon" />

        </fieldset>

</asp:Content>
