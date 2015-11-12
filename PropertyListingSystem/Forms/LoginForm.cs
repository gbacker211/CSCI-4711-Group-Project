﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


/// <summary>
///     Class LoginForm displays when User activates the "Agent Login" button. 
/// </summary>
namespace PropertyListingSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Activates when User fills out their username and password.
        ///     Verifies that User is in the database and allows access 
        ///     to the ListingsForm. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == null || txtPassword.Text == null)
            {
                MessageBox.Show("You have not entered you Username or Password yet.");
            }

            //***ADD ELSE STATEMENT HERE***// ============================================ //
            else
            {
                // database connection // *** NOTE *** // THAT PATH NEEDS TO BE CHANGE FOR FINAL PRODUCT // ============================================================================================================================================================================== //
                SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\v11.0; AttachDbFilename = C:\\Users\\Christopher\\Source\\Repos\\CSCI - 4711 - Group - Project\\PropertyListingSystem\\Data\\PropertyListingsDB.mdf; Integrated Security = True; Connect Timeout = 30");

                try
                {

                    // database command
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_Get_AgentLogin", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    int ID = cmd.ExecuteNonQuery();

                    conn.Close();
                    // Check if agent's ID is correct
                    if (ID != 0)
                    {
                        // *** ADD COMMAND THAT GRABS AGENT'S ADDED PROPERTIES *** // ====================================== //
                        // call ListingsForm and close SearchForm (Form1).
                        Form1.ActiveForm.Close();
                    }
                    else
                        MessageBox.Show("Your Username and/or Password is incorrect");
                }
                finally
                {
                    conn.Close();
                }
            }// end try
        }
    }// END CLASS LoginForm
}
