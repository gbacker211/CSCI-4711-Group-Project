using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyListingSystem.Controllers;

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



            combo_beds.Items.Add("1");
            combo_beds.Items.Add("2");
            combo_beds.Items.Add("3");
            combo_beds.Items.Add("4");
            combo_beds.Items.Add("5");
            combo_beds.Items.Add("6");
            combo_beds.Items.Add("into infinity and beyond");

            combo_bath.Items.Add("1");
            combo_bath.Items.Add("2");
            combo_bath.Items.Add("3");
            combo_bath.Items.Add("4");
            combo_bath.Items.Add("bed bath and beyond the strartosphere");


            combo_PMin.Items.Add("100,000");
            combo_PMin.Items.Add("200,000");
            combo_PMin.Items.Add("300,000");
            combo_PMin.Items.Add("400,000");
            combo_PMin.Items.Add("500,000");
            combo_PMin.Items.Add("600,000");
            combo_PMin.Items.Add("700,000");
            combo_PMin.Items.Add("800,000");
            combo_PMin.Items.Add("900,000");
            combo_PMin.Items.Add("1,000,000");
            combo_PMin.Items.Add("if you have to ask");

            combo_PMax.Items.Add("100,000");
            combo_PMax.Items.Add("200,000");
            combo_PMax.Items.Add("300,000");
            combo_PMax.Items.Add("400,000");
            combo_PMax.Items.Add("500,000");
            combo_PMax.Items.Add("600,000");
            combo_PMax.Items.Add("700,000");
            combo_PMax.Items.Add("800,000");
            combo_PMax.Items.Add("900,000");
            combo_PMax.Items.Add("1,000,000");
            combo_PMax.Items.Add("you cant afford it");


        }

        private void combo_beds_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_Bed.Text = combo_beds.SelectedValue.ToString();
        }

        private void combo_bath_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_Bath.Text = combo_bath.SelectedValue.ToString();
        }

        private void combo_PMax_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_PMax.Text = combo_PMax.SelectedValue.ToString();
        }

        private void combo_PMin_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_PMin.Text = combo_PMin.SelectedValue.ToString();
        }

        private void txt_city_TextChanged(object sender, EventArgs e)
        {
            lb_city.Text = txt_city.SelectedText.ToString();
        }

        private void txt_zip_TextChanged(object sender, EventArgs e)
        {
            lb_Zip.Text = txt_zip.SelectedText.ToString();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            
            var obj = new Property()
            {
                Address = lb_address.Text,
                AgentID = 0, // Tempory until we establish agent ids
                NumberOfBaths = Convert.ToInt32(combo_bath.Text),
                NumberOfRooms = Convert.ToInt32(combo_beds.Text),
                MinPrice = Convert.ToInt32(lb_PMin.Text),
                MaxPrice = Convert.ToInt32(lb_PMax.Text),
                State = lb_state.Text,
                Zip = lb_Zip.Text
            };

            List<Property> sresults = new List<Property>();

            SearchController search = new SearchController();

            ResultsForm results = new ResultsForm(search.GetPropertyListings(obj));

        }

      
        private void bt_signin_Click(object sender, EventArgs e)
        {
            LoginController aNewLogin = new LoginController();
            aNewLogin.Open();
        }
    }
}
