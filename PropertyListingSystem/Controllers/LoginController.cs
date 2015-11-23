using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Configuration; 

namespace PropertyListingSystem.Controllers
{
    public class LoginController
    {



        // database connection // *** NOTE *** // THAT PATH NEEDS TO BE CHANGE FOR FINAL PRODUCT // ============================================================================================================================================================================== //

        private  string _connectionString = String.Empty;


     //  private LoginForm Login = new LoginForm();

       

        public void Open()
        {
            LoginForm Login = new LoginForm();
            Login.Show();
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
                        System.Configuration.ConfigurationManager.ConnectionStrings["PropertyListingsDBConnectionString2"
                            ]
                            .ConnectionString;                  // database command
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_Get_AgentLogin", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);


                    User aUser = new User(); // create class User to hold ID.
                    aUser.Agent_ID = cmd.ExecuteNonQuery();

                    // Check if agent's ID is correct
                    if (aUser.Agent_ID != 0)
                    {
                        // *** ADD COMMAND THAT GRABS AGENT'S ADDED PROPERTIES *** // ====================================== //
                        // call ListingsForm, and close SearchForm (Form1) and LoginForm.
                        List<Property> aAgentsProps = new List<Property>();

                        cmd = new SqlCommand("usp_Get_PropertySearch", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@agent_ID", aUser.Agent_ID);

                        
                        ListingsForm AListingsForm = new ListingsForm(aUser, aAgentsProps);
                        AListingsForm.Show();
                        Form1.ActiveForm.Close();
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
    }
}
