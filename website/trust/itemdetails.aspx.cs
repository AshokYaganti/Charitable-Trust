using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
public partial class itemdetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=Ashok\SQL2008; Initial Catalog=trustdb; User Id=sa; Password=srilakshmi");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void button_click(object sender, EventArgs e)
    {
        try
        {
            string itemname = TextBox1.Text;
            string quantity = TextBox2.Text;
            string amount = TextBox3.Text;
            string year = TextBox4.Text;
            var regexItem = new Regex("^[0-9 ]*$");
            if (itemname.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Item Name' )</script>", false);

            }
            else if (quantity.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Quantity' )</script>", false);

            }
            else if (!(regexItem.IsMatch(quantity)))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Enter quantity in Numerics' )</script>", false);
            }
            else if (amount.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Amount' )</script>", false);

            }
            else if (!(regexItem.IsMatch(amount)))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Enter amount in Numerics' )</script>", false);
            }
            else if (year.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Year' )</script>", false);

            }
            else if (!(regexItem.IsMatch(year)))
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Enter year in Numerics' )</script>", false);
            }
            else
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_insitemdetails", con);
                cmd.CommandText = "sp_insitemdetails";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter in1 = cmd.Parameters.Add("@itemname", SqlDbType.VarChar, 100);
                SqlParameter quant1 = cmd.Parameters.Add("@quantity", SqlDbType.VarChar, 100);
                SqlParameter amt1 = cmd.Parameters.Add("@amount", SqlDbType.VarChar, 100);
                SqlParameter year1 = cmd.Parameters.Add("@year", SqlDbType.VarChar, 100);


                in1.Value = itemname;
                quant1.Value = quantity;
                amt1.Value = amount;
                year1.Value = year;


                int result = cmd.ExecuteNonQuery();

                con.Close();

                if (result == 0)
                {

                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Adding Failure')</script>", false);
                    Response.Redirect(ResolveUrl("itemdetails.aspx"));

                }
                else
                {

                    ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Successfully added');window.location='itemdetails.aspx';", true);
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