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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        QLBanHang1Context ql = new QLBanHang1Context();
        public Window2()
        {
            InitializeComponent();
            ThongKe();
        }

        private void ThongKe()
        {
            var query1 = from sp in ql.SanPhams
                         join lsp in ql.LoaiSps
                         on sp.MaLoai equals lsp.MaLoai
                         select new
                         {
                            sp.MaSp,
                            sp.TenSp,
                            lsp.TenLoai,
                            sp.SoLuongCo,
                             TongTien = sp.SoLuongCo * sp.DonGia
                         };
            dgDSTK.ItemsSource = query1.ToList();
        }
    }
}
