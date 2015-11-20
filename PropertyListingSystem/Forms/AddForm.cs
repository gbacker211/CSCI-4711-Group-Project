
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyListingSystem.Forms
{
    public partial class AddForm : Form
    {

        private OpenFileDialog openFile = new OpenFileDialog();

        public AddForm()
        {
            InitializeComponent();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
           
            openFile.Title = "Select Image.";
            openFile.Filter = "Images only. |*.jpb; * .jpeg; * .png; *.gif;";

            DialogResult result = openFile.ShowDialog();
         
            if (result == DialogResult.OK)
            {
                txtFileName.Text = openFile.InitialDirectory.ToString() + openFile.FileName;
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
            txtFileName.Text = string.Empty;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string appPath =  Path.GetDirectoryName(Application.StartupPath.Remove(71,8)) + @"\ImageFolder\";




            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }
            if (openFile.FileName.Length > 0)
            {
                try
                {
                    string iName = openFile.SafeFileName;
                    string filepath = openFile.FileName;
                   
                    File.Copy(filepath, appPath + iName);

                }
                catch (Exception exp)
                {

                    MessageBox.Show("Unable to save file " + exp.Message);

                }
            }



            var obj = new Property()
            {
                Address = txtStreetAddress.Text,
                AgentID = 0, // Tempory until we establish agent ids
                Description = txtDescription.Text,
                NumberOfBaths = Convert.ToInt32(txtBaths.Text),
                NumberOfRooms = Convert.ToInt32(txtBeds.Text),
                Photo_Url = appPath + openFile.SafeFileName,
                Price = Convert.ToInt32(txtPrice.Text),
                State = cmbState.SelectedText,
                Zip = Convert.ToInt32(txtZip.Text) // should be a int
            };

            AddController checkIfAdd = new AddController();

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
