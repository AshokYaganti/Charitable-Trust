using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class balance : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=Ashok\SQL2008; Initial Catalog=trustdb; User Id=sa; Password=srilakshmi");
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            double damount = 0.0;
            double samount = 0.0;
            double iamount = 0.0;
            DateTime today = DateTime.Now;
            Label1.Text = "" + today;
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_totaldonation", con);
            cmd.CommandText = "sp_totaldonation";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                damount = Convert.ToDouble(reader[0]);

            }
            con.Close();
            con.Open();
            SqlCommand cmd1 = new SqlCommand("sp_totalstdamt", con);
            cmd1.CommandText = "sp_totalstdamt";
            cmd1.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                samount = Convert.ToDouble(reader1[0]);

            }
            con.Close();
            con.Open();
            SqlCommand cmd2 = new SqlCommand("sp_totalitemamt", con);
            cmd2.CommandText = "sp_totalitemamt";
            cmd2.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                iamount = Convert.ToDouble(reader2[0]);

            }
            con.Close();

            double balance = damount - (samount + iamount);
            Label2.Text = "" + balance;
        }
        catch (Exception e1)
        {
        }

    }
}