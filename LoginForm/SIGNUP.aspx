<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="SIGNUP.aspx.cs" Inherits="LoginForm.SIGNUP" %>

      <asp:Content ID="contentHead" runat="server" ContentPlaceHolderID="head"></asp:Content>
    <asp:Content ID="logIn" runat="server" ContentPlaceHolderID="ContentPlaceHolder">
                    <header>
                        <h1 align="center">
                            WELCOME TO PRIYA HOSPITAL
                        </h1>
                     </header>

    <div>
            <table class="SignUp" align="Center" >  
                <tr>  
                    <td>Name :</td>  
                    <td>  
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox >  
                        <asp:RequiredFieldValidator ID="Name" runat="server" ControlToValidate="txtName" ErrorMessage="Name is required" Style="color: red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="validateName" runat="server" ControlToValidate="txtName" ErrorMessage="Enter valid name" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
                    </td>  
                    
               </tr>  
                <tr>  
                    <td>Patient Gender</td>  
                    <td>  
                        <asp:RadioButtonList ID="txtGender" runat="server">  
                            <asp:ListItem>Male</asp:ListItem>  
                            <asp:ListItem>Female</asp:ListItem>  
                        </asp:RadioButtonList>  
                        <asp:RequiredFieldValidator ID="requiredValidator" runat="server" ControlToValidate="txtGender" ErrorMessage="*" Style="color: red"></asp:RequiredFieldValidator>
                    </td>  
               </tr>  
               <tr>  
                    <td>DOB:</td>  
                    <td>  
                        <asp:TextBox ID="txtDOB" runat="server" TextMode="Date"></asp:TextBox >  
                        <asp:RequiredFieldValidator ID="validateDOB" runat="server" ControlToValidate="txtDOB" ErrorMessage="*" Style="color: red"></asp:RequiredFieldValidator>
                    </td>   
               </tr>  
               <tr>  
                    <td>Blood Group :</td>  
                    <td>  
                        <asp:TextBox ID="txtBloodGroup" runat="server"></asp:TextBox >  
                        <asp:RequiredFieldValidator ID="bloodGroupValidator" runat="server" ControlToValidate="txtBloodGroup" ErrorMessage="blood group is required" Style="color: red"></asp:RequiredFieldValidator>
                    </td>  
                   </tr>
                 <tr>  
                    <td>Mobile Number:</td>  
                    <td>  
                        <asp:TextBox ID="txtNumber" runat="server" TextMode="Phone"></asp:TextBox >  
                         <asp:RequiredFieldValidator ID="validateMobileNumber" runat="server" ControlToValidate="txtNumber" ErrorMessage="*" Style="color: red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="MobileNumber" runat="server" ControlToValidate="txtNumber" ErrorMessage="Enter valid mobile number" ValidationExpression="^[6789]\d{9}$"></asp:RegularExpressionValidator>
                    </td>  
               </tr>    
              <tr>  
                    <td>Password</td>  
                     <td> <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>  
                    <asp:RequiredFieldValidator ID="passwordValidator" runat="server" ControlToValidate="txtPassword" ErrorMessage="*" Style="color: red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="validate" runat="server" ControlToValidate="txtPassword" ErrorMessage="password must contain atleast 6 characters,including UPPER/lowercase letters" ValidationExpression="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,}" Style="color: red"></asp:RegularExpressionValidator>
                </td>
             </tr>  
                <tr>
                    <td>Confirm Password</td>  
                    <td>  
                        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>  
                         <asp:RequiredFieldValidator runat="server" ID="cofirmPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="*" style="color:red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator runat="server" ID="validatePassword" ControlToValidate="txtConfirmPassword" ControlToCompare="txtPassword" ErrorMessage="Password and Confirm password must be same"></asp:CompareValidator>

                    </td>  

                </tr>  
                <tr>  
                    <td>Gmail</td>  
                    <td>  
                        <asp:TextBox ID="txtEmailID" runat="server" TextMode="Email"></asp:TextBox>  
                         <asp:RequiredFieldValidator ID="validateMailId" runat="server" ControlToValidate="txtEmailID" ErrorMessage="*" Style="color: red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="mailId" runat="server" ControlToValidate="txtEmailID" ErrorMessage="Enter valid mail id" ValidationExpression="^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$"></asp:RegularExpressionValidator>
                    </td>  
               </tr>  
                    <tr>  
                    <td>Address</td>  
                    <td>  
                        <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>  
                        <asp:RequiredFieldValidator ID="fieldValidator" runat="server" ControlToValidate="txtLocation" ErrorMessage="*" Style="color: red"></asp:RequiredFieldValidator>
                    </td>  
                </tr>  
               
                <tr>  
                    <td>  
                        <asp:Button ID="signup" runat="server" Text="Signup" OnClick="Signup"/>  
                    </td>  
                </tr>  
                  
            </table>
    </div>
        </asp:Content>
