<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="entryPage.aspx.cs" Inherits="entryPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
  <div class="register-container">
      <h2>כניסה לאתר של ריאל מדריד</h2>

      <form name="formPage" method="post" runat="server">


          אימייל:
          <input type="email" name="email" placeholder="example@email.com" />

          סיסמה:
          <input type="text" name="password" placeholder="הכנס סיסמה" />

         

          <input type="submit" value="כניסה" />
      </form>
  </div>

  <%=st %>
</asp:Content>

