<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddPage.aspx.cs" Inherits="AddPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <h2>ריאל מדריד</h2>

    <form runat="server" method="post">
        גיל:
        <input type="number" name="Age" id="Age" />
        <br />
        תאריך הצטרפות:
        <input type="text" name="JoinDate" id="JoinDate" />
        <br />
        לאום:
        <input type="text" name="Nationality" id="Nationality" />
        <br />
        גובה:
        <input type="number" name="Height" id="Height" />
        <br />
        עמדה:
        <input type="text" name="Position" id="Position" />
        <br />
        מספר חולצה:
        <input type="number" name="ShirtNumber" id="ShirtNumber" />
        <br />
        רגל חזקה:
        <input type="text" name="StrongFoot" id="StrongFoot" />
        <br />

        <input type="submit" value="שלח" />
    </form>
    <%=st %>
</asp:Content>
