using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XemPhimOffline
{
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
        }
        private void Form_Resize(object sender, EventArgs e)
        {
            // Calculate the half width of the form
            int halfWidth = this.ClientSize.Width / 2;

            // Calculate the vertical position for the DataGridViews (below the button)
            int topPosition = btnSubMit.Bottom;
            int formHeight = this.ClientSize.Height - topPosition; // Adjust the height to fit below the button

            // Adjust the first DataGridView (left half)
            dgvFilmRating.Width = halfWidth;
            dgvFilmRating.Height = formHeight;
            dgvFilmRating.Location = new Point(0, topPosition); // Positioned below the button

            // Adjust the second DataGridView (right half)
            dgvFilmRating.Width = halfWidth;
            dgvFilmRating.Height = formHeight;
            dgvFilmRating.Location = new Point(halfWidth, topPosition); // Positioned next to the first DataGridView
        }

        private void pictureBoxReturnMenu_Click(object sender, EventArgs e)
        {

        }
    }

}
