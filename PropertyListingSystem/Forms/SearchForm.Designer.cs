﻿namespace PropertyListingSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.combo_state = new System.Windows.Forms.ComboBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_zip = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.combo_PMin = new System.Windows.Forms.ComboBox();
            this.combo_PMax = new System.Windows.Forms.ComboBox();
            this.combo_beds = new System.Windows.Forms.ComboBox();
            this.combo_bath = new System.Windows.Forms.ComboBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_signin = new System.Windows.Forms.Button();
            this.lb_state = new System.Windows.Forms.Label();
            this.lb_city = new System.Windows.Forms.Label();
            this.lb_Zip = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_PMin = new System.Windows.Forms.Label();
            this.lb_PMax = new System.Windows.Forms.Label();
            this.lb_Bed = new System.Windows.Forms.Label();
            this.lb_Bath = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo_state
            // 
            this.combo_state.FormattingEnabled = true;
            this.combo_state.Location = new System.Drawing.Point(183, 170);
            this.combo_state.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_state.Name = "combo_state";
            this.combo_state.Size = new System.Drawing.Size(101, 24);
            this.combo_state.TabIndex = 0;
            this.combo_state.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(487, 170);
            this.txt_city.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(185, 22);
            this.txt_city.TabIndex = 1;
            this.txt_city.TextChanged += new System.EventHandler(this.txt_city_TextChanged);
            // 
            // txt_zip
            // 
            this.txt_zip.Location = new System.Drawing.Point(851, 170);
            this.txt_zip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_zip.Name = "txt_zip";
            this.txt_zip.Size = new System.Drawing.Size(104, 22);
            this.txt_zip.TabIndex = 2;
            this.txt_zip.TextChanged += new System.EventHandler(this.txt_zip_TextChanged);
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(276, 257);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(552, 22);
            this.txt_address.TabIndex = 3;
            // 
            // combo_PMin
            // 
            this.combo_PMin.FormattingEnabled = true;
            this.combo_PMin.Location = new System.Drawing.Point(183, 383);
            this.combo_PMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_PMin.Name = "combo_PMin";
            this.combo_PMin.Size = new System.Drawing.Size(112, 24);
            this.combo_PMin.TabIndex = 4;
            this.combo_PMin.SelectedIndexChanged += new System.EventHandler(this.combo_PMin_SelectedIndexChanged);
            // 
            // combo_PMax
            // 
            this.combo_PMax.FormattingEnabled = true;
            this.combo_PMax.Location = new System.Drawing.Point(393, 383);
            this.combo_PMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_PMax.Name = "combo_PMax";
            this.combo_PMax.Size = new System.Drawing.Size(112, 24);
            this.combo_PMax.TabIndex = 5;
            this.combo_PMax.SelectedIndexChanged += new System.EventHandler(this.combo_PMax_SelectedIndexChanged);
            // 
            // combo_beds
            // 
            this.combo_beds.FormattingEnabled = true;
            this.combo_beds.Location = new System.Drawing.Point(641, 383);
            this.combo_beds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_beds.Name = "combo_beds";
            this.combo_beds.Size = new System.Drawing.Size(112, 24);
            this.combo_beds.TabIndex = 6;
            this.combo_beds.SelectedIndexChanged += new System.EventHandler(this.combo_beds_SelectedIndexChanged);
            // 
            // combo_bath
            // 
            this.combo_bath.FormattingEnabled = true;
            this.combo_bath.Location = new System.Drawing.Point(863, 382);
            this.combo_bath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_bath.Name = "combo_bath";
            this.combo_bath.Size = new System.Drawing.Size(112, 24);
            this.combo_bath.TabIndex = 7;
            this.combo_bath.SelectedIndexChanged += new System.EventHandler(this.combo_bath_SelectedIndexChanged);
            // 
            // bt_search
            // 
            this.bt_search.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.Location = new System.Drawing.Point(420, 444);
            this.bt_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(192, 62);
            this.bt_search.TabIndex = 8;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_signin
            // 
            this.bt_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_signin.Location = new System.Drawing.Point(803, 36);
            this.bt_signin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_signin.Name = "bt_signin";
            this.bt_signin.Size = new System.Drawing.Size(196, 46);
            this.bt_signin.TabIndex = 9;
            this.bt_signin.Text = "Agent Sign-In";
            this.bt_signin.UseVisualStyleBackColor = true;
            this.bt_signin.Click += new System.EventHandler(this.bt_signin_Click);
            // 
            // lb_state
            // 
            this.lb_state.AutoSize = true;
            this.lb_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_state.Location = new System.Drawing.Point(112, 169);
            this.lb_state.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_state.Name = "lb_state";
            this.lb_state.Size = new System.Drawing.Size(56, 24);
            this.lb_state.TabIndex = 10;
            this.lb_state.Text = "State";
            // 
            // lb_city
            // 
            this.lb_city.AutoSize = true;
            this.lb_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_city.Location = new System.Drawing.Point(416, 169);
            this.lb_city.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_city.Name = "lb_city";
            this.lb_city.Size = new System.Drawing.Size(44, 24);
            this.lb_city.TabIndex = 11;
            this.lb_city.Text = "City";
            // 
            // lb_Zip
            // 
            this.lb_Zip.AutoSize = true;
            this.lb_Zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Zip.Location = new System.Drawing.Point(799, 169);
            this.lb_Zip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Zip.Name = "lb_Zip";
            this.lb_Zip.Size = new System.Drawing.Size(41, 24);
            this.lb_Zip.TabIndex = 12;
            this.lb_Zip.Text = "ZIP";
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(176, 260);
            this.lb_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(87, 24);
            this.lb_address.TabIndex = 13;
            this.lb_address.Text = "Address";
            // 
            // lb_PMin
            // 
            this.lb_PMin.AutoSize = true;
            this.lb_PMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PMin.Location = new System.Drawing.Point(112, 382);
            this.lb_PMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_PMin.Name = "lb_PMin";
            this.lb_PMin.Size = new System.Drawing.Size(47, 24);
            this.lb_PMin.TabIndex = 14;
            this.lb_PMin.Text = "MIN";
            // 
            // lb_PMax
            // 
            this.lb_PMax.AutoSize = true;
            this.lb_PMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PMax.Location = new System.Drawing.Point(323, 382);
            this.lb_PMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_PMax.Name = "lb_PMax";
            this.lb_PMax.Size = new System.Drawing.Size(56, 24);
            this.lb_PMax.TabIndex = 15;
            this.lb_PMax.Text = "MAX";
            // 
            // lb_Bed
            // 
            this.lb_Bed.AutoSize = true;
            this.lb_Bed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Bed.Location = new System.Drawing.Point(571, 382);
            this.lb_Bed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Bed.Name = "lb_Bed";
            this.lb_Bed.Size = new System.Drawing.Size(57, 24);
            this.lb_Bed.TabIndex = 16;
            this.lb_Bed.Text = "Beds";
            // 
            // lb_Bath
            // 
            this.lb_Bath.AutoSize = true;
            this.lb_Bath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Bath.Location = new System.Drawing.Point(799, 382);
            this.lb_Bath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Bath.Name = "lb_Bath";
            this.lb_Bath.Size = new System.Drawing.Size(51, 24);
            this.lb_Bath.TabIndex = 17;
            this.lb_Bath.Text = "Bath";
            this.lb_Bath.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(257, 342);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 521);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_Bath);
            this.Controls.Add(this.lb_Bed);
            this.Controls.Add(this.lb_PMax);
            this.Controls.Add(this.lb_PMin);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.lb_Zip);
            this.Controls.Add(this.lb_city);
            this.Controls.Add(this.lb_state);
            this.Controls.Add(this.bt_signin);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.combo_bath);
            this.Controls.Add(this.combo_beds);
            this.Controls.Add(this.combo_PMax);
            this.Controls.Add(this.combo_PMin);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_zip);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.combo_state);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_state;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_zip;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.ComboBox combo_PMin;
        private System.Windows.Forms.ComboBox combo_PMax;
        private System.Windows.Forms.ComboBox combo_beds;
        private System.Windows.Forms.ComboBox combo_bath;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button bt_signin;
        private System.Windows.Forms.Label lb_state;
        private System.Windows.Forms.Label lb_city;
        private System.Windows.Forms.Label lb_Zip;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_PMin;
        private System.Windows.Forms.Label lb_PMax;
        private System.Windows.Forms.Label lb_Bed;
        private System.Windows.Forms.Label lb_Bath;
        private System.Windows.Forms.Label label9;
    }
}

