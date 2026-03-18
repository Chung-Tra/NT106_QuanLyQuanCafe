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
        public string? username { get; set; } = null;
        public string? password { get; set; } = null;
        public string? fullName { get; set; } = null;
        public string? role { get; set; } = null;
        public string? status { get; set; } = null;
        public Dictionary<string, Attendance> attendance { get; set; }
    }
}
