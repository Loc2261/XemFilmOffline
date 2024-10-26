using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XemPhimOffline.Models;
using System.Data.Sql;
namespace XemPhimOffline.GUI
{
    public partial class frmLanguage : Form
    {
        private PhimDBContext db = new PhimDBContext();
        public frmLanguage()
        {
            InitializeComponent();
            LoadLanguages();
            LoadLanguage1();
            Form_Resize(null, null);
            this.Resize += Form_Resize;
        }
        private void Form_Resize(object sender, EventArgs e)
        {
            // Calculate the half width of the form
            int halfWidth = this.ClientSize.Width / 2;

            // Calculate the vertical position for the DataGridViews (below the button)
            int topPosition = btnAddLanguage.Bottom;
            int formHeight = this.ClientSize.Height - topPosition; // Adjust the height to fit below the button

            // Adjust the first DataGridView (left half)
            dgvLanguages.Width = halfWidth;
            dgvLanguages.Height = formHeight;
            dgvLanguages.Location = new Point(0, topPosition); // Positioned below the button

            // Adjust the second DataGridView (right half)
            dgvLanguage1.Width = halfWidth;
            dgvLanguage1.Height = formHeight;
            dgvLanguage1.Location = new Point(halfWidth, topPosition); // Positioned next to the first DataGridView
        }
        internal class LanguageWithMovie
        {
            public int MaNgonNgu { get; set; }  // Language ID
            public string TenNgonNgu { get; set; }  // Language Name
            public int MaPhim { get; set; }     // Movie Name
        }

        // Method to load languages into the DataGridView
        private void LoadLanguages()
        {
            var languages = db.Database.SqlQuery<LanguageWithMovie>("EXEC GetLanguagesWithMovies").ToList();

            // Bind the result to the DataGridView
            dgvLanguages.DataSource = languages;

            // Set the column headers
            dgvLanguages.Columns["MaNgonNgu"].HeaderText = "Language ID";
            dgvLanguages.Columns["TenNgonNgu"].HeaderText = "Language Name";
            dgvLanguages.Columns["MaPhim"].HeaderText = "Language's Movie";
        }


        private void btnDeleteLanguage_Click(object sender, EventArgs e) 
        {
            // Check if the user has entered a Language ID
            if (!string.IsNullOrEmpty(txtLanguageID.Text))
            {
                int languageID;
                // Validate if the input is a number
                if (int.TryParse(txtLanguageID.Text.Trim(), out languageID))
                {
                    // Find the language in the database by its ID
                    var languageToDelete = db.NgonNgus.Find(languageID);

                    if (languageToDelete != null && chkAlwaysAsk.Checked == true)
                    {
                        // Ask the user for confirmation before deleting
                        var confirmationResult = MessageBox.Show(
                            $"Are you sure you want to delete the language '{languageToDelete.TenNgonNgu}'? This will delete all associated movies",
                            "Confirm Delete. ",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        // Proceed with deletion if the user clicked 'Yes'
                        if (confirmationResult == DialogResult.Yes)
                        {
                            db.NgonNgus.Remove(languageToDelete);
                            db.SaveChanges();
                            LoadLanguages();
                            MessageBox.Show("Language deleted successfully!");
                        }
                    } else if(languageToDelete != null)
                        {
                            db.NgonNgus.Remove(languageToDelete);
                            db.SaveChanges();
                            LoadLanguages();
                            MessageBox.Show("Language deleted successfully!");
                        }
                    else
                    {
                        MessageBox.Show("Language with the specified ID does not exist.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric Language ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter the Language ID to delete.");
            }
        }


        private void btnEditLanguage_Click(object sender, EventArgs e)
        {
            // Check if the user has entered both the Language ID and the new Language Name
            if (!string.IsNullOrEmpty(txtLanguageID.Text) && !string.IsNullOrEmpty(txtLanguageName.Text))
            {
                int languageID;
                // Validate if the input is a number
                if (int.TryParse(txtLanguageID.Text.Trim(), out languageID))
                {
                    // Find the language in the database by its ID
                    var languageToEdit = db.NgonNgus.Find(languageID);

                    if (languageToEdit != null && chkAlwaysAsk.Checked == true)
                    {
                        var confirmationResult = MessageBox.Show(
                            $"Are you sure you want to edit the language '{languageToEdit.TenNgonNgu}'?",
                            "Confirm Edit",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        // Update the language name
                        if (confirmationResult == DialogResult.Yes)
                        {
                            languageToEdit.TenNgonNgu = txtLanguageName.Text.Trim();
                            db.SaveChanges();
                            LoadLanguages();
                            MessageBox.Show("Language updated successfully!");
                        }
                    } else if(languageToEdit != null)
                        {
                            languageToEdit.TenNgonNgu = txtLanguageName.Text.Trim();
                            db.SaveChanges();
                            LoadLanguages();
                            MessageBox.Show("Language updated successfully!");
                        }
                    else
                    {
                        MessageBox.Show("Language with the specified ID does not exist.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric Language ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both the Language ID and the new Language Name.");
            }
        }


        private void btnAddLanguage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLanguageID.Text) && !string.IsNullOrEmpty(txtLanguageName.Text))
            {
                int languageID;
                // Validate if the input is a number
                if (int.TryParse(txtLanguageID.Text.Trim(), out languageID))
                {
                    // Check if a country with the same ID already exists in the database
                    var existingCountry = db.NgonNgus.FirstOrDefault(c => c.MaNgonNgu == languageID);

                    if (existingCountry != null)
                    {
                        MessageBox.Show("A language with this ID already exists!");
                    }
                    else
                    {
                        var newLanguage = new NgonNgu
                        {
                            MaNgonNgu = languageID,
                            TenNgonNgu = txtLanguageName.Text.Trim()
                        };
                        db.NgonNgus.Add(newLanguage);
                        db.SaveChanges();
                        LoadLanguages();
                        MessageBox.Show("Language added successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric language ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both the language ID and language name.");
            }

        }

        private void dgvLanguages_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLanguages.SelectedRows.Count > 0)
            {
                txtLanguageID.Text = dgvLanguages.SelectedRows[0].Cells["MaNgonNgu"].Value.ToString();
                txtLanguageName.Text = dgvLanguages.SelectedRows[0].Cells["TenNgonNgu"].Value.ToString();
            }
        }

        private void frmLanguage_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void LoadLanguage1()
        {
            var languages = db.NgonNgus.ToList(); // Fetch from DB
            dgvLanguage1.DataSource = languages;
            dgvLanguage1.Columns["MaNgonNgu"].HeaderText = "Language ID";
            dgvLanguage1.Columns["TenNgonNgu"].HeaderText = "Language Name";
        }

        private void dgvLanguage1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLanguage1.SelectedRows.Count > 0)
            {
                txtLanguageID.Text = dgvLanguage1.SelectedRows[0].Cells["MaNgonNgu"].Value.ToString();
                txtLanguageName.Text = dgvLanguage1.SelectedRows[0].Cells["TenNgonNgu"].Value.ToString();
            }
        }
    }
}
