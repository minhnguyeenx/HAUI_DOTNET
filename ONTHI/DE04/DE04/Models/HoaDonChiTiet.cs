using System;
using System.Collections.Generic;

namespace DE04.Models
{
    public partial class HoaDonChiTiet
    {
        public string MaHd { get; set; } = null!;
        public string MaSp { get; set; } = null!;
        public DateTime? NgayBan { get; set; }
        public int? SoLuongMua { get; set; }

        public virtual SanPham MaSpNavigation { get; set; } = null!;
    }
}
