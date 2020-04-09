using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Register_LoginExcercise
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection sqlConn = new SqlConnection("Server=.;Database=RegisterLogin;User Id=muiz;Password=oluwadamilare;");
        HashCode hc = new HashCode();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblsuccessmessage.Visible = false;
            this.lblerrormessage.Visible = false;
        }

        protected void RegButton_Click(object sender, EventArgs e)
        {
            Reg();
        }

        public void Reg()
        {
            try
            {
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["RegisterLoginConnString"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);

                //Open Connection String
                con.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SaveRecord";

                cmd.Parameters.AddWithValue("@fullname", txtfullname.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtemail.Text.Trim());
                cmd.Parameters.AddWithValue("@password", hc.PassHash(txtpassword.Text.Trim()));

                cmd.ExecuteNonQuery();

                this.lblsuccessmessage.Visible = true;
                this.lblsuccessmessage.ForeColor = System.Drawing.Color.LightGreen;
                this.lblsuccessmessage.Text = "Registered Sucessfully";

                con.Close();
            }
            catch (Exception ex)
            {
                this.lblerrormessage.ForeColor = System.Drawing.Color.Red;
                this.lblerrormessage.Text=ex.Message;
            }

        }
       
    }
}