using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class memshipcard : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=Ashok\SQL2008; Initial Catalog=trustdb; User Id=sa; Password=srilakshmi");
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string userid = Convert.ToString(Session["User Id"]);

            con.Open();
            SqlCommand cmd = new SqlCommand("sp_profile", con);
            cmd.CommandText = "sp_profile";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter userid1 = cmd.Parameters.Add("@userid", SqlDbType.VarChar, 100);
            userid1.Value = userid;
            SqlDataReader reader = cmd.ExecuteReader();
            string memshipid = string.Empty;
            string name = string.Empty;
            string fathername = string.Empty;
            string userid123 = string.Empty;
            string qualification = string.Empty;
            string phno = string.Empty;
            string address = string.Empty;
            while (reader.Read())
            {
                memshipid = Convert.ToString(reader[0]);
                name = Convert.ToString(reader[1]);
                fathername = Convert.ToString(reader[2]);
                userid123 = Convert.ToString(reader[3]);
                qualification = Convert.ToString(reader[4]);
                phno = Convert.ToString(reader[5]);
                address = Convert.ToString(reader[6]);


            }
            con.Close();
            Label2.Text = "" + memshipid;
            Label1.Text = "" + name;
            Label3.Text = "" + fathername;


            Label4.Text = "" + phno;
            Label5.Text = "" + address;
        }
        catch (Exception e1)
        {
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("userhome.aspx");
    }
}