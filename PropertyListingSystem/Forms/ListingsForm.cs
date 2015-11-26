using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyListingSystem;


/// <summary>
///     Class ListingsForm displays when User is logged into the system.
/// </summary>
namespace PropertyListingSystem
{
    public partial class ListingsForm : Form
    {
        // class User and Property (List of Objects), and variables 
        User mAUser;
        List<Listing> mAgentsProperties;

        private string _username;
        private string _password;


        public ListingsForm(User aUser, List<Listing> aAgentsProps, string username, string passord)
        {
            InitializeComponent();
            mAUser = aUser;
            mAgentsProperties = aAgentsProps;

            dgvListingsFormView.DataSource = mAgentsProperties;

            dgvListingsFormView.AutoGenerateColumns = false;

            _username = username;
            _password = passord;


        }

        

        /// <summary>
        ///     Displays Class AddForm 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            AddController aNewAdd = new AddController();
            aNewAdd.Open(mAUser.Agent_ID, _username, _password);
            this.Close();
        }

        /// <summary>
        ///     Closes the ListingsForm and displays the SearchForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogout_Click(object sender, EventArgs e)
        {
          
            LogoutController.Logout(this);
        }

        private void dgvListingsFormView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }


}
