<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="WebApplication1.Student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2 id="labelRowsAffected"  runat="server"></h2>
    <asp:Label ID="lblFirstName" runat="server" Text="First Name :"></asp:Label>
    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox><br />
    <asp:Label ID="lblLastName" runat="server" Text="Last Name :"></asp:Label>
    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox><br />
    <asp:RadioButton ID="rbMale" runat="server" Text="Male" GroupName="Gender" Checked="true" />
    <asp:RadioButton ID="rbFemale" runat="server" Text="Female" GroupName="Gender" /><br />


    <asp:Label ID="lblTotalMarks" runat="server" Text="Total Marks :"></asp:Label>
    <asp:TextBox ID="txtTotalMarks" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" align="center" OnClick="btnSubmit_Click" />
</asp:Content>
