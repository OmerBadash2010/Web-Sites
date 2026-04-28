using System;
using System.Web.UI;

public partial class entryPage : System.Web.UI.Page
{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            string email = Request.Form["email"];
            string password = Request.Form["password"];

            // Admin check
            if (email == "N@gmail.com" && password == "1")
            {
                Session["nihol"] = "ok";
                Session["userName"] = "Admin";
                Response.Redirect("managementPage.aspx");
            }
            else
            {
                string sqlSelect = "SELECT * FROM tUsers WHERE email = N'"
                                    + email + "' AND password = N'"
                                    + password + "'";
                System.Data.DataTable dt = MyAdoHelper.ExecuteDataTable(sqlSelect);

               

                if (dt.Rows.Count>0)
                {
                    Session["user"] = "ok";
                    Session["userName"] = dt.Rows[0]["fullname"];
                    Response.Redirect("HomePage.aspx");
                    Session["userName"] = "רשום";
                }
                else
                {
                    Session["userName"] = "Guest";
                    st = "אינך רשום";
                }
            }
        }
    }
}