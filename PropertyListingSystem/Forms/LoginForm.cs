using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PropertyListingSystem;

/// <summary>
///     Class LoginForm displays when User activates the "Agent Login" button. 
/// </summary>
namespace PropertyListingSystem
{
    public partial class LoginForm : Form
    {
        LoginController aNewLogin = new LoginController();

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
            aNewLogin.subimt(txtUsername.Text,txtPassword.Text);
            this.Close();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }// END CLASS LoginForm
}
