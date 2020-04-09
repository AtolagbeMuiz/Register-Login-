using System;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using System.Web.Security;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Register_LoginExcercise
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection sqlConn = new SqlConnection("Server=.;Database=RegisterLogin;User Id=muiz;Password=oluwadamilare;");
        HashCode hc = new HashCode();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblloginErrorMessage.Visible = false;
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            try
            {
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["RegisterLoginConnString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);

                //Open Connection String
                con.Open();

                //SqlDataReader reader = null;
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SelectLoginDetails";

                cmd.Parameters.AddWithValue("@email", txtemail.Text.Trim());
                cmd.Parameters.AddWithValue("@password", hc.PassHash(txtpassword.Text.Trim()));

                //reader = cmd.ExecuteReader();

                int codereturn = (int)cmd.ExecuteScalar();

                if (codereturn == 1)
                {
                    Response.Redirect("Home.aspx",false);
                }
                else
                {
                    this.lblloginErrorMessage.Visible = true;
                    this.lblloginErrorMessage.ForeColor = System.Drawing.Color.Red;
                    this.lblloginErrorMessage.Text = "Your Email or Password is Invalid";
                }
            }
            catch (Exception ex)
            {
                this.lblloginErrorMessage.ForeColor = System.Drawing.Color.Red;
                this.lblloginErrorMessage.Text = ex.Message;
            }

            Session["Email"] = txtemail.Text;
        }
    }
}