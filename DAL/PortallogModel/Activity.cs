using System;
using System.Collections.Generic;

namespace DAL.PortallogModel
{
    public partial class Activity
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Activity1 { get; set; } = null!;
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public TimeSpan? LoginTime { get; set; }
        public TimeSpan? LogoutTime { get; set; }
        public string? IpAddress { get; set; }
        public string? MacAddress { get; set; }
        public string? Url { get; set; }
    }
}
