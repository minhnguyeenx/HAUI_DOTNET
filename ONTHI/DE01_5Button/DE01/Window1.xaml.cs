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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        QuanLyBenhNhanDBContext ql = new QuanLyBenhNhanDBContext();
        public Window1()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Tim();
        }

        private void Tim()
        {
            var query = from k in ql.Khoas
                        join bn in ql.BenhNhans
                        on k.MaKhoa equals bn.MaKhoa
                        where bn.MaKhoa == 1
                        select new
                        {
                            bn.MaBn,
                            bn.HoTen,
                            k.TenKhoa,
                            bn.SoNgayNamVien,
                            bn.VienPhi
                        };
            dgDSBN.ItemsSource = query.ToList();
        }
    }
}
