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
using DE03.Models;

namespace DE03
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        QLNhanvienContext ql = new QLNhanvienContext();
        public Window1()
        {
            InitializeComponent();
            Tim();
        }

        private void Tim()
        {
            var item1 = from nv in ql.Nhanviens
                        group nv by nv.MaPhong into thongke1
                        select new
                        {
                            mp = thongke1.Key,
                            slnv = thongke1.Count(),
                            TongLuong = thongke1.Sum(prod => prod.Luong)
                        };
            var item2 = from tk in item1
                        join pb in ql.PhongBans
                        on tk.mp equals pb.MaPhong
                        select new
                        {
                            pb.MaPhong,
                            pb.TenPhong,
                            tk.slnv,
                            tk.TongLuong
                        };
            dgDSTK.ItemsSource = item2.ToList();
        }
    }
}
