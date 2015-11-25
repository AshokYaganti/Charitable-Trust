using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

public partial class register : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=Ashok\SQL2008; Initial Catalog=trustdb; User Id=sa; Password=srilakshmi");
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void button_click(object sender, EventArgs e)
    {
        try
        {
            string userid11 = string.Empty;
            con.Open();
            SqlCommand cmd1 = new SqlCommand("sp_useridid", con);
            cmd1.CommandText = "sp_userid";
            cmd1.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(ds);
            con.Close();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                userid11 = ds.Tables[0].Rows[i][0].ToString();
            }
            //foreach (var col in ds.Tables[0].Columns)
            //{
            //    emailid11 = ds.Tables[0].Columns[0]["emailid"].ToString();
            //}




            string fn = TextBox1.Text;
            string ln = TextBox2.Text;
            string userid = TextBox3.Text;


            string password = TextBox4.Text;
            string cpassword = TextBox5.Text;
            string qualification = TextBox9.Text;
            string secque = DropDownList2.SelectedValue;
            string answer = TextBox8.Text;
            string phno = TextBox7.Text;
            
            string addr = TextBox6.Text;
            var regexItem = new Regex("^[0-9 ]*$");
            bool pass = password.Equals(cpassword);
            bool userid123 = userid.Equals(userid11);
            if (fn.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter First Name' )</script>", false);

            }
            else if (regexItem.IsMatch(fn))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Alphabets only' )</script>", false);
            }
            else if (ln.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Last Name' )</script>", false);

            }
            else if (regexItem.IsMatch(ln))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Alphabets only' )</script>", false);
            }
            else if (userid.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter User Id' )</script>", false);

            }

            else if (userid123.Equals(true))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Userid Already Exists' )</script>", false);

            }
            else if (password.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Password' )</script>", false);

            }
            else if ((password.Length < 6) || (password.Length > 10))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Password Range should be 6-10 characters' )</script>", false);

            }
            else if (cpassword.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter confirm Password' )</script>", false);

            }

            else if (pass.Equals(false))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Check Confirm Password' )</script>", false);

            }
            else if (qualification.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Qualification' )</script>", false);

            }
            else if (secque == "0")
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Select security question' )</script>", false);

            }
            else if (answer.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Answer question' )</script>", false);

            }
            else if (phno.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Phone Number' )</script>", false);
            }
            else if (!(regexItem.IsMatch(phno)))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Numeric Values' )</script>", false);
            }
            else if ((phno.Length < 10) || (phno.Length > 10))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter 10 digit Ph.no' )</script>", false);
            }
            else if (addr.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Address' )</script>", false);

            }

            else
            {



                con.Open();

                SqlCommand cmd = new SqlCommand("sp_regmembers", con);
                cmd.CommandText = "sp_regmembers";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@memshipid", SqlDbType.Int).Direction = ParameterDirection.Output;
                SqlParameter fn1 = cmd.Parameters.Add("@fn", SqlDbType.VarChar, 100);
                SqlParameter ln1 = cmd.Parameters.Add("@ln", SqlDbType.VarChar, 100);
                SqlParameter userid1 = cmd.Parameters.Add("@userid", SqlDbType.VarChar, 100);
                SqlParameter pass1 = cmd.Parameters.Add("@password", SqlDbType.VarChar, 100);
                SqlParameter qualification1 = cmd.Parameters.Add("@qualification", SqlDbType.VarChar, 100);
                SqlParameter secque1 = cmd.Parameters.Add("@secque", SqlDbType.VarChar, 100);
                SqlParameter answer1 = cmd.Parameters.Add("@answer", SqlDbType.VarChar, 100);
                SqlParameter phno1 = cmd.Parameters.Add("@phno", SqlDbType.VarChar, 100);
                SqlParameter addr1 = cmd.Parameters.Add("@addr", SqlDbType.VarChar, 100);

                fn1.Value = fn;
                ln1.Value = ln;
                userid1.Value = userid;
                pass1.Value = password;
                qualification1.Value = qualification;
                secque1.Value = secque;
                answer1.Value = answer;
                phno1.Value = phno;
                addr1.Value = addr;

                cmd.ExecuteNonQuery();
                string result = cmd.Parameters["@memshipid"].Value.ToString();
                int result1 = Convert.ToInt32(result);
                con.Close();

                if (result1 == 0)
                {

                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Registration Failure')</script>", false);
                    Response.Redirect(ResolveUrl("register.aspx"));

                }
                else
                {
                    //ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "Alert1", "alert('" + value + "');", true);

                    //ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Membership Id is:');window.location='login.aspx';"+result1, true);
                    ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Membership Id is:'),alert('" + result1 + "');window.location='login.aspx';", true);
                    //Response.Redirect(ResolveUrl("login.aspx"));
                    //ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Registered successfully')</script>", false);



                }


            }
        }
        catch (Exception e1)
        {
        }

    }
}