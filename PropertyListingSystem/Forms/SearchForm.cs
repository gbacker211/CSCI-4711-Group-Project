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

namespace PropertyListingSystem
{
    public partial class Form1 : Form
    {
        public static bool _hideForm = false;

        public bool isHidden = _hideForm;
        public Form1()
        {


            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_state.SelectedValue != null)
                lb_state.Text = combo_state.SelectedValue.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ////<summary>
            /// State
            /// </summary>

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

            Dictionary<string, int> number = new Dictionary<string, int>();

            number.Add("1", 1);
            number.Add("2", 2);
            number.Add("3", 3);
            number.Add("4", 4);
            number.Add("5", 5);
            number.Add("6", 6);
            

            cmdMaxBath.DataSource = new BindingSource(number, null);
            cmdMinBeds.DataSource = new BindingSource(number, null);

            cmdMaxBeds.DataSource = new BindingSource(number, null);
            cmdMinBaths.DataSource = new BindingSource(number,null);

            cmdMaxBath.DisplayMember = "Key";
            cmdMaxBeds.DisplayMember = "Key";
            cmdMinBeds.DisplayMember = "Key";
            cmdMinBaths.DisplayMember = "Key";


            cmdMaxBath.ValueMember = "Value";
            cmdMaxBeds.ValueMember = "Value";
            cmdMinBeds.ValueMember = "Value";
            cmdMinBaths.ValueMember = "Value";



            ////Beds
            //cmdMinBeds.Items.Add("1");
            //cmdMinBeds.Items.Add("2");
            //cmdMinBeds.Items.Add("3");
            //cmdMinBeds.Items.Add("4");
            //cmdMinBeds.Items.Add("5");
            //cmdMinBeds.Items.Add("6");


            //cmdMaxBeds.Items.Add("1");
            //cmdMaxBeds.Items.Add("2");
            //cmdMaxBeds.Items.Add("3");
            //cmdMaxBeds.Items.Add("4");
            //cmdMaxBeds.Items.Add("5");
            //cmdMaxBeds.Items.Add("6");

            ////Bath

            //cmdMaxBath.Items.Add("1");
            //cmdMaxBath.Items.Add("2");
            //cmdMaxBath.Items.Add("3");
            //cmdMaxBath.Items.Add("4");
            //cmdMaxBath.Items.Add("5");
            //cmdMaxBath.Items.Add("6");


            //cmdMinBaths.Items.Add("1");
            //cmdMinBaths.Items.Add("2");
            //cmdMinBaths.Items.Add("3");
            //cmdMinBaths.Items.Add("4");
            //cmdMinBaths.Items.Add("5");
            //cmdMinBaths.Items.Add("6");


            //Price
            Dictionary<string, int> prices = new Dictionary<string, int>();

            prices.Add("100,000", 100000);
            prices.Add("200,000", 200000);
            prices.Add("300,000", 300000);
            prices.Add("400,000", 400000);
            prices.Add("500,000", 500000);
            prices.Add("600,000", 600000);
            prices.Add("700,000", 700000);
            prices.Add("800,000", 800000);
            prices.Add("900,000", 900000);
            prices.Add("1,000,000", 1000000);

            combo_PMax.DataSource = new BindingSource(prices, null);
            combo_PMin.DataSource = new BindingSource(prices, null);

            combo_PMax.DisplayMember = "Key";
            combo_PMin.DisplayMember = "Key";

            combo_PMax.ValueMember = "Value";
            combo_PMin.ValueMember = "Value";







            //combo_PMin.Items.Add("100,000");
            //combo_PMin.Items.Add("200,000");
            //combo_PMin.Items.Add("300,000");
            //combo_PMin.Items.Add("400,000");
            //combo_PMin.Items.Add("500,000");
            //combo_PMin.Items.Add("600,000");
            //combo_PMin.Items.Add("700,000");
            //combo_PMin.Items.Add("800,000");
            //combo_PMin.Items.Add("900,000");
            //combo_PMin.Items.Add("1,000,000");

            //combo_PMax.Items.Add("100,000");
            //combo_PMax.Items.Add("200,000");
            //combo_PMax.Items.Add("300,000");
            //combo_PMax.Items.Add("400,000");
            //combo_PMax.Items.Add("500,000");
            //combo_PMax.Items.Add("600,000");
            //combo_PMax.Items.Add("700,000");
            //combo_PMax.Items.Add("800,000");
            //combo_PMax.Items.Add("900,000");
            //combo_PMax.Items.Add("1,000,000");


        }

        private void combo_beds_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmdMinBeds.SelectedValue != null)
            //    //lb_Bed.Text = cmdMinBeds.SelectedValue.ToString();
        }

        private void combo_bath_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmdMinBaths.SelectedValue != null)
            //    lb_Bath.Text = cmdMinBaths.SelectedValue.ToString();
        }

        private void combo_PMax_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (combo_PMax.SelectedValue != null)
            //    lb_PMax.Text = combo_PMax.SelectedValue.ToString();
        }

        private void combo_PMin_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (combo_PMin.SelectedValue != null)
            //    lb_PMin.Text = combo_PMin.SelectedValue.ToString();
        }

        private void txt_city_TextChanged(object sender, EventArgs e)
        {
            //lb_city.Text = txt_city.SelectedText.ToString();
        }

        private void txt_zip_TextChanged(object sender, EventArgs e)
        {
            //if (combo_state.SelectedValue != null)
            //    lb_Zip.Text = txt_zip.SelectedText.ToString();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {

            try
            {

                var obj = new Property()
              {
                  Address = txt_address.Text,
                  MaxNumberOfRooms = (cmdMaxBeds.SelectedValue != null || cmdMaxBath.SelectedValue.ToString() != string.Empty) ? Convert.ToInt32(cmdMaxBeds.SelectedValue) : 1,
                  MinNumberOfRooms = (cmdMinBeds.SelectedValue != null) ? Convert.ToInt32(cmdMinBeds.SelectedValue) : 1, //TODO: Add two more combo boxes and prevent nulls for combo boxes.
                  MaxNumberOfBaths = (cmdMaxBath.SelectedValue != null) ? Convert.ToInt32(cmdMaxBath.SelectedValue) : 1,
                  MinNumberOfBaths = (cmdMinBaths.SelectedValue != null) ? Convert.ToInt32(cmdMinBaths.SelectedValue) : 1,
                  MinPrice = (combo_PMin.SelectedValue != null) ? Convert.ToInt32(combo_PMin.SelectedValue) : 100000,
                  MaxPrice = (combo_PMax.SelectedValue != null) ? Convert.ToInt32(combo_PMax.SelectedValue) : 100000,
                  State = combo_state.SelectedText,
                  Zip = txt_zip.Text
              };

                List<Property> sresults = new List<Property>();

                SearchController search = new SearchController();

                ResultsForm results = new ResultsForm(search.GetPropertyListings(obj));

                results.Show();
            }
            catch (Exception ex)
            {
                //If we encounter any errors display mess

                MessageBox.Show("Please make sure all fields have the appropriate values", "Error", MessageBoxButtons.OK); ;
            }

        }


        private void bt_signin_Click(object sender, EventArgs e)
        {
            LoginController aNewLogin = new LoginController();
            aNewLogin.Open(this);
            
        }


    }
}
