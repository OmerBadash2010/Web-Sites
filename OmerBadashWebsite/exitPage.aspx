<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="exitPage.aspx.cs" Inherits="exitPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <%Session.Abandon();
        //Responce.Write("התנתקת");
        Response.Redirect("entryPage.aspx");
        %>
        <h2>יציאה</h2>

</asp:Content>

