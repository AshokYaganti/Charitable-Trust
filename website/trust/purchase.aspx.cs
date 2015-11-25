using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class purchase : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    DataSet ds1 = new DataSet();
    SqlConnection con = new SqlConnection(@"Data Source=Ashok\SQL2008; Initial Catalog=trustdb; User Id=sa; Password=srilakshmi");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string value = DropDownList1.SelectedValue;
            if (value == "0")
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Select Category')</script>", false);
            }
            else if (value == "item")
            {
                binditem();
            }
            else
            {
                bindcandidate();
            }
        }
        catch (Exception e1)
        {
        }
    }
    public void binditem()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_itemdetails", con);
            cmd.CommandText = "sp_itemdetails";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();
            GridView1.Visible = true;
            GridView1.DataSource = ds;
            GridView1.DataBind();
            GridView2.Visible = false;
        }
        catch (Exception e1)
        {
        }
    }

    public void bindcandidate()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_stddetails", con);
            cmd.CommandText = "sp_stddetails";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds1);
            con.Close();
            GridView2.Visible = true;
            GridView2.DataSource = ds1;
            GridView2.DataBind();
            GridView1.Visible = false;
        }
        catch (Exception e1)
        {
        }
    }

}