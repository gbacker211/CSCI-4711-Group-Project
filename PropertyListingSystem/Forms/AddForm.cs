
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyListingSystem.Forms
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.InitialDirectory.ToString() + openFileDialog1.FileName;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFileName.Text = string.Empty;
            txtBaths.Text = string.Empty;
            txtBeds.Text = String.Empty;
            txtCity.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtPrice.Text = String.Empty;
            txtStreetAddress.Text = string.Empty;
            txtZip.Text = String.Empty;
            cmbState.SelectedIndex = 0;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var obj = new Property()
            {
                Address =  txtStreetAddress.Text,
                AgentID =  0, // Tempory until we establish agent ids
                Description = txtDescription.Text,
                NumberOfBaths = Convert.ToInt32(txtBaths.Text),
                NumberOfRooms = Convert.ToInt32(txtBeds.Text),
                Photo_Url = txtFileName.Text,
                Price = Convert.ToInt32(txtPrice.Text),
                State = cmbState.SelectedText,
                Zip = txtZip.Text
            };

            PropertListingController checkIfAdd = new PropertListingController();

            if (checkIfAdd.AddNewProperty(obj))
            {
                //Display succuss and return to Search

                DialogResult dr = MessageBox.Show("Property has been successfully", "Success", MessageBoxButtons.OK);

                if (dr == DialogResult.OK)
                {
                    Close();
                }
            }
            else
            {
                //Diplay error message
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK);
            }

            //Clear txt fields

            btnClear_Click(sender, e);

        }
    }
}
