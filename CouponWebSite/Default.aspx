<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CouponWebSite.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h1> Welcome to our Coupon System!. Please Log in or Register if you don't have an account. Take a look at our cheapest Coupons:</h1>
     <div>
         
         <asp:GridView ID="NewCoupons" runat="server">
             <Columns>     

                 
                 <asp:BoundField HeaderText="Book" DataField="Name" />
                 <asp:BoundField HeaderText="Price" DataField="DiscountPrice" />                

             </Columns>
         </asp:GridView>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=gq02gci5cs.database.windows.net;Initial Catalog=BookStore;User ID=BooksServer;Password=tiMT2gca;MultipleActiveResultSets=True;Application Name=EntityFramework" ProviderName="System.Data.SqlClient" SelectCommand="SELECT Books.Name, Categories.CategoryName, Books.Price FROM Authors INNER JOIN Books ON Authors.authorID = Books.AuthorID INNER JOIN BookCategories ON Books.BookID = BookCategories.BookID INNER JOIN Categories ON BookCategories.CategoryID = Categories.CategoryID"></asp:SqlDataSource>
         
         

    </div>
    


</asp:Content>
