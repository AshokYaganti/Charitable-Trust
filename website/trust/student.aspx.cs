using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class student : System.Web.UI.Page
{
    int i = 0;
    SqlConnection con = new SqlConnection(@"Data Source=Ashok\SQL2008; Initial Catalog=trustdb; User Id=sa; Password=srilakshmi");
    protected void Page_Load(object sender, EventArgs e)
    {

        if(!IsPostBack) 
        {
            binddropdown();
        }
    }
    public void binddropdown()
    {
        try
        {

            SortedList<int, int> sl = new SortedList<int, int>();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_year", con);
            cmd.CommandText = "sp_year";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int year = Convert.ToInt32(reader[0]);
                sl.Add(++i, year);
            }
            con.Close();
            DropDownList1.DataSource = sl;
            DropDownList1.DataValueField = "value";
            DropDownList1.DataTextField = "value";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "-----select year---");
        }
        catch (Exception e1)
        {
        }

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string year = DropDownList1.SelectedValue;
            if (year.Equals("-----select year---"))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Select Year' )</script>", false);
                GridView1.Visible = false;
            }
            else
            {
                DataSet ds = new DataSet();

                con.Open();
                SqlCommand cmd = new SqlCommand("sp_students", con);
                cmd.CommandText = "sp_students";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter year1234 = cmd.Parameters.Add("@year", SqlDbType.VarChar, 100);
                year1234.Value = year;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();
                GridView1.DataSource = ds;
                GridView1.DataBind();
                GridView1.Visible = true;
            }
        }
        catch (Exception e1)
        {
        }
    }
}

