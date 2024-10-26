namespace XemPhimOffline.GUI
{
    partial class frmLanguage
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
            this.lblLanguageID = new System.Windows.Forms.Label();
            this.txtLanguageID = new System.Windows.Forms.TextBox();
            this.lblLanguageName = new System.Windows.Forms.Label();
            this.txtLanguageName = new System.Windows.Forms.TextBox();
            this.btnAddLanguage = new System.Windows.Forms.Button();
            this.btnDeleteLanguage = new System.Windows.Forms.Button();
            this.btnEditLanguage = new System.Windows.Forms.Button();
            this.lblUCLanguage = new System.Windows.Forms.Label();
            this.dgvLanguages = new System.Windows.Forms.DataGridView();
            this.chkAlwaysAsk = new System.Windows.Forms.CheckBox();
            this.dgvLanguage1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanguages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanguage1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLanguageID
            // 
            this.lblLanguageID.AutoSize = true;
            this.lblLanguageID.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguageID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLanguageID.Location = new System.Drawing.Point(41, 108);
            this.lblLanguageID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLanguageID.Name = "lblLanguageID";
            this.lblLanguageID.Size = new System.Drawing.Size(91, 19);
            this.lblLanguageID.TabIndex = 0;
            this.lblLanguageID.Text = "Language ID:";
            // 
            // txtLanguageID
            // 
            this.txtLanguageID.Location = new System.Drawing.Point(145, 101);
            this.txtLanguageID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLanguageID.Name = "txtLanguageID";
            this.txtLanguageID.Size = new System.Drawing.Size(220, 26);
            this.txtLanguageID.TabIndex = 1;
            // 
            // lblLanguageName
            // 
            this.lblLanguageName.AutoSize = true;
            this.lblLanguageName.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguageName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLanguageName.Location = new System.Drawing.Point(28, 146);
            this.lblLanguageName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLanguageName.Name = "lblLanguageName";
            this.lblLanguageName.Size = new System.Drawing.Size(109, 19);
            this.lblLanguageName.TabIndex = 0;
            this.lblLanguageName.Text = "Language name:";
            // 
            // txtLanguageName
            // 
            this.txtLanguageName.Location = new System.Drawing.Point(145, 139);
            this.txtLanguageName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLanguageName.Name = "txtLanguageName";
            this.txtLanguageName.Size = new System.Drawing.Size(220, 26);
            this.txtLanguageName.TabIndex = 1;
            // 
            // btnAddLanguage
            // 
            this.btnAddLanguage.Location = new System.Drawing.Point(45, 192);
            this.btnAddLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddLanguage.Name = "btnAddLanguage";
            this.btnAddLanguage.Size = new System.Drawing.Size(100, 34);
            this.btnAddLanguage.TabIndex = 2;
            this.btnAddLanguage.Text = "Add";
            this.btnAddLanguage.UseVisualStyleBackColor = true;
            this.btnAddLanguage.Click += new System.EventHandler(this.btnAddLanguage_Click);
            // 
            // btnDeleteLanguage
            // 
            this.btnDeleteLanguage.Location = new System.Drawing.Point(265, 192);
            this.btnDeleteLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteLanguage.Name = "btnDeleteLanguage";
            this.btnDeleteLanguage.Size = new System.Drawing.Size(100, 34);
            this.btnDeleteLanguage.TabIndex = 2;
            this.btnDeleteLanguage.Text = "Delete";
            this.btnDeleteLanguage.UseVisualStyleBackColor = true;
            this.btnDeleteLanguage.Click += new System.EventHandler(this.btnDeleteLanguage_Click);
            // 
            // btnEditLanguage
            // 
            this.btnEditLanguage.Location = new System.Drawing.Point(155, 192);
            this.btnEditLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditLanguage.Name = "btnEditLanguage";
            this.btnEditLanguage.Size = new System.Drawing.Size(100, 34);
            this.btnEditLanguage.TabIndex = 2;
            this.btnEditLanguage.Text = "Edit";
            this.btnEditLanguage.UseVisualStyleBackColor = true;
            this.btnEditLanguage.Click += new System.EventHandler(this.btnEditLanguage_Click);
            // 
            // lblUCLanguage
            // 
            this.lblUCLanguage.AutoSize = true;
            this.lblUCLanguage.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUCLanguage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUCLanguage.Location = new System.Drawing.Point(13, 13);
            this.lblUCLanguage.Name = "lblUCLanguage";
            this.lblUCLanguage.Size = new System.Drawing.Size(189, 36);
            this.lblUCLanguage.TabIndex = 4;
            this.lblUCLanguage.Text = "UCLanguages";
            // 
            // dgvLanguages
            // 
            this.dgvLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLanguages.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLanguages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLanguages.Location = new System.Drawing.Point(12, 237);
            this.dgvLanguages.Name = "dgvLanguages";
            this.dgvLanguages.ReadOnly = true;
            this.dgvLanguages.RowHeadersWidth = 51;
            this.dgvLanguages.Size = new System.Drawing.Size(401, 351);
            this.dgvLanguages.TabIndex = 5;
            this.dgvLanguages.SelectionChanged += new System.EventHandler(this.dgvLanguages_SelectionChanged);
            // 
            // chkAlwaysAsk
            // 
            this.chkAlwaysAsk.AutoSize = true;
            this.chkAlwaysAsk.Checked = true;
            this.chkAlwaysAsk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlwaysAsk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkAlwaysAsk.Location = new System.Drawing.Point(372, 203);
            this.chkAlwaysAsk.Name = "chkAlwaysAsk";
            this.chkAlwaysAsk.Size = new System.Drawing.Size(216, 23);
            this.chkAlwaysAsk.TabIndex = 6;
            this.chkAlwaysAsk.Text = "Always ask before Delete/Edit";
            this.chkAlwaysAsk.UseVisualStyleBackColor = true;
            // 
            // dgvLanguage1
            // 
            this.dgvLanguage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLanguage1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLanguage1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLanguage1.Location = new System.Drawing.Point(419, 237);
            this.dgvLanguage1.Name = "dgvLanguage1";
            this.dgvLanguage1.ReadOnly = true;
            this.dgvLanguage1.RowHeadersWidth = 51;
            this.dgvLanguage1.Size = new System.Drawing.Size(401, 351);
            this.dgvLanguage1.TabIndex = 7;
            this.dgvLanguage1.SelectionChanged += new System.EventHandler(this.dgvLanguage1_SelectionChanged);
            // 
            // frmLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(825, 600);
            this.Controls.Add(this.dgvLanguage1);
            this.Controls.Add(this.chkAlwaysAsk);
            this.Controls.Add(this.dgvLanguages);
            this.Controls.Add(this.lblUCLanguage);
            this.Controls.Add(this.btnEditLanguage);
            this.Controls.Add(this.btnDeleteLanguage);
            this.Controls.Add(this.btnAddLanguage);
            this.Controls.Add(this.txtLanguageName);
            this.Controls.Add(this.lblLanguageName);
            this.Controls.Add(this.txtLanguageID);
            this.Controls.Add(this.lblLanguageID);
            this.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLanguage";
            this.Text = "frmLanguage";
            this.Load += new System.EventHandler(this.frmLanguage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanguages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanguage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLanguageID;
        private System.Windows.Forms.TextBox txtLanguageID;
        private System.Windows.Forms.Label lblLanguageName;
        private System.Windows.Forms.TextBox txtLanguageName;
        private System.Windows.Forms.Button btnAddLanguage;
        private System.Windows.Forms.Button btnDeleteLanguage;
        private System.Windows.Forms.Button btnEditLanguage;
        private System.Windows.Forms.Label lblUCLanguage;
        private System.Windows.Forms.DataGridView dgvLanguages;
        private System.Windows.Forms.CheckBox chkAlwaysAsk;
        private System.Windows.Forms.DataGridView dgvLanguage1;
    }
}