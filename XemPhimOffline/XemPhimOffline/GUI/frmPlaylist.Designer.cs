namespace XemPhimOffline.GUI
{
    partial class frmPlaylist
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
            this.dgvFilmLike = new System.Windows.Forms.DataGridView();
            this.chkAlwaysAsk = new System.Windows.Forms.CheckBox();
            this.dgvFilm = new System.Windows.Forms.DataGridView();
            this.lblUCCountries = new System.Windows.Forms.Label();
            this.btnEditFilm = new System.Windows.Forms.Button();
            this.btnDeleteFilm = new System.Windows.Forms.Button();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.txtCountryID = new System.Windows.Forms.TextBox();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.lblUCLanguage = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFilmLike
            // 
            this.dgvFilmLike.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFilmLike.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFilmLike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmLike.Location = new System.Drawing.Point(485, 252);
            this.dgvFilmLike.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFilmLike.Name = "dgvFilmLike";
            this.dgvFilmLike.ReadOnly = true;
            this.dgvFilmLike.RowHeadersWidth = 51;
            this.dgvFilmLike.Size = new System.Drawing.Size(401, 383);
            this.dgvFilmLike.TabIndex = 36;
            // 
            // chkAlwaysAsk
            // 
            this.chkAlwaysAsk.AutoSize = true;
            this.chkAlwaysAsk.Checked = true;
            this.chkAlwaysAsk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlwaysAsk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkAlwaysAsk.Location = new System.Drawing.Point(418, 180);
            this.chkAlwaysAsk.Name = "chkAlwaysAsk";
            this.chkAlwaysAsk.Size = new System.Drawing.Size(169, 17);
            this.chkAlwaysAsk.TabIndex = 35;
            this.chkAlwaysAsk.Text = "Always ask before Delete/Edit";
            this.chkAlwaysAsk.UseVisualStyleBackColor = true;
            // 
            // dgvFilm
            // 
            this.dgvFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFilm.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilm.Location = new System.Drawing.Point(26, 252);
            this.dgvFilm.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFilm.Name = "dgvFilm";
            this.dgvFilm.ReadOnly = true;
            this.dgvFilm.RowHeadersWidth = 51;
            this.dgvFilm.Size = new System.Drawing.Size(401, 383);
            this.dgvFilm.TabIndex = 34;
            // 
            // lblUCCountries
            // 
            this.lblUCCountries.AutoSize = true;
            this.lblUCCountries.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUCCountries.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUCCountries.Location = new System.Drawing.Point(58, 9);
            this.lblUCCountries.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUCCountries.Name = "lblUCCountries";
            this.lblUCCountries.Size = new System.Drawing.Size(149, 36);
            this.lblUCCountries.TabIndex = 33;
            this.lblUCCountries.Text = "UCPlaylist";
            // 
            // btnEditFilm
            // 
            this.btnEditFilm.Location = new System.Drawing.Point(200, 169);
            this.btnEditFilm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEditFilm.Name = "btnEditFilm";
            this.btnEditFilm.Size = new System.Drawing.Size(100, 34);
            this.btnEditFilm.TabIndex = 30;
            this.btnEditFilm.Text = "Edit";
            this.btnEditFilm.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFilm
            // 
            this.btnDeleteFilm.Location = new System.Drawing.Point(310, 169);
            this.btnDeleteFilm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDeleteFilm.Name = "btnDeleteFilm";
            this.btnDeleteFilm.Size = new System.Drawing.Size(100, 34);
            this.btnDeleteFilm.TabIndex = 31;
            this.btnDeleteFilm.Text = "Delete";
            this.btnDeleteFilm.UseVisualStyleBackColor = true;
            this.btnDeleteFilm.Click += new System.EventHandler(this.btnDeleteFilm_Click);
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.Location = new System.Drawing.Point(90, 169);
            this.btnAddFilm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(100, 34);
            this.btnAddFilm.TabIndex = 32;
            this.btnAddFilm.Text = "Add";
            this.btnAddFilm.UseVisualStyleBackColor = true;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(190, 116);
            this.txtCountryName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(220, 20);
            this.txtCountryName.TabIndex = 28;
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCountryName.Location = new System.Drawing.Point(98, 117);
            this.lblCountryName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(79, 19);
            this.lblCountryName.TabIndex = 26;
            this.lblCountryName.Text = "Tên playlist";
            // 
            // txtCountryID
            // 
            this.txtCountryID.Location = new System.Drawing.Point(190, 78);
            this.txtCountryID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCountryID.Name = "txtCountryID";
            this.txtCountryID.Size = new System.Drawing.Size(220, 20);
            this.txtCountryID.TabIndex = 29;
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlaylist.Location = new System.Drawing.Point(98, 85);
            this.lblPlaylist.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(56, 19);
            this.lblPlaylist.TabIndex = 27;
            this.lblPlaylist.Text = "Film ID:";
            // 
            // lblUCLanguage
            // 
            this.lblUCLanguage.AutoSize = true;
            this.lblUCLanguage.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUCLanguage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUCLanguage.Location = new System.Drawing.Point(46, -114);
            this.lblUCLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUCLanguage.Name = "lblUCLanguage";
            this.lblUCLanguage.Size = new System.Drawing.Size(179, 36);
            this.lblUCLanguage.TabIndex = 25;
            this.lblUCLanguage.Text = "UCLanguage";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(607, 180);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(912, 663);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dgvFilmLike);
            this.Controls.Add(this.chkAlwaysAsk);
            this.Controls.Add(this.dgvFilm);
            this.Controls.Add(this.lblUCCountries);
            this.Controls.Add(this.btnEditFilm);
            this.Controls.Add(this.btnDeleteFilm);
            this.Controls.Add(this.btnAddFilm);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.txtCountryID);
            this.Controls.Add(this.lblPlaylist);
            this.Controls.Add(this.lblUCLanguage);
            this.Name = "frmPlaylist";
            this.Text = "frmPlaylist";
            this.Load += new System.EventHandler(this.frmPlaylist_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilmLike;
        private System.Windows.Forms.CheckBox chkAlwaysAsk;
        private System.Windows.Forms.DataGridView dgvFilm;
        private System.Windows.Forms.Label lblUCCountries;
        private System.Windows.Forms.Button btnEditFilm;
        private System.Windows.Forms.Button btnDeleteFilm;
        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.TextBox txtCountryID;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.Label lblUCLanguage;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}