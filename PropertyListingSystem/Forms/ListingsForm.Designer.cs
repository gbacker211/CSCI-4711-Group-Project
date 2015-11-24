namespace PropertyListingSystem
{
    partial class ListingsForm
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
            this.components = new System.ComponentModel.Container();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAgent = new System.Windows.Forms.Label();
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dgvListingsFormView = new System.Windows.Forms.DataGridView();
            this.propertyListingsDBDataSet1 = new PropertyListingSystem.PropertyListingsDBDataSet1();
            this.propertyListingsDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListingsFormView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyListingsDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyListingsDBDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(15, 28);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(122, 29);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblAgent
            // 
            this.lblAgent.AutoSize = true;
            this.lblAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgent.Location = new System.Drawing.Point(125, 28);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(0, 29);
            this.lblAgent.TabIndex = 1;
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProperty.Location = new System.Drawing.Point(98, 900);
            this.btnAddProperty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(136, 65);
            this.btnAddProperty.TabIndex = 3;
            this.btnAddProperty.Text = "Add Listing";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(569, 900);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 65);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dgvListingsFormView
            // 
            this.dgvListingsFormView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListingsFormView.Location = new System.Drawing.Point(62, 92);
            this.dgvListingsFormView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListingsFormView.Name = "dgvListingsFormView";
            this.dgvListingsFormView.RowTemplate.Height = 24;
            this.dgvListingsFormView.Size = new System.Drawing.Size(961, 726);
            this.dgvListingsFormView.TabIndex = 5;
            // 
            // propertyListingsDBDataSet1
            // 
            this.propertyListingsDBDataSet1.DataSetName = "PropertyListingsDBDataSet1";
            this.propertyListingsDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertyListingsDBDataSet1BindingSource
            // 
            this.propertyListingsDBDataSet1BindingSource.DataSource = this.propertyListingsDBDataSet1;
            this.propertyListingsDBDataSet1BindingSource.Position = 0;
            // 
            // ListingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 992);
            this.Controls.Add(this.dgvListingsFormView);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAddProperty);
            this.Controls.Add(this.lblAgent);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListingsForm";
            this.Text = "ListingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListingsFormView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyListingsDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyListingsDBDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.Button btnAddProperty;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvListingsFormView;
        private System.Windows.Forms.BindingSource propertyListingsDBDataSet1BindingSource;
        private PropertyListingsDBDataSet1 propertyListingsDBDataSet1;
    }
}