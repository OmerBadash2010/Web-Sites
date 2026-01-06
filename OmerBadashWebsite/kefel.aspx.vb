Using System;
Using System.Collections.Generic;
Using System.Linq;
Using System.Web;
Using System.Web.UI;
Using System.Web.UI.WebControls;

Partial Public Class Register1 :  System.Web.UI.Page
{
    Public String str;
    Protected void Page_Load(Object sender, EventArgs e)
    {

        str = "<table border = '1'>";
        For (int i = 1; i < 11; i++)
        {
            str = str + "<tr>";
            For (int j = 1; j < 11; j++)
            {
                str = str + "<td>";
                str = str + i * j;
                str = str + "</td>";
            }
            str = str + "</tr>";
        }
        str = str + "</table>";
    }
}