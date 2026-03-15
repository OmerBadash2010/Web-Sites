using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class managementPage : System.Web.UI.Page
{
    public string st = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            string fullname = Request.Form["fullname"];  //Name
            string player = Request.Form["player"];

            string sqlSelect = "SELECT * FROM tUsers" +
                " WHERE fullname LIKE N'%" + fullname + "%'" +
                " AND player = N'" + player + "'";

            DataTable dt = MyAdoHelper.ExecuteDataTable(sqlSelect);

            if (dt.Rows.Count == 0)
                st = "אין נתונים";
            else
            {
                st = "<table border = '1'>";
                st += "<tr>";
                st += "<th>שם מלא</th>";
                st += "<th>מייל</th>";
                st += "<th>סיסמה</th>";
                st += "<th>טלפון</th>";
                st += "<th>גיל</th>";
                st += "<th>שחקן אהוב</th>";
                st += "<th>מאמן אהוב</th>";
                st += "<th>מלל</th>";
                st += "</tr>";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    st = st + "<tr>";
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        st = st + "<td>";
                        st = st + dt.Rows[i][j];
                        st = st + "</td>";
                    }
                    st = st + "</tr>";
                }
                st = st + "</table>";
            }

        }
    }
}