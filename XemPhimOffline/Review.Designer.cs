namespace XemPhimOffline
{
    partial class Review
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
            this.chkAlwaysAsk = new System.Windows.Forms.CheckBox();
            this.lblUCRating = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubMit = new System.Windows.Forms.Button();
            this.txtNameFilm = new System.Windows.Forms.TextBox();
            this.lblNameFilm = new System.Windows.Forms.Label();
            this.txtFilmID = new System.Windows.Forms.TextBox();
            this.lblFilmID = new System.Windows.Forms.Label();
            this.lblUCLanguage = new System.Windows.Forms.Label();
            this.rtbReview = new System.Windows.Forms.RichTextBox();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.lblUserRating = new System.Windows.Forms.Label();
            this.dgvFilmRating = new System.Windows.Forms.DataGridView();
            this.btnLook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmRating)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAlwaysAsk
            // 
            this.chkAlwaysAsk.AutoSize = true;
            this.chkAlwaysAsk.Checked = true;
            this.chkAlwaysAsk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlwaysAsk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkAlwaysAsk.Location = new System.Drawing.Point(343, 453);
            this.chkAlwaysAsk.Name = "chkAlwaysAsk";
            this.chkAlwaysAsk.Size = new System.Drawing.Size(139, 17);
            this.chkAlwaysAsk.TabIndex = 35;
            this.chkAlwaysAsk.Text = "Always ask before Clear";
            this.chkAlwaysAsk.UseVisualStyleBackColor = true;
            // 
            // lblUCRating
            // 
            this.lblUCRating.AutoSize = true;
            this.lblUCRating.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUCRating.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUCRating.Location = new System.Drawing.Point(229, 25);
            this.lblUCRating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUCRating.Name = "lblUCRating";
            this.lblUCRating.Size = new System.Drawing.Size(138, 36);
            this.lblUCRating.TabIndex = 33;
            this.lblUCRating.Text = "UCRating";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(343, 479);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 34);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSubMit
            // 
            this.btnSubMit.Location = new System.Drawing.Point(153, 479);
            this.btnSubMit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSubMit.Name = "btnSubMit";
            this.btnSubMit.Size = new System.Drawing.Size(100, 34);
            this.btnSubMit.TabIndex = 32;
            this.btnSubMit.Text = "SUBMIT";
            this.btnSubMit.UseVisualStyleBackColor = true;
            // 
            // txtNameFilm
            // 
            this.txtNameFilm.Location = new System.Drawing.Point(209, 119);
            this.txtNameFilm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNameFilm.Name = "txtNameFilm";
            this.txtNameFilm.Size = new System.Drawing.Size(190, 20);
            this.txtNameFilm.TabIndex = 28;
            // 
            // lblNameFilm
            // 
            this.lblNameFilm.AutoSize = true;
            this.lblNameFilm.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFilm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNameFilm.Location = new System.Drawing.Point(117, 120);
            this.lblNameFilm.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNameFilm.Name = "lblNameFilm";
            this.lblNameFilm.Size = new System.Drawing.Size(77, 19);
            this.lblNameFilm.TabIndex = 26;
            this.lblNameFilm.Text = "Name Film:";
            // 
            // txtFilmID
            // 
            this.txtFilmID.Location = new System.Drawing.Point(209, 81);
            this.txtFilmID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtFilmID.Name = "txtFilmID";
            this.txtFilmID.Size = new System.Drawing.Size(190, 20);
            this.txtFilmID.TabIndex = 29;
            // 
            // lblFilmID
            // 
            this.lblFilmID.AutoSize = true;
            this.lblFilmID.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFilmID.Location = new System.Drawing.Point(117, 80);
            this.lblFilmID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFilmID.Name = "lblFilmID";
            this.lblFilmID.Size = new System.Drawing.Size(56, 19);
            this.lblFilmID.TabIndex = 27;
            this.lblFilmID.Text = "Film ID:";
            // 
            // lblUCLanguage
            // 
            this.lblUCLanguage.AutoSize = true;
            this.lblUCLanguage.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUCLanguage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUCLanguage.Location = new System.Drawing.Point(65, -111);
            this.lblUCLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUCLanguage.Name = "lblUCLanguage";
            this.lblUCLanguage.Size = new System.Drawing.Size(179, 36);
            this.lblUCLanguage.TabIndex = 25;
            this.lblUCLanguage.Text = "UCLanguage";
            // 
            // rtbReview
            // 
            this.rtbReview.Location = new System.Drawing.Point(86, 317);
            this.rtbReview.Name = "rtbReview";
            this.rtbReview.Size = new System.Drawing.Size(417, 83);
            this.rtbReview.TabIndex = 36;
            this.rtbReview.Text = "";
            // 
            // cmbRating
            // 
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Location = new System.Drawing.Point(232, 406);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(197, 21);
            this.cmbRating.TabIndex = 37;
            // 
            // lblUserRating
            // 
            this.lblUserRating.AutoSize = true;
            this.lblUserRating.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRating.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUserRating.Location = new System.Drawing.Point(117, 406);
            this.lblUserRating.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUserRating.Name = "lblUserRating";
            this.lblUserRating.Size = new System.Drawing.Size(78, 19);
            this.lblUserRating.TabIndex = 26;
            this.lblUserRating.Text = "UserRating";
            // 
            // dgvFilmRating
            // 
            this.dgvFilmRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmRating.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvFilmRating.Location = new System.Drawing.Point(87, 194);
            this.dgvFilmRating.Name = "dgvFilmRating";
            this.dgvFilmRating.Size = new System.Drawing.Size(416, 108);
            this.dgvFilmRating.TabIndex = 38;
            // 
            // btnLook
            // 
            this.btnLook.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLook.Location = new System.Drawing.Point(299, 151);
            this.btnLook.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(100, 34);
            this.btnLook.TabIndex = 31;
            this.btnLook.Text = "Look Film";
            this.btnLook.UseVisualStyleBackColor = false;
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(577, 525);
            this.Controls.Add(this.dgvFilmRating);
            this.Controls.Add(this.cmbRating);
            this.Controls.Add(this.rtbReview);
            this.Controls.Add(this.chkAlwaysAsk);
            this.Controls.Add(this.lblUCRating);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubMit);
            this.Controls.Add(this.txtNameFilm);
            this.Controls.Add(this.lblUserRating);
            this.Controls.Add(this.lblNameFilm);
            this.Controls.Add(this.txtFilmID);
            this.Controls.Add(this.lblFilmID);
            this.Controls.Add(this.lblUCLanguage);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Review";
            this.Text = "UserRating";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkAlwaysAsk;
        private System.Windows.Forms.Label lblUCRating;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubMit;
        private System.Windows.Forms.TextBox txtNameFilm;
        private System.Windows.Forms.Label lblNameFilm;
        private System.Windows.Forms.TextBox txtFilmID;
        private System.Windows.Forms.Label lblFilmID;
        private System.Windows.Forms.Label lblUCLanguage;
        private System.Windows.Forms.RichTextBox rtbReview;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Label lblUserRating;
        private System.Windows.Forms.DataGridView dgvFilmRating;
        private System.Windows.Forms.Button btnLook;
    }
}