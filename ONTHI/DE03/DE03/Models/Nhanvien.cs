using System;
using System.Collections.Generic;

namespace DE03.Models
{
    public partial class Nhanvien
    {
        public string MaNv { get; set; } = null!;
        public string? Hoten { get; set; }
        public int? Luong { get; set; }
        public int? Thuong { get; set; }
        public string? MaPhong { get; set; }

        public virtual PhongBan? MaPhongNavigation { get; set; }
    }
}
