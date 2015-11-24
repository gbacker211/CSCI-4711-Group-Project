using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace PropertyListingSystem.Controllers
{
    public class LoginController
    {
     


        // database connection // *** NOTE *** // THAT PATH NEEDS TO BE CHANGE FOR FINAL PRODUCT // ============================================================================================================================================================================== //
       

       private  string _connectionString = String.Empty;


     //  private LoginForm Login = new LoginForm();

       

        public void Open(Form1 currentForm1)
        {
            LoginForm Login = new LoginForm();
            Login.Show();

           // currentForm1.Hide();
        }

        public void subimt(string username, string password)
        {
            if (username == null || password == null)
            {
                MessageBox.Show("Please enter your username and/or password");
            }

            else
            {
                SqlConnection conn = new SqlConnection();
                try
                {


                    conn.ConnectionString =
                        System.Configuration.ConfigurationManager.ConnectionStrings["PropertyListingsDBConnectionString2"].ConnectionString;                  // database command
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_Get_AgentLogin", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                  

                    User aUser = new User(); // create class User to hold ID.
                    aUser.Agent_ID = Convert.ToInt32(cmd.ExecuteScalar());

                    // Check if agent's ID is correct
                    if (aUser.Agent_ID != 0)
                    {
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter();

                        // *** ADD COMMAND THAT GRABS AGENT'S ADDED PROPERTIES *** // ====================================== //
                        // call ListingsForm, and close SearchForm (Form1) and LoginForm.
                        List<Listing> aAgentsProps = new List<Listing>();

                        cmd = new SqlCommand("usp_Get_PropertySearch", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@AgentID", aUser.Agent_ID);

                        da.SelectCommand = cmd;
                        da.Fill(dt);

                       

                        dt.AsEnumerable().ToList().ForEach(dr =>

                        {
                            aAgentsProps.Add(AddPropertyToList(dr));
                        }
                            );


                      // aAgentsProps.AddRange();
                        

                       
                       // Form1.ActiveForm.Close(); // close SearchForm
                        ListingsForm AListingsForm = new ListingsForm(aUser, aAgentsProps);
                        AListingsForm.Show();
                        LoginForm.ActiveForm.Close();
                    }
                    else
                        MessageBox.Show("Your Username and/or Password is incorrect");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private Listing AddPropertyToList(DataRow row)
        {
            var ojb = new Listing()
            {
              
               Street = row["Street"].ToString(),
               Bath = Convert.ToInt32(row["Bath"].ToString()),
               Bed = Convert.ToInt32(row["Bed"].ToString()),
               City = row["City"].ToString(),
               Description = row["Description"].ToString(),
               Email = row["Email"].ToString(),
               Phone = row["PhoneNumber"].ToString(),
               State = row["State"].ToString(),
               AgentName = row["Agent"].ToString(),
               ImagePath = row["image_path"].ToString()


                
            };

            return ojb;
        }
    }
}
