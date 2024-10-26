using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XemPhimOffline.GUI
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();

            progressBarLoading.Maximum = 100; // Set the maximum value for progress bar
            progressBarLoading.Value = 0; // Ensure it starts at 0

            timer1.Tick += timer1_Tick; // Attach the Tick event handler
            timer1.Start(); // Start the timer when form loads
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBarLoading.Value < progressBarLoading.Maximum)
            {
                progressBarLoading.Value += 1; // Increment progress bar by 1
                lblNumber.Text = progressBarLoading.Value.ToString(); // Update label with percentage
            }
            else
            {
                timer1.Stop(); // Stop the timer once progress bar reaches 100%
                this.Close(); // Close the loading form

                // Open the main form or perform any other action here
                // MainForm mainForm = new MainForm();
                // mainForm.Show();
            }
        }
    }
}
