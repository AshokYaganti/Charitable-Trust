using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class login : System.Web.UI.Page
{
    public SortedList<string, string> list = new SortedList<string, string>();

    SqlConnection con = new SqlConnection(@"Data Source=Ashok\SQL2008; Initial Catalog=trustdb; User Id=sa; Password=srilakshmi");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {

        }
        else { }
    }
    protected void register_click(object sender, EventArgs e)
    {
        Response.Redirect("register.aspx");

    }

    public DataSet getdetails(string userid1)
    {
        DataSet ds = new DataSet();
        try
        {

         
            SortedList<string, string> sl1 = new SortedList<string, string>();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_userdetails", con);
            cmd.CommandText = "sp_userdetails";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter userid1234 = cmd.Parameters.Add("@userid", SqlDbType.VarChar, 100);
            userid1234.Value = userid1;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();
           
        }
        catch (Exception e1)
        {
        }
        return ds;
    }

    protected void login_click(object sender, EventArgs e)
    {
        try
        {
            DataSet ds1 = new DataSet();
            string userid11 = string.Empty;
            string password11 = string.Empty;
            string userid = Request["username"];
            string password = Request["password"];
            Session["User Id"] = Request["username"];
            if (userid.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Userid')</script>", false);
            }
            else if (password.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Password')</script>", false);
            }
            else
            {
                ds1 = getdetails(userid);


                if (ds1 != null && ds1.Tables[0].Rows.Count > 0)
                {
                    userid11 = ds1.Tables[0].Rows[0]["userid"].ToString();
                    password11 = ds1.Tables[0].Rows[0]["password"].ToString();
                }


                if ((userid == userid11) && (password == password11))
                {

                    Session["loggedin"] = "created";
                    Response.Redirect("userhome.aspx");
                }
                else if ((userid == "admin123") && (password == "P@ssw0rd"))
                {
                    Session["loggedin"] = "created";
                    Response.Redirect("adminhome.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Email ID or Password incorrect')</script>", false);
                    //Response.Redirect(ResolveUrl("login.aspx"));
                }
            }
        }
        catch (Exception e1)
        {
        }


    }
}