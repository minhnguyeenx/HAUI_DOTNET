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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        QuanLySanPhamDBContext ql = new QuanLySanPhamDBContext();
        public Window2()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ThongKe();
        }

        private void ThongKe()
        {
            var qr1 = from sp in ql.SanPhams
                      group sp by sp.MaNhomHang into thongke
                      select new
                      {
                          MaNhomHang = thongke.Key,
                          TongNV = thongke.Count(),
                          TongTienBan = thongke.Sum(prod => prod.TienBan)
                      };
            var qr2 = from nh in ql.NhomHangs
                      join qr in qr1
                      on nh.MaNhomHang equals qr.MaNhomHang
                      select new
                      {
                          nh.MaNhomHang,
                          nh.TenNhomHang,
                          qr.TongNV,
                          qr.TongTienBan
                      };
            dgDSTK.ItemsSource = qr2.ToList();
        }
    }
}
