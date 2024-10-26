using System;
using System.Linq;
using System.Windows.Forms;
using XemPhimOffline.Models; // Namespace containing PhimDBContext and Account

namespace XemPhimOffline.GUI
{
    public partial class frmLogin : Form
    {
        private readonly PhimDBContext _context = new PhimDBContext();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa các trường thông tin không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
                MessageBox.Show("Các trường thông tin đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string input = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Check if fields are empty
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Bạn không được để trống các thông tin trên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new PhimDBContext())
            {
                try
                {
                    // Find the user by either username or email
                    var user = db.Accounts
                        .FirstOrDefault(a => (a.TaiKhoan == input || a.Email == input) && a.MatKhau == password);

                    if (user == null)
                    {
                        // Notify if credentials are incorrect
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Login successful
                        MessageBox.Show("Đăng nhập thành công!");

                        // Hide the login form
                        this.Hide();

                        // Create and show the loading form
                        frmLoading loadingForm = new frmLoading();
                        loadingForm.Show();

                        // Handle the event when loading form closes
                        loadingForm.FormClosed += (s, args) =>
                        {
                            // Determine if the user is an admin or regular user
                            if (user.LoaiTaiKhoan == 1)
                            {
                                frm1Main mainForm = new frm1Main();
                                mainForm.Show();
                            }
                            else if (user.LoaiTaiKhoan == 0)
                            {
                                frmUser userForm = new frmUser();
                                userForm.Show();
                            }
                        };
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
        }


        private void lblCreate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng ký không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                new frmRegister().Show();
                this.Hide();
            }
        }

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkboxShowPass.Checked ? '\0' : '*';
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick();
            }
        }
    }
}
