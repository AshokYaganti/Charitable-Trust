using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class userhome : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    SqlConnection con = new SqlConnection(@"Data Source=Ashok\SQL2008; Initial Catalog=trustdb; User Id=sa; Password=srilakshmi");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        
            try
            {
                string fn = string.Empty;

                string userid = Convert.ToString(Session["User Id"]);
                con.Open();
                cmd = new SqlCommand("sp_username", con);
                cmd.CommandText = "sp_username";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter userid123 = cmd.Parameters.Add("@userid", SqlDbType.VarChar, 100);
                userid123.Value = userid;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Close();
                da.Fill(ds);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    fn = ds.Tables[0].Rows[0]["name"].ToString();
                }

                string name = fn;
                Session["username"] = name;
                Label1.Text = "welcome" + " " + "" + name;
                Label1.Visible = true;
            }
            catch (Exception e1)
            {
            }
        
    }
    

}