using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class comments : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=Ashok\SQL2008; Initial Catalog=trustdb; User Id=sa; Password=srilakshmi");
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                displaycomments();

            }
        }
        catch (Exception e1)
        {
        }
    }
    protected void post_click(object sender, EventArgs e)
    {
        try
        {

            string name = Convert.ToString(Session["username"]);
            string comment = TextBox1.Text;
            DateTime date = DateTime.Now;
            if (comment.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Comment' )</script>", false);
            }
            else
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("sp_comments", con);
                cmd1.CommandText = "sp_comments";
                cmd1.CommandType = CommandType.StoredProcedure;
                SqlParameter name123 = cmd1.Parameters.Add("@name", SqlDbType.VarChar, 100);
                SqlParameter comment123 = cmd1.Parameters.Add("@comment", SqlDbType.VarChar, 1000);
                SqlParameter date123 = cmd1.Parameters.Add("@date1", SqlDbType.DateTime);
                name123.Value = name;
                comment123.Value = comment;
                date123.Value = date;
                int res = cmd1.ExecuteNonQuery();
                con.Close();
                displaycomments();
            }
        }
        catch (Exception e1)
        {
        }
    }

    public void displaycomments()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_discomments", con);
            cmd.CommandText = "sp_discomments";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        catch (Exception e1)
        {
        }

    }



}