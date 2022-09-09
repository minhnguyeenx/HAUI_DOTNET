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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DE03.Models;

namespace DE03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLNhanvienContext ql = new QLNhanvienContext();
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            LoadItem();
            DataComboBox();
            //HienThi();
        }

        private void DataComboBox()
        {
            var query = from pb in ql.PhongBans
                        select pb.TenPhong;
            cbbMaPhong.ItemsSource = query.ToList();
        }

        private void LoadItem()
        {
            var query = from pb in ql.PhongBans
                        join nv in ql.Nhanviens
                        on pb.MaPhong equals nv.MaPhong
                        select new
                        {
                            MaPhong = nv.MaPhong,
                            MaNv = nv.MaNv,
                            HoTen = nv.Hoten,
                            Luong = nv.Luong,
                            Thuong = nv.Thuong,
                            TongTien = nv.Luong + nv.Thuong
                        };
            dgDSNV.ItemsSource = query.ToList();
        }
        private void HienThi()
        {
            var query = from pb in ql.PhongBans
                        join nv in ql.Nhanviens
                        on pb.MaPhong equals nv.MaPhong
                        where (nv.Luong+nv.Thuong) > 5000
                        orderby nv.Luong ascending
                        select new
                        {
                            MaPhong = nv.MaPhong,
                            MaNv = nv.MaNv,
                            HoTen = nv.Hoten,
                            Luong = nv.Luong,
                            Thuong = nv.Thuong,
                            TongTien = nv.Luong + nv.Thuong
                        };
            dgDSNV.ItemsSource = query.ToList();
        }

        private void Clear()
        {
            txtHoTen.Clear();
            txtMaNv.Clear();
            txtLuong.Clear();
            txtThuong.Clear();
            cbbMaPhong.SelectedIndex = 0;
            txtMaNv.Focus();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            int num1;
            bool ktLuong = Int32.TryParse(txtLuong.Text, out num1);
            int num2;
            bool ktThuong = Int32.TryParse(txtThuong.Text, out num2);
            try
            {
                if (txtMaNv.Text == "")
                    throw new Exception("Vui long nhap ma nhan vien");
                if(txtHoTen.Text == "")
                    throw new Exception("Vui long nhap ho ten");
                if (txtLuong.Text == "")
                    throw new Exception("Vui long nhap Luong");
                if (txtThuong.Text == "")
                    throw new Exception("Vui long nhap Thuong");
                if (!ktLuong)
                    throw new Exception("Nhập không đúng định dạng lương");
                if(!ktThuong)
                    throw new Exception("Nhập không đúng định dạng thưởng");
                int L = Int32.Parse(txtLuong.Text);
                int T = Int32.Parse(txtThuong.Text);
                if (L < 3000 || L > 9000)
                    throw new Exception("Vui lòng nhập lương từ 3000 đến 9000");
                if (T < 100 || T > 900)
                    throw new Exception("Vui lòng nhập thưởng từ 100 đến 900");
                //string manv = "";
                var manv = (from nv in ql.Nhanviens
                           where nv.MaNv == txtMaNv.Text
                           select nv.MaNv).SingleOrDefault();
                if (manv != null)
                    throw new Exception("Trùng mã nhân viên");
                Nhanvien nv2 = new Nhanvien();
                 nv2.MaNv = txtMaNv.Text;
                 nv2.Hoten = txtHoTen.Text;
                 nv2.Luong = Int32.Parse(txtLuong.Text);
                 nv2.Thuong = Int32.Parse(txtThuong.Text);
                 var maphong = (from pb in ql.PhongBans
                                where pb.TenPhong == cbbMaPhong.Text
                                select pb.MaPhong).Single();
                 nv2.MaPhong = maphong;
                 ql.Nhanviens.Add(nv2);
                 ql.SaveChanges();
                 Clear();
                 LoadItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgDSNV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = dgDSNV.SelectedItem;
            if(item != null)
            {
                string map = (dgDSNV.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                var tenp = (from pb in ql.PhongBans
                           where map == pb.MaPhong
                           select pb.TenPhong).Single();
                cbbMaPhong.SelectedItem = tenp;
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            int num1;
            bool ktLuong = Int32.TryParse(txtLuong.Text, out num1);
            int num2;
            bool ktThuong = Int32.TryParse(txtThuong.Text, out num2);
            try
            {
                if (txtMaNv.Text == "")
                    throw new Exception("Vui long nhap ma nhan vien");
                if (txtHoTen.Text == "")
                    throw new Exception("Vui long nhap ho ten");
                if (txtLuong.Text == "")
                    throw new Exception("Vui long nhap Luong");
                if (txtThuong.Text == "")
                    throw new Exception("Vui long nhap Thuong");
                if (!ktLuong)
                    throw new Exception("Nhập không đúng định dạng lương");
                if (!ktThuong)
                    throw new Exception("Nhập không đúng định dạng thưởng");
                int L = Int32.Parse(txtLuong.Text);
                int T = Int32.Parse(txtThuong.Text);
                if (L < 3000 || L > 9000)
                    throw new Exception("Vui lòng nhập lương từ 3000 đến 9000");
                if (T < 100 || T > 900)
                    throw new Exception("Vui lòng nhập thưởng từ 100 đến 900");
                var item = dgDSNV.SelectedItem;
                string manv = (dgDSNV.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                if (manv != txtMaNv.Text)
                    throw new Exception("Không được thay đổi mã nhân viên");
                MessageBoxResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa mã nhân viên", "Thông báo", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                if (dialogResult == MessageBoxResult.Yes)
                {
                    var item2 = (from nv in ql.Nhanviens
                                 where nv.MaNv == txtMaNv.Text
                                 select nv).SingleOrDefault();
                    if(item2 == null)
                        throw new Exception("Không tìm thấy nhân viên này");
                    item2.MaNv = txtMaNv.Text;
                    item2.Hoten = txtHoTen.Text;
                    item2.Luong = Int32.Parse(txtLuong.Text);
                    item2.Thuong = Int32.Parse(txtThuong.Text);
                    string map = (from pb in ql.PhongBans
                                  where pb.TenPhong == cbbMaPhong.Text
                                  select pb.MaPhong).Single();
                    item2.MaPhong = map;
                    ql.SaveChanges();
                    Clear();
                    LoadItem();
                    MessageBox.Show("Sửa thành công");
                }
                else
                    throw new Exception("Đã hủy sửa thông tin");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            var item = dgDSNV.SelectedItem;
            string manv = (dgDSNV.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            MessageBoxResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa mã nhân viên", "Thông báo", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (dialogResult == MessageBoxResult.Yes)
            {
                var item2 = (from nv in ql.Nhanviens
                             where nv.MaNv == txtMaNv.Text
                             select nv).SingleOrDefault();
                if (item2 == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên này");
                    return;
                }
                ql.Nhanviens.Remove(item2);
                ql.SaveChanges();
                Clear();
                LoadItem();
                MessageBox.Show("Xóa thành công");
            }
            else
                MessageBox.Show("Đã hủy xóa nhân viên");
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.ShowDialog();
        }

    }
}
