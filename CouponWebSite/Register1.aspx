<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register1.aspx.cs" Inherits="CouponWebSite.Register1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <fieldset>
                        <legend>Registration Form</legend>
                        <ol>
                            <li>
                                <asp:Label ID="Label1" runat="server" AssociatedControlID="UserName">User name(3-8 chars)</asp:Label>                                
                                <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName" CssClass="field-validation-error" ErrorMessage="The user name field is required." />
                                <asp:RegularExpressionValidator ID="RegExp1" runat="server" ErrorMessage="UserName length must be between 3 to 8 characters and Contain only Alphabets" ControlToValidate="UserName" ValidationExpression="^[a-zA-Z]{3,8}$" CssClass="field-validation-error" />
                                <asp:Label ID="lbl_userExsits" runat="server" Visible="false"></asp:Label>
                            </li>

                            <li>
                                <asp:Label ID="Label8" runat="server" AssociatedControlID="Email">Email address</asp:Label>
                                <asp:TextBox runat="server" ID="Email" TextMode="Email" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="Email"
                                    CssClass="field-validation-error" ErrorMessage="The email address field is required." />
                                <asp:RegularExpressionValidator ID="emailPatternValidtaor" runat="server" ErrorMessage="Please write correct email" ControlToValidate="Email" ValidationExpression="\S+@\S+\.\S+" CssClass="field-validation-error"  ></asp:RegularExpressionValidator>
                            </li>
                            <li>
                                <asp:Label ID="Label9" runat="server" AssociatedControlID="Password">Password</asp:Label>
                                <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="Password"
                                    CssClass="field-validation-error" ErrorMessage="The password field is required." />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Password length must be between 5 to 10 characters" ControlToValidate="Password" ValidationExpression="^[a-zA-Z0-9'@&#.\s]{5,10}$" />
                            </li>
                            <li>
                                <asp:Label ID="Label10" runat="server" AssociatedControlID="ConfirmPassword">Confirm password</asp:Label>
                                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="ConfirmPassword"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
                            </li>
                             <li>
                                <asp:Label ID="Label13" runat="server">Admin</asp:Label>
                                 <asp:CheckBox ID="admin_checkBox" runat="server" />                         
                            </li>




                        </ol>
                        <asp:Button ID="Button1" runat="server" CommandName="Register" Text="Register" OnCommand="btnClick_RegisterUser" />
                    </fieldset>




</asp:Content>


