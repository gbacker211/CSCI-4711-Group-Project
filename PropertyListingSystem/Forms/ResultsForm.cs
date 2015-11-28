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

namespace PropertyListingSystem
{
    public partial class ResultsForm : Form
    {
        SqlConnection con;
        //SqlDataAdapter adap;
        DataSet ds;


        public ResultsForm(List<Property> RResults)
        {
            InitializeComponent();
            dataGridResults.DataSource = RResults;

            dataGridResults.AutoGenerateColumns = false;

            dataGridResults.Columns["Price"].DefaultCellStyle.Format = "c";

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
                MessageBox.Show("Error with the conection");
            }

        }



       


        private void dataGridResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridResults_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridResults.Columns["AgentID"].Visible = false;
            dataGridResults.Columns["MaxNumberOfRooms"].Visible = false;
            dataGridResults.Columns["MinNumberOfRooms"].Visible = false;
            dataGridResults.Columns["MaxNumberOfBaths"].Visible = false;
            dataGridResults.Columns["MinNumberOfBaths"].Visible = false;
            dataGridResults.Columns["MaxPrice"].Visible = false;
            dataGridResults.Columns["MinPrice"].Visible = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
