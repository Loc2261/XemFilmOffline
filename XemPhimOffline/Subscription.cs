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
    public partial class Subscription : Form
    {
        public Subscription()
        {
            InitializeComponent();
        }
        private void frmSubscription_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin user đã đăng nhập
            lblUsername.Text = "Tên User đăng nhập";

            // Thiết lập thông tin các gói dịch vụ
            rtxBasic.Text = "Coi được 5 phim miễn phí mỗi tuần\n" +
                            "Giới hạn các chức năng như Playlist\n" +
                            "Giá: Free";

            rtxStandard.Text = "Coi được 10 phim miễn phí mỗi tuần\n" +
                               "Mở khóa các phim được trả phí ngoài rạp\n" +
                               "Giá: 129,000 VNĐ";

            rtxPremium.Text = "Coi không giới hạn số lượng phim mỗi tuần\n" +
                              "Độ phân giải phim cao (4K)\n" +
                              "Xem phim không có quảng cáo\n" +
                              "Giá: 299,000 VNĐ";
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            frmPayment paymentForm = new frmPayment();
            paymentForm.ShowDialog();
        }
    }
}
