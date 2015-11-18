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

namespace PropertyListingSystem.Forms
{
    public partial class ResultsForm : Form
    {
        SqlConnection con;
        //SqlDataAdapter adap;
        DataSet ds;


        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection();
                con.ConnectionString =
                    System.Configuration.ConfigurationManager.ConnectionStrings["PropertyListingsDBConnectionString"]
                        .ConnectionString;
                con.Open();

            }
            catch
            {
                MessageBox.Show("Error with the data grid");
            }



        }

        private void dataGridResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
