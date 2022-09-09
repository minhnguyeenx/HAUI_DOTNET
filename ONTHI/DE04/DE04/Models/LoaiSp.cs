﻿using System;
using System.Collections.Generic;

namespace DE04.Models
{
    public partial class LoaiSp
    {
        public LoaiSp()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public string MaLoai { get; set; } = null!;
        public string? TenLoai { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
