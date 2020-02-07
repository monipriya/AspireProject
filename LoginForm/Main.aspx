<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="LoginForm.Main" %>
<asp:Content ID="Master" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="MasterPage" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <header>
        <h1 align="Center">
            <b>
                <i>
                    Online Healthcare Management System
                </i>
            </b>
        </h1>
    </header>
    <asp:GridView ID="CustomerGridView" runat="server" AutoGenerateColumns="false" DataKeyNames="UserID">
        <Columns>
            <asp:TemplateField>
                <asp:BoundField DataField="UserID" 
                    HeaderText="User Id" 
                    readonly="true"/>
                <ItemTemplate>
                    <asp:Label ID="Name" runat="server">
                    </asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="userName" runat="server" CommandArgument="<%eval("txtName") %>" />
                </EditItemTemplate>
            </asp:TemplateField>
            <
            
        </Columns>
    </asp:GridView>
</asp:Content>
