using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
public partial class studentdetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=Ashok\SQL2008; Initial Catalog=trustdb; User Id=sa; Password=srilakshmi");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string name = TextBox1.Text;
            string fathername = TextBox2.Text;
            string dob = TextBox3.Text;
            string school = TextBox4.Text;
            string amount = TextBox5.Text;
            string year = TextBox6.Text;
            string address = TextBox7.Text;
            var regexItem = new Regex("^[0-9 ]*$");
            if (name.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Name' )</script>", false);

            }
            else if (regexItem.IsMatch(name))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Enter Name in Alphabets' )</script>", false);
            }
            else if (fathername.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Father Name' )</script>", false);

            }
            else if (regexItem.IsMatch(fathername))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Enter Father name in Alphabets' )</script>", false);
            }
            else if (dob.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Date of Birth' )</script>", false);

            }
            //else if (!(regexItem.IsMatch(dob)))
            //{
            //    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Enter DOB in dd-mm-yyyy format' )</script>", false);
            //}
            if (school.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter School Name' )</script>", false);

            }
            else if (regexItem.IsMatch(school))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Enter School Name in Alphabets' )</script>", false);
            }
            else if (amount.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Amount' )</script>", false);

            }
            else if (!(regexItem.IsMatch(amount)))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Enter amount in Numericss' )</script>", false);
            }
            else if (year.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Year' )</script>", false);

            }
            else if (!(regexItem.IsMatch(year)))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Enter Year in Numericss' )</script>", false);
            }
            else if (address.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Address' )</script>", false);

            }
            else
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_insstudents", con);
                cmd.CommandText = "sp_insstudents";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter name1 = cmd.Parameters.Add("@stdname", SqlDbType.VarChar, 100);
                SqlParameter fname1 = cmd.Parameters.Add("@stdfathername", SqlDbType.VarChar, 100);
                SqlParameter dob1 = cmd.Parameters.Add("@dob", SqlDbType.VarChar, 100);
                SqlParameter school1 = cmd.Parameters.Add("@school", SqlDbType.VarChar, 100);
                SqlParameter amount1 = cmd.Parameters.Add("@amount", SqlDbType.VarChar, 100);
                SqlParameter year1 = cmd.Parameters.Add("@year", SqlDbType.VarChar, 100);
                SqlParameter addr1 = cmd.Parameters.Add("@address", SqlDbType.VarChar, 100);

                name1.Value = name;
                fname1.Value = fathername;
                dob1.Value = dob;
                school1.Value = school;
                amount1.Value = amount;
                year1.Value = year;
                addr1.Value = address;

                int result = cmd.ExecuteNonQuery();

                con.Close();

                if (result == 0)
                {

                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Adding Failure')</script>", false);
                    Response.Redirect(ResolveUrl("itemdetails.aspx"));

                }
                else
                {

                    ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Successfully added');window.location='studentdetails.aspx';", true);
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
  

