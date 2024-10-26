using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XemPhimOffline.Models;
using static XemPhimOffline.GUI.frmLanguage;

namespace XemPhimOffline.GUI
{
    public partial class frmCountry : Form
    {
        private PhimDBContext db = new PhimDBContext();
        public frmCountry()
        {
            InitializeComponent();
            LoadCountries();
            LoadCountry1();
            Form_Resize(null,null);
            this.Resize += Form_Resize;
        }
        private void Form_Resize(object sender, EventArgs e)
        {
            // Calculate the half width of the form
            int halfWidth = this.ClientSize.Width / 2;

            // Calculate the vertical position for the DataGridViews (below the button)
            int topPosition = btnAddCountry.Bottom;
            int formHeight = this.ClientSize.Height - topPosition; // Adjust the height to fit below the button

            // Adjust the first DataGridView (left half)
            dgvCountries.Width = halfWidth;
            dgvCountries.Height = formHeight;
            dgvCountries.Location = new Point(0, topPosition); // Positioned below the button

            // Adjust the second DataGridView (right half)
            dgvCountry1.Width = halfWidth;
            dgvCountry1.Height = formHeight;
            dgvCountry1.Location = new Point(halfWidth, topPosition); // Positioned next to the first DataGridView
        }
        internal class CountriesWithMovies
        {
            public int MaQuocGia { get; set; }
            public string TenQuocGia { set; get; }
            public int MaPhim { set; get; }
        }

        private void LoadCountry1()
        {
            var countries = db.QuocGias.ToList();
            dgvCountry1.DataSource = countries;
            dgvCountry1.Columns["MaQuocGia"].HeaderText = "Country ID";
            dgvCountry1.Columns["TenQuocGia"].HeaderText = "Country Name";
        }

        // Method to load languages into the DataGridView
        private void LoadCountries()
        {
            var countries = db.Database.SqlQuery<CountriesWithMovies>("EXEC GetCountriesWithMovies").ToList(); // Fetch from DB
            dgvCountries.DataSource = countries;
            dgvCountries.Columns["MaQuocGia"].HeaderText = "Country ID";
            dgvCountries.Columns["TenQuocGia"].HeaderText = "Country Name";
            dgvCountries.Columns["MaPhim"].HeaderText = "Country's Movie";
        }

        private void btnDeleteCountry_Click(object sender, EventArgs e)
        {
            // Check if the user has entered a Country ID
            if (!string.IsNullOrEmpty(txtCountryID.Text))
            {
                int countryID;
                // Validate if the input is a number
                if (int.TryParse(txtCountryID.Text.Trim(), out countryID))
                {
                    // Find the country in the database by its ID
                    var countryToDelete = db.QuocGias.Find(countryID);

                    if (countryToDelete != null && chkAlwaysAsk.Checked == true)
                    {
                        var confirmationResult = MessageBox.Show(
                            $"Are you sure you want to delete the country '{countryToDelete.TenQuocGia}'? This will delete all associated movies",
                            "Confirm Delete. This will delete all associated movies",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        // Remove the country from the database
                        if (confirmationResult == DialogResult.Yes)
                        {
                            db.QuocGias.Remove(countryToDelete);
                            db.SaveChanges();
                            LoadCountries();
                            MessageBox.Show("Country deleted successfully!");
                        }
                    } else if(countryToDelete != null)
                        {
                            db.QuocGias.Remove(countryToDelete);
                            db.SaveChanges();
                            LoadCountries();
                            MessageBox.Show("Country deleted successfully!");
                        }
                    else
                    {
                        MessageBox.Show("Country with the specified ID does not exist.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric Country ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter the Country ID to delete.");
            }
        }


        private void btnEditCountry_Click(object sender, EventArgs e)
        {
            // Check if the user has entered both the Country ID and the new Country Name
            if (!string.IsNullOrEmpty(txtCountryID.Text) && !string.IsNullOrEmpty(txtCountryName.Text))
            {
                int countryID;
                // Validate if the input is a number
                if (int.TryParse(txtCountryID.Text.Trim(), out countryID))
                {
                    // Find the country in the database by its ID
                    var countryToEdit = db.QuocGias.Find(countryID);

                    if (countryToEdit != null && chkAlwaysAsk.Checked == true)
                    {
                        var confirmationResult = MessageBox.Show(
                            $"Are you sure you want to edit the country '{countryToEdit.TenQuocGia}'?",
                            "Confirm Edit",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        // Update the country name
                        if (confirmationResult == DialogResult.Yes)
                        {
                            countryToEdit.TenQuocGia = txtCountryName.Text.Trim();
                            db.SaveChanges();
                            LoadCountries();
                            MessageBox.Show("Country updated successfully!");
                        }
                    }else if(countryToEdit != null)
                        {
                            countryToEdit.TenQuocGia = txtCountryName.Text.Trim();
                            db.SaveChanges();
                            LoadCountries();
                            MessageBox.Show("Country updated successfully!");
                        }
                    else
                    {
                        MessageBox.Show("Country with the specified ID does not exist.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric Country ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both the Country ID and the new Country Name.");
            }
        }


        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCountryID.Text) && !string.IsNullOrEmpty(txtCountryName.Text))
            {
                int countryID;
                // Validate if the input is a number
                if (int.TryParse(txtCountryID.Text.Trim(), out countryID))
                {
                    // Check if a country with the same ID already exists in the database
                    var existingCountry = db.QuocGias.FirstOrDefault(c => c.MaQuocGia == countryID);

                    if (existingCountry != null)
                    {
                        MessageBox.Show("A country with this ID already exists!");
                    }
                    else
                    {
                        var newCountry = new QuocGia
                        {
                            MaQuocGia = countryID,
                            TenQuocGia = txtCountryName.Text.Trim()
                        };
                        db.QuocGias.Add(newCountry);
                        db.SaveChanges();
                        LoadCountries();
                        MessageBox.Show("Country added successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric country ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both the country ID and country name.");
            }

        }

        private void dgvCountries_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCountries.SelectedRows.Count > 0)
            {
                txtCountryID.Text = dgvCountries.SelectedRows[0].Cells["MaQuocGia"].Value.ToString();
                txtCountryName.Text = dgvCountries.SelectedRows[0].Cells["TenQuocGia"].Value.ToString();
            }
        }

        private void frmCountry_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void dgvCountry1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCountry1.SelectedRows.Count > 0)
            {
                txtCountryID.Text = dgvCountry1.SelectedRows[0].Cells["MaQuocGia"].Value.ToString();
                txtCountryName.Text = dgvCountry1.SelectedRows[0].Cells["TenQuocGia"].Value.ToString();
            }
        }
    }
}
