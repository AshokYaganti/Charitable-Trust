using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class changepass : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=Ashok\SQL2008; Initial Catalog=trustdb; User Id=sa; Password=srilakshmi");
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string userid = Convert.ToString(Session["User Id"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_secque", con);
            cmd.CommandText = "sp_secque";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter userid1 = cmd.Parameters.Add("@userid", SqlDbType.VarChar, 100);
            userid1.Value = userid;
            SqlDataReader reader = cmd.ExecuteReader();

            string secque = string.Empty;
            string answer123 = string.Empty;
            while (reader.Read())
            {

                secque = Convert.ToString(reader[0]);
                answer123 = Convert.ToString(reader[1]);
            }
            Session["answer456"] = answer123;

            con.Close();
            TextBox3.Text = Convert.ToString(secque);
        }
        catch (Exception e1)
        {
        }
          
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            string newpassword = Convert.ToString(TextBox1.Text);
            string cpass = Convert.ToString(TextBox2.Text);
            string answer = Convert.ToString(TextBox4.Text);
            string answer789 = Convert.ToString(Session["answer456"]);
            bool pass = newpassword.Equals(cpass);
            bool ans = answer.Equals(answer789);
            if (newpassword.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter New Password' )</script>", false);

            }
            else if ((newpassword.Length < 6) || (newpassword.Length > 10))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Password Range should be 6-10 characters' )</script>", false);

            }
            else if (cpass.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter confirm Password' )</script>", false);

            }

            else if (pass.Equals(false))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Check Confirm Password' )</script>", false);

            }


            else if (answer.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Answer question' )</script>", false);

            }
            else if (ans.Equals(false))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Correct Answer' )</script>", false);

            }
            else
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_changepassword", con);
                cmd.CommandText = "sp_changepassword";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter userid1 = cmd.Parameters.Add("@userid", SqlDbType.VarChar, 100);
                SqlParameter newpass1 = cmd.Parameters.Add("@newpass", SqlDbType.VarChar, 100);
                string userid123 = Convert.ToString(Session["User Id"]);
                userid1.Value = userid123;
                newpass1.Value = newpassword;
                int result = cmd.ExecuteNonQuery();
                con.Close();

                if (result == 0)
                {

                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Registration Failure')</script>", false);
                    Response.Redirect(ResolveUrl("changepass.aspx"));

                }
                else
                {


                    ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Password Changed Successfully');window.location='changepass.aspx';", true);
                }

            }
        }
        catch (Exception e1)
        {
        }


    }
}