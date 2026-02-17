using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class harshamaPage : System.Web.UI.Page
{
    public string st = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            string fullname = Request.Form["fullname"];  //Name
            string email = Request.Form["email"];
            string password = Request.Form["password"];
            string phone = Request.Form["phone"];
            string age = Request.Form["age"];
            string player = Request.Form["player"];
            string coach = Request.Form["coach"];
            string freeText = Request.Form["freeText"];

            //בדיקת כפילות
            string sqlSelect = "SELECT * FROM tUsers WHERE email = N'" + email + "'";

            bool isExist = MyAdoHelper.IsExist(sqlSelect);
            if (isExist)
                st = "קיים";
            else
            {
                string sqlInsert = "INSERT INTO tUsers VALUES (N'"
                                    + fullname + "',N'"
                                    + email + "',N'"
                                    + password + "',N'"
                                    + phone + "',"
                                    + age + ",N'"
                                    + player + "',N'"
                                    + coach + "',N'"
                                    + freeText + "')";

                MyAdoHelper.DoQuery("MyDB.mdf", sqlInsert);

                //st = "נרשמת בהצלחה";
                Response.Redirect("HomePage.aspx");
            }    
        }

    }
}