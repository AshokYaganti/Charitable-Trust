using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class forgot : System.Web.UI.Page
{
   
    SqlConnection con = new SqlConnection(@"Data Source=Ashok\SQL2008; Initial Catalog=trustdb; User Id=sa; Password=srilakshmi");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        try
        {
            string userid = TextBox1.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_forgotdet", con);
            cmd.CommandText = "sp_forgotdet";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter userid1 = cmd.Parameters.Add("@userid", SqlDbType.VarChar, 100);
            userid1.Value = userid;
            SqlDataReader reader = cmd.ExecuteReader();
            string password = string.Empty;
            string secque = string.Empty;
            string answer = string.Empty;
            while (reader.Read())
            {
                password = Convert.ToString(reader[0]);
                secque = Convert.ToString(reader[1]);
                answer = Convert.ToString(reader[2]);



            }
            con.Close();
            Session["answer1"] = answer;
            Session["password1"] = password;
            if (secque.Length == 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('You have given Incorrect Userid');window.location='forgot.aspx';", true);
            }
            else
            {
                TextBox2.Text = Convert.ToString(secque);
            }
        }
        catch (Exception e1)
        {
        }
    }
    protected void submit_click(object sender, EventArgs e)
    {
        try
        {
            string userid123 = TextBox1.Text;

            string answer123 = TextBox3.Text;
            if (userid123.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Userid')</script>", false);
            }
            else if (answer123.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Answer')</script>", false);
            }
            else
            {
                string answer456 = Convert.ToString(Session["answer1"]);
                string password456 = Convert.ToString(Session["password1"]);
                if (answer123 == answer456)
                {
                    Label1.Text = "" + password456;
                    Label1.Visible = true;
                    Label2.Visible = true;
                }
                else
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('You have given Incorrect Answer');window.location='forgot.aspx';", true);
                }
            }
        }
        catch (Exception e1)
        {
        }

    }
}