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
using DE01.Models;

namespace DE01
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        QuanLyBenhNhanDBContext ql = new QuanLyBenhNhanDBContext();
        List<BenhNhan> li = new List<BenhNhan>();
        public Window2()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            LoadItem();
        }

        private void LoadItem()
        {
            var query = from bn in ql.BenhNhans
                        group bn by bn.MaKhoa into NhomKhoa
                        select new
                        {
                            mk = NhomKhoa.Key,
                            SLNV = NhomKhoa.Count(),
                            TongVP = NhomKhoa.Sum(prod => prod.VienPhi)
                        };
            var queryHienThi = from qr in query
                               join k in ql.Khoas
                               on qr.mk equals k.MaKhoa
                               select new
                               {
                                   k.MaKhoa,
                                   k.TenKhoa,
                                   qr.SLNV,
                                   qr.TongVP
                               };
            dgDSPK.ItemsSource = queryHienThi.ToList();
        }
    }
}
