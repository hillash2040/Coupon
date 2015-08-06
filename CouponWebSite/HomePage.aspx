<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="CouponWebSite.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1><%: Title +" "+ Session["CurrentUserName"]+ " "+ "Last Entered:"+ Session["LastEntered"] %>.</h1>

    <script>

        //gets the location of the user

        var x = document.getElementById("demo");

        function getLocation()
        {
            if (navigator.geolocation) {
                navigator.geolocation.watchPosition(showPosition);
            } else {
                x.innerHTML = "Geolocation is not supported by this browser.";
            }

            
            
        }

        function showPosition(position)
        {
            x.innerHTML = "Latitude: " + position.coords.latitude +"<br>Longitude: " + position.coords.longitude;
            

        }


    </script>

    <p>Click the button to get your coordinates.</p>

    <button onclick="getLocation()">Try It</button>

    <p id="demo"></p>


    <div> 
        <asp:TextBox runat="server" Visible="true" ID="userLatitude"></asp:TextBox>
        <asp:TextBox runat="server" Visible="true" ID="userLongitude"></asp:TextBox>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=fituxeoqua.database.windows.net;Initial Catalog=coupons;Integrated Security=False;User ID=haimi;Password=shit123!;MultipleActiveResultSets=True;Connect Timeout=60;TrustServerCertificate=False;Application Name=EntityFramework" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [Name] FROM [Category]"></asp:SqlDataSource>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="ID"></asp:DropDownList>
        <asp:Button ID="btn_CategorySelected" runat="server" Text="Update Category" OnClick="btn_CategorySelected_Click" />

        <h1> Select Reccomndation Systen</h1>
        <asp:CheckBoxList ID="CheckBoxList2" runat="server">            
            <asp:ListItem>Location</asp:ListItem>
            <asp:ListItem>Category</asp:ListItem>
            <asp:ListItem> Combined</asp:ListItem>
        </asp:CheckBoxList>

        <asp:Button ID="btn_SetRecommandation" runat="server" Text="Update Reccomandation Method"  OnClientClick="getLocation()" />
        
        
        <asp:Button ID="btn_ShowRecommandation" runat="server" Text="Show Reccomandations" OnClick="btn_ShowRecommandation_Click" />   
         <asp:GridView ID="MyCoupons" runat="server" > </asp:GridView>

        <asp:LinkButton ID="createSocialCoupon" runat="server" OnClick="createSocialCoupon_Click">Add Social Coupon</asp:LinkButton>

         
         

         
        <br /><br />  

    </div>

    <div id="CouponSearch">





    </div>


    


</asp:Content>
