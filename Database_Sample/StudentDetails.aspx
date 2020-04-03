<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentDetails.aspx.cs" Inherits="WebApplication1.StudentDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
            <asp:Button ID="BtnGetDataFromDB" runat="server" Text="Get Data From Database" OnClick="BtnGetDataFromDB_Click" />
            <asp:GridView ID="StudentGridView" runat="Server" AutoGenerateColumns="False" DataKeyNames="Id" OnRowCancelingEdit="StudentGridView_RowCancelingEdit" OnRowDeleting="StudentGridView_RowDeleting" OnRowEditing="StudentGridView_RowEditing" OnRowUpdating="StudentGridView_RowUpdating" >
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="FirstName" HeaderText="First Name" SortExpression="FirstName" />
                     <asp:BoundField DataField="LastName" HeaderText="Last Name" SortExpression="LastName" />
                    <asp:CheckBoxField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                    <asp:BoundField DataField="TotalMarks" HeaderText="TotalMarks" SortExpression="TotalMarks" />
                </Columns>
            </asp:GridView>
     <asp:Button ID="BtnUpdateDB" runat="server" Text="Update Database Table" />
          <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </div>
               
 </asp:Content>