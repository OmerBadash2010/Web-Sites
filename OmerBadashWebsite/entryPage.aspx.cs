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
                Session["userName"] = "Admin";
                Response.Redirect("managementPage.aspx");
            }
            else
            {
                string sqlSelect = "SELECT * FROM tUsers WHERE email = N'"
                                    + email + "' AND password = N'"
                                    + password + "'";

                bool isExist = MyAdoHelper.IsExist(sqlSelect);

                if (isExist)
                {
                    Session["userName"] = "User";
                    Response.Redirect("HomePage.aspx");
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