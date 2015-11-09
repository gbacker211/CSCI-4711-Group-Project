using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
///     Class ListingsForm displays when User is logged into the system.
/// </summary>
namespace PropertyListingSystem
{
    public partial class ListingsForm : Form
    {
        public ListingsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Displays Class AddForm 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            // *** ADD CODE WHEN AddForm HAS BEEN CREATED *** // ============================== //
        }

        /// <summary>
        ///     Closes the ListingsForm and displays the SearchForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}
