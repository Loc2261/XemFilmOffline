using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using XemPhimOffline.Models;

namespace XemPhimOffline.GUI
{
    public partial class frmRegister : Form
    {
        private readonly PhimDBContext _context = new PhimDBContext();

        public frmRegister()
        {
            InitializeComponent();
        }

        private bool isDateValueChanging = false;
        private void dateTimeNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            if (isDateValueChanging)
                return;

            DateTime selectedDate = dateTimeNgaySinh.Value;
            DateTime today = DateTime.Today;
            int age = today.Year - selectedDate.Year;

            if (selectedDate > today.AddYears(-age))
            {
                age--;
            }

            if (age < 14)
            {
                MessageBox.Show("Bạn phải trên 14 tuổi để đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                isDateValueChanging = true;
                dateTimeNgaySinh.Value = today;
                isDateValueChanging = false;
            }
        }

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbxShowPass.Checked ? '\0' : '*';
            txtRedeemPass.PasswordChar = cbxShowPass.Checked ? '\0' : '*';
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi");
                return;
            }

            if (!txtEmail.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email phải có đuôi @gmail.com", "Lỗi");
                return;
            }

            if (txtPassword.Text != txtRedeemPass.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!", "Lỗi");
                return;
            }

            string passwordPattern = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$";
            if (!Regex.IsMatch(txtPassword.Text, passwordPattern))
            {
                MessageBox.Show("Mật khẩu phải chứa ít nhất 8 ký tự, bao gồm ít nhất một chữ cái, một số và một ký tự đặc biệt.", "Lỗi");
                return;
            }

            try
            {
                // Check if the username or email already exists
                bool userExists = _context.Accounts.Any(a => a.TaiKhoan == txtUsername.Text || a.Email == txtEmail.Text);
                if (userExists)
                {
                    MessageBox.Show("Tên đăng nhập hoặc email đã tồn tại!", "Lỗi");
                    return;
                }

                // Create a new user
                var newAccount = new Account
                {
                    MaTaiKhoan = _context.Accounts.Max(a => a.MaTaiKhoan) + 1, // Increment the primary key
                    Email = txtEmail.Text,
                    TaiKhoan = txtUsername.Text,
                    MatKhau = txtPassword.Text,
                    NgaySinh = dateTimeNgaySinh.Value,
                    LoaiTaiKhoan = 0 // Assuming default is regular user (0)
                };

                _context.Accounts.Add(newAccount);
                _context.SaveChanges();

                MessageBox.Show("Đăng ký thành công!");

                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa các trường thông tin không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                txtEmail.Clear();
                txtPassword.Clear();
                txtRedeemPass.Clear();
                txtUsername.Clear();
                MessageBox.Show("Các trường thông tin đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Các trường thông tin không bị xóa.", "Thông báo");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                frmLogin login = new frmLogin();
                login.Show();
            }
            else e.Cancel = true;
        }
    }
}
