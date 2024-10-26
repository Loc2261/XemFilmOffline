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

namespace XemPhimOffline.GUI
{
    public partial class frmDirector : Form
    {
        private readonly PhimDBContext db = new PhimDBContext();
        public frmDirector()
        {
            InitializeComponent();
            LoadDirectors();
            LoadDirector1();
            // Attach the Resize event to the Form1_Resize method
            this.Resize += Form_Resize;

            // Initial positioning
            Form_Resize(null, null);
        }
        internal class DirectorsWithMovies
        {
            public int MaDaoDien { get; set; }  
            public string TenDaoDien { get; set; }  
            public string GioiTinh { get; set; }
            public DateTime NgaySinh { get; set; }
            public int MaPhim { get; set; }     
        }

        private void LoadDirector1()
        {
            var directors = db.DaoDiens.ToList();
            dgvDirector1.DataSource = directors;
            dgvDirector1.Columns["MaDaoDien"].HeaderText = "Director ID";
            dgvDirector1.Columns["TenDaoDien"].HeaderText = "Director Name";
            dgvDirector1.Columns["GioiTinh"].HeaderText = "Director Gender";
            dgvDirector1.Columns["NgaySinh"].HeaderText = "Director Brithday";
        }

        private void LoadDirectors()
        {
            var directors = db.Database.SqlQuery<DirectorsWithMovies>("EXEC GetDirectorsWithMovies").ToList();

            // Bind the result to the DataGridView
            dgvDirector.DataSource = directors;

            // Set the column headers
            dgvDirector.Columns["MaDaoDien"].HeaderText = "Director ID";
            dgvDirector.Columns["TenDaoDien"].HeaderText = "Director Name";
            dgvDirector.Columns["GioiTinh"].HeaderText = "Director Gender";
            dgvDirector.Columns["NgaySinh"].HeaderText = "Director Brithday";
            dgvDirector.Columns["MaPhim"].HeaderText = "Movie Directed";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDirectorID.Text) && !string.IsNullOrEmpty(txtDirectorName.Text) && !string.IsNullOrEmpty(txtDirectorGender.Text))
            {
                int directorID;
                // Validate if the input is a number
                if (int.TryParse(txtDirectorID.Text.Trim(), out directorID))
                {
                    // Check if a director with the same ID already exists in the database
                    var existingDirector = db.DaoDiens.FirstOrDefault(d => d.MaDaoDien == directorID);

                    if (existingDirector != null)
                    {
                        MessageBox.Show("A director with this ID already exists!");
                    }
                    else
                    {
                        var newDirector = new DaoDien
                        {
                            MaDaoDien = directorID,
                            TenDaoDien = txtDirectorName.Text.Trim(),
                            GioiTinh = txtDirectorGender.Text.Trim(),
                            NgaySinh = dtpDirectorBirthday.Value // Get birthdate from DateTimePicker
                        };
                        db.DaoDiens.Add(newDirector);
                        db.SaveChanges();
                        LoadDirectors(); // Refresh the DataGridView or list
                        MessageBox.Show("Director added successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric Director ID.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields: Director ID, Name, and Gender.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDirectorID.Text) && !string.IsNullOrEmpty(txtDirectorName.Text))
            {
                int directorID;
                // Validate if the input is a number
                if (int.TryParse(txtDirectorID.Text.Trim(), out directorID))
                {
                    // Find the director in the database by its ID
                    var directorToEdit = db.DaoDiens.Find(directorID);

                    if (directorToEdit != null)
                    {
                        var confirmationResult = MessageBox.Show(
                            $"Are you sure you want to edit the director '{directorToEdit.TenDaoDien}'?",
                            "Confirm Edit",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (confirmationResult == DialogResult.Yes)
                        {
                            // Update the director details
                            directorToEdit.TenDaoDien = txtDirectorName.Text.Trim();
                            directorToEdit.GioiTinh = txtDirectorGender.Text.Trim();
                            directorToEdit.NgaySinh = dtpDirectorBirthday.Value; // Update birthdate

                            db.SaveChanges();
                            LoadDirectors(); // Refresh the DataGridView or list
                            MessageBox.Show("Director updated successfully!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Director with the specified ID does not exist.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric Director ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both the Director ID and the new Director details.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if the user has entered a Country ID
            if (!string.IsNullOrEmpty(txtDirectorID.Text))
            {
                int directorID;
                // Validate if the input is a number
                if (int.TryParse(txtDirectorID.Text.Trim(), out directorID))
                {
                    // Find the country in the database by its ID
                    var directorToDelete = db.DaoDiens.Find(directorID);

                    if (directorToDelete != null && chkAlwaysAsk.Checked == true)
                    {
                        var confirmationResult = MessageBox.Show(
                            $"Are you sure you want to delete the director '{directorToDelete.TenDaoDien}'? This will delete all associated movies",
                            "Confirm Delete. This will delete all associated movies",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        // Remove the country from the database
                        if (confirmationResult == DialogResult.Yes)
                        {
                            db.DaoDiens.Remove(directorToDelete);
                            db.SaveChanges();
                            LoadDirectors();
                            MessageBox.Show("Director deleted successfully!");
                        }
                    }
                    else if (directorToDelete != null)
                    {
                        db.DaoDiens.Remove(directorToDelete);
                        db.SaveChanges();
                        LoadDirectors();
                        MessageBox.Show("Director deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Director with the specified ID does not exist.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric Director ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter the Director ID to delete.");
            }
        }

        private void frmDirector_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void dgvDirector_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDirector.SelectedRows.Count > 0)
            {
                // Check if any rows are selected
                if (dgvDirector.SelectedRows.Count > 0)
                {
                    // Get the currently selected row
                    var selectedRow = dgvDirector.SelectedRows[0]; // Get the first selected row

                    if (selectedRow != null)
                    {
                        // Assuming "MaDaoDien", "TenDaoDien", "GioiTinh", and "NgaySinh" are valid column names
                        txtDirectorID.Text = selectedRow.Cells["MaDaoDien"].Value?.ToString() ?? string.Empty;
                        txtDirectorName.Text = selectedRow.Cells["TenDaoDien"].Value?.ToString() ?? string.Empty;
                        txtDirectorGender.Text = selectedRow.Cells["GioiTinh"].Value?.ToString() ?? string.Empty;

                        // Ensure that the DateTimePicker can accept the value from the cell
                        if (selectedRow.Cells["NgaySinh"].Value != null &&
                            DateTime.TryParse(selectedRow.Cells["NgaySinh"].Value.ToString(), out DateTime birthday))
                        {
                            dtpDirectorBirthday.Value = birthday; // Set the parsed date
                        }
                        else
                        {
                            // Set to today's date or handle as needed when parsing fails or value is null
                            dtpDirectorBirthday.Value = DateTime.Now;
                        }
                    }
                }
            }
        }

        private void dgvDirector1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDirector1.SelectedRows.Count > 0)
            {
                // Check if any rows are selected
                if (dgvDirector1.SelectedRows.Count > 0)
                {
                    // Get the currently selected row
                    var selectedRow = dgvDirector1.SelectedRows[0]; // Get the first selected row

                    if (selectedRow != null)
                    {
                        // Assuming "MaDaoDien", "TenDaoDien", "GioiTinh", and "NgaySinh" are valid column names
                        txtDirectorID.Text = selectedRow.Cells["MaDaoDien"].Value?.ToString() ?? string.Empty;
                        txtDirectorName.Text = selectedRow.Cells["TenDaoDien"].Value?.ToString() ?? string.Empty;
                        txtDirectorGender.Text = selectedRow.Cells["GioiTinh"].Value?.ToString() ?? string.Empty;

                        // Ensure that the DateTimePicker can accept the value from the cell
                        if (selectedRow.Cells["NgaySinh"].Value != null &&
                            DateTime.TryParse(selectedRow.Cells["NgaySinh"].Value.ToString(), out DateTime birthday))
                        {
                            dtpDirectorBirthday.Value = birthday; // Set the parsed date
                        }
                        else
                        {
                            // Set to today's date or handle as needed when parsing fails or value is null
                            dtpDirectorBirthday.Value = DateTime.Now;
                        }
                    }
                }
            }
        }
        private void Form_Resize(object sender, EventArgs e)
        {
            // Calculate the half width of the form
            int halfWidth = this.ClientSize.Width / 2;

            // Calculate the vertical position for the DataGridViews (below the button)
            int topPosition = btnAdd.Bottom;
            int formHeight = this.ClientSize.Height - topPosition; // Adjust the height to fit below the button

            // Adjust the first DataGridView (left half)
            dgvDirector.Width = halfWidth;
            dgvDirector.Height = formHeight;
            dgvDirector.Location = new Point(0, topPosition); // Positioned below the button

            // Adjust the second DataGridView (right half)
            dgvDirector1.Width = halfWidth;
            dgvDirector1.Height = formHeight;
            dgvDirector1.Location = new Point(halfWidth, topPosition); // Positioned next to the first DataGridView
        }
    }
}
