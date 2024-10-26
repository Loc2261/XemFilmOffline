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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmPayment_Load(object sender, EventArgs e)
        {
            // Thiết lập các tùy chọn cho ComboBox thời hạn thanh toán
            cmbDateRegister.Items.Add("1 tháng");
            cmbDateRegister.Items.Add("6 tháng");
            cmbDateRegister.Items.Add("1 năm");

            // Đặt mặc định là "1 tháng"
            cmbDateRegister.SelectedIndex = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
    }
