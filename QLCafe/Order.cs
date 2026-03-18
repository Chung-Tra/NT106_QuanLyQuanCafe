using System.Collections.Generic;

namespace QLCafe
{
    public class OrderItem
    {
        public string? name { get; set; }
        public int? quantity { get; set; }
        public string? status { get; set; } // Ví dụ: cooking, served
    }

    public class Order
    {
        public string tableId { get; set; }
        public string staffId { get; set; }
        public Dictionary<string, OrderItem> items { get; set; }
        public int totalPrice { get; set; }
        public string orderStatus { get; set; } // pending, completed
        public string paymentMethod { get; set; }
        public long timestamp { get; set; }
    }
}
