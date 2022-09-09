using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DE02.Models;

namespace DE02
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        QuanLySanPhamDBContext ql = new QuanLySanPhamDBContext();
        public Window1()
        {
            InitializeComponent();
            Tim();
        }

        private void Tim()
        {
            var qr = from nh in ql.NhomHangs
                     join sp in ql.SanPhams
                     on nh.MaNhomHang equals sp.MaNhomHang
                     where nh.MaNhomHang == 1
                     select new
                     {
                         sp.MaSp,
                         sp.TenSanPham,
                         sp.DonGia,
                         sp.SoLuongBan,
                         nh.TenNhomHang,
                         TienBan = sp.DonGia * sp.SoLuongBan
                     };
            dgDSSP.ItemsSource = qr.ToList();
        }
    }
}
