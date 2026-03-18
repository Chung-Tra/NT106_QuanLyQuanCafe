using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace QLCafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!");
                return;
            }

            try
            {
                // Khởi tạo kết nối Firebase (vì đây là form chạy đầu tiên)
                FirebaseHelper.Initialize();

                // Kéo danh sách Users từ Firebase về
                var response = await FirebaseHelper.client.GetAsync("Users");

                if (response.Body == "null")
                {
                    MessageBox.Show("Không có dữ liệu tài khoản trên hệ thống!");
                    return;
                }

                // Ép kiểu dữ liệu về Dictionary
                Dictionary<string, User> dictUsers = response.ResultAs<Dictionary<string, User>>();
                bool isSuccess = false;
                string role = "";

                // Chạy vòng lặp kiểm tra xem có ai khớp tài khoản & mật khẩu không
                foreach (var account in dictUsers)
                {
                    if (account.Value.username == user && account.Value.password == pass)
                    {
                        isSuccess = true;
                        role = account.Value.role; // Lấy quyền (staff, admin...)
                        break; // Tìm thấy rồi thì thoát vòng lặp luôn
                    }
                }

                if (isSuccess)
                {
                    if (role=="manager")
                    {
                        QuanLyForm QL = new QuanLyForm();
                        QL.Show(this);
                        this.Hide();
                    }
                    else if (role == "staff")
                    {
                        NhanVien NV = new NhanVien();
                        NV.Show(this);
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối mạng: " + ex.Message);
            }
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
