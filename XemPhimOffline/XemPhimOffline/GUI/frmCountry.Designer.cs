namespace XemPhimOffline.GUI
{
    partial class frmCountry
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
            this.lblUCLanguage = new System.Windows.Forms.Label();
            this.dgvCountries = new System.Windows.Forms.DataGridView();
            this.lblUCCountries = new System.Windows.Forms.Label();
            this.btnEditCountry = new System.Windows.Forms.Button();
            this.btnDeleteCountry = new System.Windows.Forms.Button();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.txtCountryID = new System.Windows.Forms.TextBox();
            this.lblCountryID = new System.Windows.Forms.Label();
            this.chkAlwaysAsk = new System.Windows.Forms.CheckBox();
            this.dgvCountry1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUCLanguage
            // 
            this.lblUCLanguage.AutoSize = true;
            this.lblUCLanguage.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUCLanguage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUCLanguage.Location = new System.Drawing.Point(1, -91);
            this.lblUCLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUCLanguage.Name = "lblUCLanguage";
            this.lblUCLanguage.Size = new System.Drawing.Size(179, 36);
            this.lblUCLanguage.TabIndex = 13;
            this.lblUCLanguage.Text = "UCLanguage";
            // 
            // dgvCountries
            // 
            this.dgvCountries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCountries.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountries.Location = new System.Drawing.Point(12, 237);
            this.dgvCountries.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCountries.Name = "dgvCountries";
            this.dgvCountries.ReadOnly = true;
            this.dgvCountries.RowHeadersWidth = 51;
            this.dgvCountries.Size = new System.Drawing.Size(401, 351);
            this.dgvCountries.TabIndex = 22;
            this.dgvCountries.SelectionChanged += new System.EventHandler(this.dgvCountries_SelectionChanged);
            // 
            // lblUCCountries
            // 
            this.lblUCCountries.AutoSize = true;
            this.lblUCCountries.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUCCountries.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUCCountries.Location = new System.Drawing.Point(13, 13);
            this.lblUCCountries.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUCCountries.Name = "lblUCCountries";
            this.lblUCCountries.Size = new System.Drawing.Size(175, 36);
            this.lblUCCountries.TabIndex = 21;
            this.lblUCCountries.Text = "UCCountries";
            // 
            // btnEditCountry
            // 
            this.btnEditCountry.Location = new System.Drawing.Point(155, 192);
            this.btnEditCountry.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEditCountry.Name = "btnEditCountry";
            this.btnEditCountry.Size = new System.Drawing.Size(100, 34);
            this.btnEditCountry.TabIndex = 18;
            this.btnEditCountry.Text = "Edit";
            this.btnEditCountry.UseVisualStyleBackColor = true;
            this.btnEditCountry.Click += new System.EventHandler(this.btnEditCountry_Click);
            // 
            // btnDeleteCountry
            // 
            this.btnDeleteCountry.Location = new System.Drawing.Point(265, 192);
            this.btnDeleteCountry.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDeleteCountry.Name = "btnDeleteCountry";
            this.btnDeleteCountry.Size = new System.Drawing.Size(100, 34);
            this.btnDeleteCountry.TabIndex = 19;
            this.btnDeleteCountry.Text = "Delete";
            this.btnDeleteCountry.UseVisualStyleBackColor = true;
            this.btnDeleteCountry.Click += new System.EventHandler(this.btnDeleteCountry_Click);
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.Location = new System.Drawing.Point(45, 192);
            this.btnAddCountry.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(100, 34);
            this.btnAddCountry.TabIndex = 20;
            this.btnAddCountry.Text = "Add";
            this.btnAddCountry.UseVisualStyleBackColor = true;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(145, 139);
            this.txtCountryName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(220, 26);
            this.txtCountryName.TabIndex = 16;
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCountryName.Location = new System.Drawing.Point(35, 146);
            this.lblCountryName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(100, 19);
            this.lblCountryName.TabIndex = 14;
            this.lblCountryName.Text = "Country name:";
            // 
            // txtCountryID
            // 
            this.txtCountryID.Location = new System.Drawing.Point(145, 101);
            this.txtCountryID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCountryID.Name = "txtCountryID";
            this.txtCountryID.Size = new System.Drawing.Size(220, 26);
            this.txtCountryID.TabIndex = 17;
            // 
            // lblCountryID
            // 
            this.lblCountryID.AutoSize = true;
            this.lblCountryID.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCountryID.Location = new System.Drawing.Point(53, 108);
            this.lblCountryID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCountryID.Name = "lblCountryID";
            this.lblCountryID.Size = new System.Drawing.Size(82, 19);
            this.lblCountryID.TabIndex = 15;
            this.lblCountryID.Text = "Country ID:";
            // 
            // chkAlwaysAsk
            // 
            this.chkAlwaysAsk.AutoSize = true;
            this.chkAlwaysAsk.Checked = true;
            this.chkAlwaysAsk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlwaysAsk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkAlwaysAsk.Location = new System.Drawing.Point(373, 203);
            this.chkAlwaysAsk.Name = "chkAlwaysAsk";
            this.chkAlwaysAsk.Size = new System.Drawing.Size(216, 23);
            this.chkAlwaysAsk.TabIndex = 23;
            this.chkAlwaysAsk.Text = "Always ask before Delete/Edit";
            this.chkAlwaysAsk.UseVisualStyleBackColor = true;
            // 
            // dgvCountry1
            // 
            this.dgvCountry1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCountry1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCountry1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountry1.Location = new System.Drawing.Point(421, 237);
            this.dgvCountry1.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCountry1.Name = "dgvCountry1";
            this.dgvCountry1.ReadOnly = true;
            this.dgvCountry1.RowHeadersWidth = 51;
            this.dgvCountry1.Size = new System.Drawing.Size(401, 351);
            this.dgvCountry1.TabIndex = 24;
            this.dgvCountry1.SelectionChanged += new System.EventHandler(this.dgvCountry1_SelectionChanged);
            // 
            // frmCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(825, 600);
            this.Controls.Add(this.dgvCountry1);
            this.Controls.Add(this.chkAlwaysAsk);
            this.Controls.Add(this.dgvCountries);
            this.Controls.Add(this.lblUCCountries);
            this.Controls.Add(this.btnEditCountry);
            this.Controls.Add(this.btnDeleteCountry);
            this.Controls.Add(this.btnAddCountry);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.txtCountryID);
            this.Controls.Add(this.lblCountryID);
            this.Controls.Add(this.lblUCLanguage);
            this.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCountry";
            this.Text = "frmCountry";
            this.Load += new System.EventHandler(this.frmCountry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUCLanguage;
        private System.Windows.Forms.DataGridView dgvCountries;
        private System.Windows.Forms.Label lblUCCountries;
        private System.Windows.Forms.Button btnEditCountry;
        private System.Windows.Forms.Button btnDeleteCountry;
        private System.Windows.Forms.Button btnAddCountry;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.TextBox txtCountryID;
        private System.Windows.Forms.Label lblCountryID;
        private System.Windows.Forms.CheckBox chkAlwaysAsk;
        private System.Windows.Forms.DataGridView dgvCountry1;
    }
}