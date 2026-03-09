namespace QLCafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FirebaseHelper.Initialize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FirebaseHelper.client != null)
            {
                MessageBox.Show("Kết nối thành công!");
            }
            else
            {
                MessageBox.Show("Kết nối thất bại, kiểm tra lại Key!");
            }
        }
    }
}
