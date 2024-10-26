using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XemPhimOffline.Models;

namespace XemPhimOffline.GUI
{
    public partial class frmPlaylist : Form
    {
        private PhimDBContext _context;
        public frmPlaylist()
        {
            InitializeComponent();
            _context = new PhimDBContext();
        }
        private void LoadFilmData()
        {
            string connectionString = "data source=LAPTOP-VAFLCLSM;initial catalog=QLAppPhim;integrated security=True";
            string query = "SELECT FilmID, FilmName, Genre FROM Films"; // Thay đổi query này để phù hợp với cấu trúc bảng của bạn

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvFilm.DataSource = dataTable; // Gán dữ liệu lên dgvFilm
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            if (dgvFilm.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFilm.SelectedRows[0];

                // Kiểm tra phim đã có trong dgvFilmLike chưa
                bool isDuplicate = false;
                foreach (DataGridViewRow row in dgvFilmLike.Rows)
                {
                    if (row.Cells["FilmID"].Value.ToString() == selectedRow.Cells["FilmID"].Value.ToString())
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    int rowIndex = dgvFilmLike.Rows.Add();
                    for (int i = 0; i < selectedRow.Cells.Count; i++)
                    {
                        dgvFilmLike.Rows[rowIndex].Cells[i].Value = selectedRow.Cells[i].Value;
                    }
                }
                else
                {
                    MessageBox.Show("Phim đã có trong danh sách yêu thích.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phim.");
            }
        }
        private void ConfigureFilmGrid()
        {
            

            // Thêm các cột cho dgvFilm
            dgvFilm.Columns.Add("FilmID", "Film ID");
            dgvFilm.Columns.Add("FilmName", "Film Name");
            dgvFilm.Columns.Add("Genre", "Genre");

            // Thiết lập các cột không thể chỉnh sửa
            dgvFilm.Columns["FilmID"].ReadOnly = true;
            dgvFilm.Columns["FilmName"].ReadOnly = true;
            dgvFilm.Columns["Genre"].ReadOnly = true;

            // Tùy chọn: Điều chỉnh kích thước cột
            dgvFilm.Columns["FilmID"].Width = 100;
            dgvFilm.Columns["FilmName"].Width = 200;
            dgvFilm.Columns["Genre"].Width = 150;
        }
        private void ConfigureFavoriteGrid()
        {
           

            // Thêm các cột cho dgvFilmLike
            dgvFilmLike.Columns.Add("FilmID", "Film ID");
            dgvFilmLike.Columns.Add("FilmName", "Film Name");
            dgvFilmLike.Columns.Add("Genre", "Genre");

            // Thiết lập các cột không thể chỉnh sửa
            dgvFilmLike.Columns["FilmID"].ReadOnly = true;
            dgvFilmLike.Columns["FilmName"].ReadOnly = true;
            dgvFilmLike.Columns["Genre"].ReadOnly = true;

            // Tùy chọn: Điều chỉnh kích thước cột
            dgvFilmLike.Columns["FilmID"].Width = 100;
            dgvFilmLike.Columns["FilmName"].Width = 200;
            dgvFilmLike.Columns["Genre"].Width = 150;
        }


        private void btnDeleteFilm_Click(object sender, EventArgs e)
        {
            if (dgvFilmLike.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn trong dgvFilmLike
                DataGridViewRow selectedRow = dgvFilmLike.SelectedRows[0];

                // Xóa hàng được chọn
                dgvFilmLike.Rows.Remove(selectedRow);
            }
        }
      

        // Sự kiện khi form được load
        private void frmPlaylist_Load(object sender, EventArgs e)
        {
            ConfigureFilmGrid();     // Cấu hình dgvFilm
            ConfigureFavoriteGrid(); // Cấu hình dgvFilmLike
            LoadFilmData();
                dgvFilmLike.ColumnCount = dgvFilm.ColumnCount;
                for (int i = 0; i < dgvFilm.ColumnCount; i++)
                {
                    dgvFilmLike.Columns[i].Name = dgvFilm.Columns[i].Name;
                    dgvFilmLike.Columns[i].HeaderText = dgvFilm.Columns[i].HeaderText;
                }
            }

        private void frmPlaylist_Load_1(object sender, EventArgs e)
        {

        }
    }
}
