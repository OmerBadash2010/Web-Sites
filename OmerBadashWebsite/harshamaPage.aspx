<%@ Page Title="הרשמה לאתר של ריאל מדריד" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="hiposPage.aspx.cs" Inherits="hiposPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .register-container {
            width: 420px;
            margin: 50px auto;
            padding: 20px;
            border: 2px solid #d4af37;
            background-color: #ffffff;
            text-align: right;
            direction: rtl;
            border-radius: 10px;
        }

        .register-container h2 {
            text-align: center;
            color: #000;
        }

        .register-container input,
        .register-container select,
        .register-container textarea {
            width: 100%;
            margin-bottom: 10px;
        }

        .register-container input[type=checkbox],
        .register-container input[type=radio] {
            width: auto;
        }

        .register-container input[type=submit] {
            background-color: #d4af37;
            border: none;
            padding: 10px;
            font-weight: bold;
            cursor: pointer;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <div class="register-container">
        <h2>הרשמה לאתר של ריאל מדריד</h2>

        <form name="formPage" method="post" runat="server">

            שם מלא:
            <input type="text" name="fullname" placeholder="הכנס שם מלא" />

            אימייל:
            <input type="email" name="email" placeholder="example@email.com" />

            סיסמה:
            <input type="text" name="password" placeholder="הכנס סיסמה" />

            מספר טלפון:
            <input type="tel" name="phone" placeholder="050-0000000" />

            גיל:
            <select name="age">
                <option value="0">בחר גיל</option>
                <option value="under15"><15</option>
                <option value="15">15</option>
                <option value="16">16</option>
                <option value="17">17</option>
                <option value="18+">18+</option>
            </select>

            שחקן אהוב:
            <br />
            כריסטיאנו רונאלדו <input type="radio" name="player" value="כריסטיאנו רונאלדו" /><br />
            זינדין זידאן <input type="radio" name="player" value="זינדין זידאן" /><br />
            לוקה מודריץ <input type="radio" name="player" value="לוקה מודריץ" /><br />
            קיליאן אמבפה <input type="radio" name="player" value="קיליאן אמבפה" /><br /><br />

            מאמן אהוב:
            <br />
            זינדין זידאן <input type="radio" name="coach" value="זינדין זידאן" /><br />
            קרלו אנצ'לוטי <input type="radio" name="coach" value="קרלו אנצ'לוטי" /><br />
            ז'וזה מוריניו <input type="radio" name="coach" value="ז'וזה מוריניו" /><br /><br />

            מלל חופשי:
            <textarea rows="4" name="freeText" placeholder="כתוב כאן..."></textarea>

            <input type="submit" value="הרשמה" />
        </form>
    </div>

</asp:Content>
