using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System.Linq;

namespace QLCafe
{
    public partial class FormDanhSach : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "dRepS8RkauZPZRHBfedxTsDTZ6r67VatFSP7LvNw",
            BasePath = "https://qlcafe-b621b-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        public FormDanhSach()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void LoadUsersToGrid()
        {
            try
            {
                // 1. Gọi đúng node "User"
                FirebaseResponse response = await client.GetAsync("Users");

                // 2. Kiểm tra nếu node "User" hoàn toàn không tồn tại trên DB
                if (response == null || response.Body == "null")
                {
                    MessageBox.Show("Không tìm thấy node 'User'. Hãy kiểm tra lại tên node trên Firebase!");
                    return;
                }

                // 3. Giải mã dữ liệu
                var data = JsonConvert.DeserializeObject<Dictionary<string, User>>(response.Body);

                if (data != null && data.Count > 0)
                {
                    var userList = data.Values.ToList();

                    // 1. Tắt chế độ tự động và dọn sạch bảng (Hủy bỏ mọi cấu hình cũ)
                    dgvUsers.AutoGenerateColumns = false;
                    dgvUsers.Columns.Clear();

                    // 2. Tự tay tạo và ép bảng phải hiện từng cột
                    // Lưu ý: DataPropertyName PHẢI gõ giống y hệt chữ trong Class User của bạn
                    dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "fullName", // Liên kết với public string? fullName
                        HeaderText = "Họ và Tên"
                    });

                    dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "role",
                        HeaderText = "Chức vụ"
                    });

                    dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "status",
                        HeaderText = "Trạng thái"
                    });
                    dgvUsers.Columns.Add(new DataGridViewTextBoxColumn {
                        DataPropertyName = "username", // Liên kết với public string? username
                        HeaderText = "Tên đăng nhập"
                    });

                    dgvUsers.Columns.Add(new DataGridViewTextBoxColumn {
                        DataPropertyName = "password", // Liên kết với public string? password
                        HeaderText = "Mật khẩu"
                    });

                    

                    // Căn đều các cột cho đẹp
                    dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // 3. Đổ dữ liệu vào bảng (bây giờ nó bắt buộc phải chạy theo khung mình vừa tạo)
                    dgvUsers.DataSource = null;
                    dgvUsers.DataSource = userList;
                }
                else
                {
                    MessageBox.Show("Node 'Users' tồn tại nhưng bên trong không có dữ liệu!");
                }

            }
            catch (Exception ex)
            {
                // Hiện lỗi chi tiết để biết sai ở đâu (ví dụ sai Class User)
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void FormDanhSach_Load(object sender, EventArgs e)
        {

            LoadUsersToGrid();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
