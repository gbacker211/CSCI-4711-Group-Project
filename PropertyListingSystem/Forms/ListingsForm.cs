﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyListingSystem.Forms;

/// <summary>
///     Class ListingsForm displays when User is logged into the system.
/// </summary>
namespace PropertyListingSystem
{
    public partial class ListingsForm : Form
    {
        // variable for Agent ID
        private int mID;

        public ListingsForm()
        {
            InitializeComponent();
            //ID = aID;
        }

        public int ID { set { mID = value;} get { return mID; } }

        /// <summary>
        ///     Displays Class AddForm 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            AddForm aNewAdd = new AddForm();
            aNewAdd.Show();
        }

        /// <summary>
        ///     Closes the ListingsForm and displays the SearchForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogut_Click(object sender, EventArgs e)
        {
            ID = 0; // change to a default int (0) to remove User's ID. 
            Close();
        }
    }


}
