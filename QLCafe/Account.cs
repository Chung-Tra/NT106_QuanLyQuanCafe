using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe
{
    public class Attendance
    {
        public string checkIn { get; set; }
        public string checkOut { get; set; }
    }

    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }
        public string role { get; set; }
        public string status { get; set; }
        public Dictionary<string, Attendance> attendance { get; set; }
    }
}
