﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class donators : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=Ashok\SQL2008; Initial Catalog=trustdb; User Id=sa; Password=srilakshmi");
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DataSet ds = new DataSet();

            con.Open();
            SqlCommand cmd = new SqlCommand("sp_donators", con);
            cmd.CommandText = "sp_donators";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        catch (Exception e1)
        {
        }
    }
}