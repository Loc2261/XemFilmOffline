namespace XemPhimOffline.GUI
{
    partial class frmDirector
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
            this.dgvDirector = new System.Windows.Forms.DataGridView();
            this.lblUC = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDirectorName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDirectorID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.dtpDirectorBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblDirectorGender = new System.Windows.Forms.Label();
            this.txtDirectorGender = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.dgvDirector1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirector1)).BeginInit();
            this.SuspendLayout();
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
            this.chkAlwaysAsk.TabIndex = 16;
            this.chkAlwaysAsk.Text = "Always ask before Delete/Edit";
            this.chkAlwaysAsk.UseVisualStyleBackColor = true;
            // 
            // dgvDirector
            // 
            this.dgvDirector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDirector.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDirector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirector.Location = new System.Drawing.Point(12, 237);
            this.dgvDirector.Name = "dgvDirector";
            this.dgvDirector.ReadOnly = true;
            this.dgvDirector.RowHeadersWidth = 51;
            this.dgvDirector.Size = new System.Drawing.Size(401, 351);
            this.dgvDirector.TabIndex = 15;
            this.dgvDirector.SelectionChanged += new System.EventHandler(this.dgvDirector_SelectionChanged);
            // 
            // lblUC
            // 
            this.lblUC.AutoSize = true;
            this.lblUC.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUC.Location = new System.Drawing.Point(13, 13);
            this.lblUC.Name = "lblUC";
            this.lblUC.Size = new System.Drawing.Size(167, 36);
            this.lblUC.TabIndex = 14;
            this.lblUC.Text = "UCDirectors";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(155, 192);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 34);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(265, 192);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 34);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 192);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 34);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDirectorName
            // 
            this.txtDirectorName.Location = new System.Drawing.Point(145, 139);
            this.txtDirectorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirectorName.Name = "txtDirectorName";
            this.txtDirectorName.Size = new System.Drawing.Size(220, 26);
            this.txtDirectorName.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(39, 146);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 19);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Director name:";
            // 
            // txtDirectorID
            // 
            this.txtDirectorID.Location = new System.Drawing.Point(145, 101);
            this.txtDirectorID.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirectorID.Name = "txtDirectorID";
            this.txtDirectorID.Size = new System.Drawing.Size(220, 26);
            this.txtDirectorID.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblID.Location = new System.Drawing.Point(60, 108);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(77, 19);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "DirectorID:";
            // 
            // dtpDirectorBirthday
            // 
            this.dtpDirectorBirthday.Location = new System.Drawing.Point(477, 140);
            this.dtpDirectorBirthday.Name = "dtpDirectorBirthday";
            this.dtpDirectorBirthday.Size = new System.Drawing.Size(247, 26);
            this.dtpDirectorBirthday.TabIndex = 17;
            // 
            // lblDirectorGender
            // 
            this.lblDirectorGender.AutoSize = true;
            this.lblDirectorGender.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectorGender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDirectorGender.Location = new System.Drawing.Point(412, 108);
            this.lblDirectorGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirectorGender.Name = "lblDirectorGender";
            this.lblDirectorGender.Size = new System.Drawing.Size(58, 19);
            this.lblDirectorGender.TabIndex = 8;
            this.lblDirectorGender.Text = "Gender:";
            // 
            // txtDirectorGender
            // 
            this.txtDirectorGender.Location = new System.Drawing.Point(478, 101);
            this.txtDirectorGender.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirectorGender.Name = "txtDirectorGender";
            this.txtDirectorGender.Size = new System.Drawing.Size(246, 26);
            this.txtDirectorGender.TabIndex = 10;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBirthday.Location = new System.Drawing.Point(403, 146);
            this.lblBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(67, 19);
            this.lblBirthday.TabIndex = 8;
            this.lblBirthday.Text = "Birthday:";
            // 
            // dgvDirector1
            // 
            this.dgvDirector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDirector1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDirector1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirector1.Location = new System.Drawing.Point(419, 237);
            this.dgvDirector1.Name = "dgvDirector1";
            this.dgvDirector1.ReadOnly = true;
            this.dgvDirector1.RowHeadersWidth = 51;
            this.dgvDirector1.Size = new System.Drawing.Size(401, 351);
            this.dgvDirector1.TabIndex = 18;
            this.dgvDirector1.SelectionChanged += new System.EventHandler(this.dgvDirector1_SelectionChanged);
            // 
            // frmDirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(825, 600);
            this.Controls.Add(this.dgvDirector1);
            this.Controls.Add(this.dtpDirectorBirthday);
            this.Controls.Add(this.chkAlwaysAsk);
            this.Controls.Add(this.dgvDirector);
            this.Controls.Add(this.lblUC);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDirectorName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtDirectorGender);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblDirectorGender);
            this.Controls.Add(this.txtDirectorID);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDirector";
            this.Text = "frmDirector";
            this.Load += new System.EventHandler(this.frmDirector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirector1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAlwaysAsk;
        private System.Windows.Forms.DataGridView dgvDirector;
        private System.Windows.Forms.Label lblUC;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDirectorName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDirectorID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DateTimePicker dtpDirectorBirthday;
        private System.Windows.Forms.Label lblDirectorGender;
        private System.Windows.Forms.TextBox txtDirectorGender;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.DataGridView dgvDirector1;
    }
}