<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="managementPage.aspx.cs" Inherits="managementPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="register-container">
    <h2>מנהל לאתר של ריאל מדריד</h2>

    <form name="formPage" method="post" runat="server">

        שם מלא:
        <input type="text" name="fullname" placeholder="הכנס שם מלא" />
                <br />
        שחקן אהוב:
        <br />
        כריסטיאנו רונאלדו <input type="radio" name="player" value="כריסטיאנו רונאלדו" /><br />
        זינדין זידאן <input type="radio" name="player" value="זינדין זידאן" /><br />
        לוקה מודריץ <input type="radio" name="player" value="לוקה מודריץ" /><br />
        קיליאן אמבפה <input type="radio" name="player" value="קיליאן אמבפה" /><br /><br />

       


        <input type="submit" value="שלוף" />
    </form>
</div>

<%=st %>

</asp:Content>

