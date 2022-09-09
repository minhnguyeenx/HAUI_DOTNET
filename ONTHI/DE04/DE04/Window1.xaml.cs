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
using DE04.Models;

namespace DE04
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        QLBanHang1Context ql = new QLBanHang1Context();
        public Window1()
        {
            InitializeComponent();
            Tim();
        }

        private void Tim()
        {
            var qr1 = from sp in ql.SanPhams
                      group sp by sp.MaLoai into thongke
                      select new
                      {
                          MaLoai = thongke.Key,
                          TongSL = thongke.Count(),
                          TongTien = thongke.Sum(prod => prod.SoLuongCo * prod.DonGia)
                      };
            var qr2 = from lsp in ql.LoaiSps
                      join qr in qr1
                      on lsp.MaLoai equals qr.MaLoai
                      select new
                      {
                          lsp.MaLoai,
                          lsp.TenLoai,
                          qr.TongSL,
                          qr.TongTien
                      };
            dgDSTK.ItemsSource = qr2.ToList();
        }
    }
}
