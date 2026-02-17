using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class entryPage : System.Web.UI.Page
{
    public string st = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            string email = Request.Form["email"];
            string password = Request.Form["password"];

            if ((email == "N@gmail.com") && (password == "1"))
                Response.Redirect("managementPage.aspx");
            else
            {
                string sqlSelect = "SELECT * FROM tUsers WHERE email = N'"
                                    + email + "' AND password = N'"
                                    + password + "'";


                bool isExist = MyAdoHelper.IsExist(sqlSelect);

                if (isExist)
                    //st = "רשום";
                    Response.Redirect("HomePage.aspx");
                else
                    //st = "אורח";
                    st = "אינך רשום";


            }

        }
    }
}