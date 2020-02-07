﻿<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginForm.Login" %>

    <asp:Content ID="contentHead" runat="server" ContentPlaceHolderID="head"></asp:Content>
    <asp:Content ID="logIn" runat="server" ContentPlaceHolderID="ContentPlaceHolder">
       <header>
           <h1 align="Center">
               LOGIN YOUR ACCOUNT
           </h1>
       </header>
      <div>
            <table class="loginTable" align="Center">  
                <tr>  
                    <td>User Name :</td>  
                    <td>  
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox >  
                        <asp:RequiredFieldValidator ID="validateUserName" runat="server" ControlToValidate="txtUserName" ErrorMessage="*" Style="color: red"></asp:RequiredFieldValidator>
                    </td>  
                 </tr>  
                <tr>  
                    <td>Password</td>  
                     <td> <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="validate" runat="server" ControlToValidate="txtPassword" ErrorMessage="*" Style="color: red"></asp:RequiredFieldValidator>  
                </td>
                         </tr>  
             <tr>  
                    <td>  
                        <asp:Button ID="buttonSubmit" runat="server" Text="SignIn" OnClick="Login_BUtton" style="height: 26px" />  
                    </td>  
                 <td>  
                        <asp:Button ID="SignUp" runat="server" Text="SignUp" Onlick="SignUp" OnClick="SignUp_Click"/>  
                    </td>
                </tr>  
    </table>
    </div>
        </asp:Content>
