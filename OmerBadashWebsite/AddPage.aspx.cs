using System;

public partial class AddPage : System.Web.UI.Page
{
    public string st;

    public string Age;
    public string JoinDate;
    public string Nationality;
    public string Height;
    public string Position;
    public string ShirtNumber;
    public string StrongFoot;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            Age = Request.Form["Age"];
            JoinDate = Request.Form["JoinDate"];
            Nationality = Request.Form["Nationality"];
            Height = Request.Form["Height"];
            Position = Request.Form["Position"];
            ShirtNumber = Request.Form["ShirtNumber"];
            StrongFoot = Request.Form["StrongFoot"];

            string sqlInsert =
                "INSERT INTO RealMadrid " +
                "(Age, JoinDate, Nationality, Height, Position, ShirtNumber, StrongFoot) VALUES (" +
                Age + "," +
                "'" + JoinDate + "'," +
                "N'" + Nationality + "'," +
                Height + "," +
                "N'" + Position + "'," +
                ShirtNumber + "," +
                "N'" + StrongFoot + "'" +
                ")";

            MyAdoHelper.DoQuery("myDB.mdf",sqlInsert);

            st = "ok";
        }
    }
}