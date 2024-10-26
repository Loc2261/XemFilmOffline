using ReaLTaiizor.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XemPhimOffline.GUI;

namespace XemPhimOffline
{
    public partial class frm1Main : Form
    {
        frmLanguage language;
        frmCountry country;
        frmDirector director;
        public frm1Main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        bool homeMenuExpand = false;
        private void homeMenuTransition_Tick(object sender, EventArgs e)
        {
            if (homeMenuExpand == false)
            {
                homeMenuContainer.Height += 10;
                if(homeMenuContainer.Height >= 610)
                {
                    homeMenuTransition.Stop();
                    homeMenuExpand = true; 
                }
            }
            else
            {
                homeMenuContainer.Height -= 10;
                if (homeMenuContainer.Height <= 63)
                {
                    homeMenuTransition.Stop();
                    homeMenuExpand = false;
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            homeMenuTransition.Start();
        }

        bool sidebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                panelSidebar.Width -= 4;
                if(panelSidebar.Width <= 76)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                panelSidebar.Width += 10;
                if(panelSidebar.Width >= 200)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void frm1Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            if (language == null)
            {
                language = new frmLanguage();
                language.FormClosed += Language_FormClosed;
                language.MdiParent = this;
                language.Dock = DockStyle.Fill;
                language.Show();
            }
            else
            {
                language.Activate();
            }
        }

        private void Language_FormClosed(object sender, FormClosedEventArgs e)
        {
            language = null;
        }

        private void btnCountries_Click(object sender, EventArgs e)
        {
            if (country == null)
            {
                country = new frmCountry();
                country.FormClosed += Country_FormClosed;
                country.MdiParent = this;
                country.Dock = DockStyle.Fill;
                country.Show();
            }
            else
            {
                country.Activate();
            }
        }

        private void Country_FormClosed(object sender, FormClosedEventArgs e)
        {
            country = null; 
        }

        private void btnDirectors_Click(object sender, EventArgs e)
        {
            if (director == null)
            {
                director = new frmDirector();
                director.FormClosed += Country_FormClosed;
                director.MdiParent = this;
                director.Dock = DockStyle.Fill;
                director.Show();
            }
            else
            {
                director.Activate();
            }
        }

        private void btnActors_Click(object sender, EventArgs e)
        {

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {

        }

        private void btnMovies_Click(object sender, EventArgs e)
        {

        }

        private void frm1Main_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void btnSubscription_Click(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

        }
    }
}
