
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyListingSystem
{
    public partial class AddForm : Form
    {

        private OpenFileDialog openFile = new OpenFileDialog();

        

        public AddForm(int AgentID)
        {
            InitializeComponent();
            lblAgentID.Text = AgentID.ToString();
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
            cmdBaths.SelectedIndex = 0;
            cmdBeds.SelectedIndex = 0;
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

                 
                    File.Copy(filepath, appPath + iName, true);
                   
                }
                catch (Exception exp)
                {

                    MessageBox.Show("Unable to save file " + exp.Message);
                    //Remove folder to prevent conflicts
                    File.Delete(appPath);

                }
            }
             decimal number;
          



                var obj = new Property()
                {
                    Address = txtStreetAddress.Text,
                    AgentID = Convert.ToInt32(lblAgentID.Text), // Tempory until we establish agent ids
                    City = txtCity.Text,
                    Description = txtDescription.Text,
                    NumberOfBaths = Convert.ToInt32(cmdBaths.SelectedItem), //Convert these into combo boxes
                    NumberOfRooms = Convert.ToInt32(cmdBeds.SelectedItem), //Convert these into combo boxes
                    Photo_Url = appPath + openFile.SafeFileName,
                    Price =  Convert.ToDecimal(txtPrice.Text),
                    State = cmbState.SelectedItem.ToString(),
                    Zip = txtZip.Text
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
