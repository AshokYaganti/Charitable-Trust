using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
public partial class insertdonators : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=Ashok\SQL2008; Initial Catalog=trustdb; User Id=sa; Password=srilakshmi");
    double amount1 = 0.0;
  
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                bindmemshipid();
            }
        }
        catch (Exception e1)
        {
        }
    }
    public void bindmemshipid()
    {
        try
        {
            int i = 0;
            SortedList<int, int> sl = new SortedList<int, int>();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_memshipid", con);
            cmd.CommandText = "sp_memshipid";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader[0]);
                sl.Add(++i, id);
            }
            con.Close();
            DropDownList1.DataSource = sl;
            DropDownList1.DataTextField = "value";
            DropDownList1.DataValueField = "value";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "----Select----");
        }
        catch (Exception e1)
        {
        }

    }
    protected void submit_click(object sender, EventArgs e)
    {
        try
        {
            string name = string.Empty;
            string fname = string.Empty;
            string qualification = string.Empty;
            string addr = string.Empty;
            string memshipid = DropDownList1.SelectedValue;
            string amount = TextBox1.Text;
            var regexItem = new Regex("^[0-9 ]*$");
            if (memshipid.Equals("----Select----"))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Select Membership ID')</script>", false);
            }
            else if (TextBox1.Text.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Amount')</script>", false);
            }
            else if (!(regexItem.IsMatch(amount)))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Numeric Values' )</script>", false);
            }
            else
            {

                double amount567 = Convert.ToDouble(amount);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_memdonardetails", con);
                cmd.CommandText = "sp_memdonardetails";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter memshipid1 = cmd.Parameters.Add("@memshipid", SqlDbType.VarChar, 100);
                memshipid1.Value = memshipid;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    name = Convert.ToString(reader[0]);
                    fname = Convert.ToString(reader[1]);
                    qualification = Convert.ToString(reader[2]);
                    addr = Convert.ToString(reader[3]);


                }
                con.Close();

                con.Open();
                SqlCommand cmd2 = new SqlCommand("sp_amount", con);
                cmd2.CommandText = "sp_amount";
                cmd2.CommandType = CommandType.StoredProcedure;
                SqlParameter memshipid2 = cmd2.Parameters.Add("@memshipid", SqlDbType.VarChar, 100);
                memshipid2.Value = memshipid;
                SqlDataReader reader1 = cmd2.ExecuteReader();
                while (reader1.Read())
                {
                    amount1 = Convert.ToDouble(reader1[0]);

                }
                con.Close();

                if (amount1 == 0.0)
                {

                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("sp_insdonors", con);
                    cmd1.CommandText = "sp_insdonors";
                    cmd1.CommandType = CommandType.StoredProcedure;
                    SqlParameter memshipid11 = cmd1.Parameters.Add("@memshipid", SqlDbType.VarChar, 100);
                    SqlParameter name11 = cmd1.Parameters.Add("@name", SqlDbType.VarChar, 100);
                    SqlParameter fname11 = cmd1.Parameters.Add("@fathername", SqlDbType.VarChar, 100);
                    SqlParameter qualification11 = cmd1.Parameters.Add("@qualification", SqlDbType.VarChar, 100);
                    SqlParameter amount11 = cmd1.Parameters.Add("@amount", SqlDbType.VarChar, 100);
                    SqlParameter addr11 = cmd1.Parameters.Add("@address", SqlDbType.VarChar, 100);
                    memshipid11.Value = memshipid;
                    name11.Value = name;
                    fname11.Value = fname;
                    qualification11.Value = qualification;
                    amount11.Value = amount567;
                    addr11.Value = addr;
                    int result = cmd1.ExecuteNonQuery();
                    con.Close();
                    if (result == 0)
                    {

                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Adding Failed')</script>", false);


                    }
                    else
                    {

                        ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Successfully Added');window.location='insertdonators.aspx';", true);
                        //Response.Redirect(ResolveUrl("login.aspx"));
                    }
                }
                else
                {
                    con.Open();
                    SqlCommand cmd3 = new SqlCommand("sp_updatedonors", con);
                    cmd3.CommandText = "sp_updatedonors";
                    cmd3.CommandType = CommandType.StoredProcedure;
                    SqlParameter memshipid111 = cmd3.Parameters.Add("@memshipid", SqlDbType.VarChar, 100);

                    SqlParameter amount111 = cmd3.Parameters.Add("@amount", SqlDbType.VarChar, 100);

                    memshipid111.Value = memshipid;
                    double amount123 = amount567 + amount1;
                    amount111.Value = amount123;

                    int result = cmd3.ExecuteNonQuery();
                    con.Close();
                    if (result == 0)
                    {

                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Adding Failed')</script>", false);


                    }
                    else
                    {

                        ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Successfully Added');window.location='insertdonators.aspx';", true);
                        //Response.Redirect(ResolveUrl("login.aspx"));
                    }

                }
            }
        }
        catch (Exception e1)
        {
        }
        
    }

}