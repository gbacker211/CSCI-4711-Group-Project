using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }// END CLASS LoginForm
}
