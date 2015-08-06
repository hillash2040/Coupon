<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateCouponAdmin.aspx.cs" Inherits="CouponWebSite.CreateCouponAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div id ="div_coupon">
        <fieldset>
            <ol>
                <li>
                    <asp:Label runat="server" >Category</asp:Label>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=fituxeoqua.database.windows.net;Initial Catalog=coupons;Integrated Security=False;User ID=haimi;Password=shit123!;MultipleActiveResultSets=True;Connect Timeout=60;TrustServerCertificate=False;Application Name=EntityFramework" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [Name] FROM [Category]"></asp:SqlDataSource>
                      <asp:DropDownList ID="category_dropDownList" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="ID"></asp:DropDownList>
                </li>
                <li>
                    <asp:Label ID="Label8" runat="server" AssociatedControlID="description">Description</asp:Label>
                     <asp:TextBox runat="server" ID="description" TextMode="MultiLine" />
                </li>
                <li>
                    <asp:Label ID="Label1" runat="server" AssociatedControlID="name_txt">Name</asp:Label>
                     <asp:TextBox runat="server" ID="name_txt"  />
                </li>
                <asp:Label runat="server">Type:</asp:Label>
                    <asp:DropDownList ID="couponType_dropDownList" runat="server">
                        <asp:ListItem>Social Network</asp:ListItem>
                        <asp:ListItem>Regular</asp:ListItem>
                    </asp:DropDownList>
                 <li>
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
                <li>
                     <asp:Label ID="Label5" runat="server" AssociatedControlID="business_dropDownList">Business</asp:Label>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=fituxeoqua.database.windows.net;Initial Catalog=coupons;Integrated Security=False;User ID=haimi;Password=shit123!;MultipleActiveResultSets=True;Connect Timeout=60;TrustServerCertificate=False;Application Name=EntityFramework" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Business]"></asp:SqlDataSource>
                    <asp:DropDownList ID="business_dropDownList" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="ID"></asp:DropDownList>
                </li>
              
                <li>
                    <asp:Button runat="server" ID="createCoupon" Text="Create Coupon" OnClick="createCoupon_Click" />
                </li>

                
            </ol>


        </fieldset>

            </div>

</asp:Content>
