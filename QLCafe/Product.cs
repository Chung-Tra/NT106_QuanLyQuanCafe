using System.Collections.Generic;

namespace QLCafe
{
    public class MenuItem
    {
        public string name { get; set; }
        public int price { get; set; }
        public string status { get; set; }
    }

    public class Category
    {
        public string name { get; set; }
        public Dictionary<string, MenuItem> items { get; set; }
    }
}