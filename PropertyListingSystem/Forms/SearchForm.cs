using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyListing;

namespace PropertyListingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            

            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_state.Text = combo_state.SelectedValue.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combo_state.Items.Add("AK");
            combo_state.Items.Add("AL");
            combo_state.Items.Add("AZ");
            combo_state.Items.Add("AR");
            combo_state.Items.Add("CA");
            combo_state.Items.Add("CO");
            combo_state.Items.Add("CT");
            combo_state.Items.Add("DE");
            combo_state.Items.Add("FL");
            combo_state.Items.Add("GA");
            combo_state.Items.Add("HI");
            combo_state.Items.Add("ID");
            combo_state.Items.Add("IL");
            combo_state.Items.Add("IN");
            combo_state.Items.Add("IA");
            combo_state.Items.Add("KS");
            combo_state.Items.Add("KY");
            combo_state.Items.Add("LA");
            combo_state.Items.Add("ME");
            combo_state.Items.Add("MD");
            combo_state.Items.Add("MA");
            combo_state.Items.Add("MI");
            combo_state.Items.Add("MN");
            combo_state.Items.Add("MS");
            combo_state.Items.Add("MO");
            combo_state.Items.Add("MT");
            combo_state.Items.Add("NE");
            combo_state.Items.Add("NV");
            combo_state.Items.Add("NH");
            combo_state.Items.Add("NJ");
            combo_state.Items.Add("NM");
            combo_state.Items.Add("NY");
            combo_state.Items.Add("NC");
            combo_state.Items.Add("ND");
            combo_state.Items.Add("OH");
            combo_state.Items.Add("OK");
            combo_state.Items.Add("OR");
            combo_state.Items.Add("PA");
            combo_state.Items.Add("RI");
            combo_state.Items.Add("SC");
            combo_state.Items.Add("SD");
            combo_state.Items.Add("TN");
            combo_state.Items.Add("TX");
            combo_state.Items.Add("UT");
            combo_state.Items.Add("VT");
            combo_state.Items.Add("VA");
            combo_state.Items.Add("WA");
            combo_state.Items.Add("WV");
            combo_state.Items.Add("WI");
            combo_state.Items.Add("WY");
            combo_state.Items.Add("Nananananana BatMan");
        }
    }
}
