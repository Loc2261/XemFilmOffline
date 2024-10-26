namespace XemPhimOffline
{
    partial class frm1Main
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
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.homeMenuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnSubscription = new System.Windows.Forms.Button();
            this.btnActors = new System.Windows.Forms.Button();
            this.btnDirectors = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnCountries = new System.Windows.Forms.Button();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.homeMenuTransition = new System.Windows.Forms.Timer(this.components);
            this.panelSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panelToolbar.SuspendLayout();
            this.homeMenuContainer.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelToolbar.Controls.Add(this.button1);
            this.panelToolbar.Controls.Add(this.nightControlBox1);
            this.panelToolbar.Controls.Add(this.lblTitle);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Location = new System.Drawing.Point(0, 0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(1167, 44);
            this.panelToolbar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button1.Image = global::XemPhimOffline.Properties.Resources.Menu;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 44);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(1028, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTitle.Location = new System.Drawing.Point(71, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(367, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Nhóm 9 | CinemaShelf - Manage Your Movies!";
            // 
            // homeMenuContainer
            // 
            this.homeMenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.homeMenuContainer.Controls.Add(this.btnHome);
            this.homeMenuContainer.Controls.Add(this.btnMovies);
            this.homeMenuContainer.Controls.Add(this.btnUsers);
            this.homeMenuContainer.Controls.Add(this.btnSubscription);
            this.homeMenuContainer.Controls.Add(this.btnActors);
            this.homeMenuContainer.Controls.Add(this.btnDirectors);
            this.homeMenuContainer.Controls.Add(this.btnCategories);
            this.homeMenuContainer.Controls.Add(this.btnCountries);
            this.homeMenuContainer.Controls.Add(this.btnLanguage);
            this.homeMenuContainer.Location = new System.Drawing.Point(0, 63);
            this.homeMenuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.homeMenuContainer.Name = "homeMenuContainer";
            this.homeMenuContainer.Size = new System.Drawing.Size(200, 63);
            this.homeMenuContainer.TabIndex = 4;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.Image = global::XemPhimOffline.Properties.Resources.Settings;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 63);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "       Management";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnMovies.FlatAppearance.BorderSize = 0;
            this.btnMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovies.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovies.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMovies.Image = global::XemPhimOffline.Properties.Resources.Video;
            this.btnMovies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovies.Location = new System.Drawing.Point(3, 66);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(163, 63);
            this.btnMovies.TabIndex = 3;
            this.btnMovies.Text = "    Movies";
            this.btnMovies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovies.UseVisualStyleBackColor = false;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsers.Image = global::XemPhimOffline.Properties.Resources.Customer;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(3, 135);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(163, 63);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Text = "    Users";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnSubscription
            // 
            this.btnSubscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnSubscription.FlatAppearance.BorderSize = 0;
            this.btnSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubscription.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubscription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubscription.Image = global::XemPhimOffline.Properties.Resources.Membership_Card;
            this.btnSubscription.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSubscription.Location = new System.Drawing.Point(3, 204);
            this.btnSubscription.Name = "btnSubscription";
            this.btnSubscription.Size = new System.Drawing.Size(163, 63);
            this.btnSubscription.TabIndex = 6;
            this.btnSubscription.Text = " Subscriptions";
            this.btnSubscription.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSubscription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubscription.UseVisualStyleBackColor = false;
            this.btnSubscription.Click += new System.EventHandler(this.btnSubscription_Click);
            // 
            // btnActors
            // 
            this.btnActors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnActors.FlatAppearance.BorderSize = 0;
            this.btnActors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActors.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActors.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActors.Image = global::XemPhimOffline.Properties.Resources.Actor;
            this.btnActors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActors.Location = new System.Drawing.Point(3, 273);
            this.btnActors.Name = "btnActors";
            this.btnActors.Size = new System.Drawing.Size(163, 63);
            this.btnActors.TabIndex = 3;
            this.btnActors.Text = "    Actors";
            this.btnActors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActors.UseVisualStyleBackColor = false;
            this.btnActors.Click += new System.EventHandler(this.btnActors_Click);
            // 
            // btnDirectors
            // 
            this.btnDirectors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnDirectors.FlatAppearance.BorderSize = 0;
            this.btnDirectors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectors.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectors.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDirectors.Image = global::XemPhimOffline.Properties.Resources.Manager;
            this.btnDirectors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirectors.Location = new System.Drawing.Point(3, 342);
            this.btnDirectors.Name = "btnDirectors";
            this.btnDirectors.Size = new System.Drawing.Size(163, 63);
            this.btnDirectors.TabIndex = 3;
            this.btnDirectors.Text = "    Directors";
            this.btnDirectors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDirectors.UseVisualStyleBackColor = false;
            this.btnDirectors.Click += new System.EventHandler(this.btnDirectors_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCategories.Image = global::XemPhimOffline.Properties.Resources.Diversity;
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.Location = new System.Drawing.Point(3, 411);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(163, 63);
            this.btnCategories.TabIndex = 3;
            this.btnCategories.Text = "    Categories";
            this.btnCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnCountries
            // 
            this.btnCountries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnCountries.FlatAppearance.BorderSize = 0;
            this.btnCountries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCountries.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountries.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCountries.Image = global::XemPhimOffline.Properties.Resources.Country;
            this.btnCountries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCountries.Location = new System.Drawing.Point(3, 480);
            this.btnCountries.Name = "btnCountries";
            this.btnCountries.Size = new System.Drawing.Size(163, 63);
            this.btnCountries.TabIndex = 3;
            this.btnCountries.Text = "    Countries";
            this.btnCountries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCountries.UseVisualStyleBackColor = false;
            this.btnCountries.Click += new System.EventHandler(this.btnCountries_Click);
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnLanguage.FlatAppearance.BorderSize = 0;
            this.btnLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanguage.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLanguage.Image = global::XemPhimOffline.Properties.Resources.Language;
            this.btnLanguage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLanguage.Location = new System.Drawing.Point(3, 549);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(163, 63);
            this.btnLanguage.TabIndex = 3;
            this.btnLanguage.Text = "    Languages";
            this.btnLanguage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLanguage.UseVisualStyleBackColor = false;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // homeMenuTransition
            // 
            this.homeMenuTransition.Interval = 10;
            this.homeMenuTransition.Tick += new System.EventHandler(this.homeMenuTransition_Tick);
            // 
            // panelSidebar
            // 
            this.panelSidebar.AutoScroll = true;
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.homeMenuContainer);
            this.panelSidebar.Controls.Add(this.btnProfile);
            this.panelSidebar.Controls.Add(this.btnAboutUs);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 44);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 656);
            this.panelSidebar.TabIndex = 5;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDashboard.Image = global::XemPhimOffline.Properties.Resources.Control_Panel;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(185, 63);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "       Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProfile.Image = global::XemPhimOffline.Properties.Resources.Administrator_Male;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 126);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(185, 63);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "       Profile";
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAboutUs.Image = global::XemPhimOffline.Properties.Resources.About;
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.Location = new System.Drawing.Point(0, 189);
            this.btnAboutUs.Margin = new System.Windows.Forms.Padding(0);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(185, 63);
            this.btnAboutUs.TabIndex = 3;
            this.btnAboutUs.Text = "       About us";
            this.btnAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAboutUs.UseVisualStyleBackColor = false;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // frm1Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 700);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelToolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "frm1Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieShelf";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm1Main_FormClosing);
            this.Load += new System.EventHandler(this.frm1Main_Load);
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.homeMenuContainer.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Label lblTitle;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnActors;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnDirectors;
        private System.Windows.Forms.Button btnCountries;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.FlowLayoutPanel homeMenuContainer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer homeMenuTransition;
        private System.Windows.Forms.FlowLayoutPanel panelSidebar;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Button btnSubscription;
        private System.Windows.Forms.Button btnUsers;
    }
}

