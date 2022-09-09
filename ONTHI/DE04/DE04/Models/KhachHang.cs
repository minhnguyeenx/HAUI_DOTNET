using System;
using System.Collections.Generic;

namespace DE04.Models
{
    public partial class KhachHang
    {
        public string MaKh { get; set; } = null!;
        public string? HoTen { get; set; }
        public string? GioiTinh { get; set; }
    }
}
