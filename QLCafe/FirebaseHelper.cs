using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace QLCafe
{
    public class FirebaseHelper
    {
        // 1. Cấu hình kết nối
        private static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "dRepS8RkauZPZRHBfedxTsDTZ6r67VatFSP7LvNw",
            BasePath = "https://qlcafe-b621b-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        public static IFirebaseClient client;

        // 2. Hàm khởi tạo kết nối
        public static void Initialize()
        {
            client = new FireSharp.FirebaseClient(config);
        }
    }
}