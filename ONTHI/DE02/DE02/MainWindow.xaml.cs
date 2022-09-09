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
using DE02.Models;

namespace DE02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QuanLySanPhamDBContext ql = new QuanLySanPhamDBContext();
        public MainWindow()
        {
            InitializeComponent();
            LoadItem();
            DTComBobox();
        }

        private void DTComBobox()
        {
            var qr = from nh in ql.NhomHangs
                     select nh.MaNhomHang;
            cbbNhomHang.ItemsSource = qr.ToList();
        }

        private void LoadItem()
        {
            var qr = from nh in ql.NhomHangs
                     join sp in ql.SanPhams
                     on nh.MaNhomHang equals sp.MaNhomHang
                     orderby sp.SoLuongBan descending
                     select new
                     {
                         sp.MaSp,
                         sp.TenSanPham,
                         sp.DonGia,
                         sp.SoLuongBan,
                         nh.TenNhomHang,
                         TienBan = sp.DonGia*sp.SoLuongBan
                     };
            dgDSSP.ItemsSource = qr.ToList();
        }
        private void Hienthi()
        {
            var qr = from nh in ql.NhomHangs
                     join sp in ql.SanPhams
                     on nh.MaNhomHang equals sp.MaNhomHang
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
        private void Clear()
        {
            txtmasp.Clear();
            txttensp.Clear();
            txtdongia.Clear();
            txtslban.Clear();
            cbbNhomHang.SelectedIndex = 0;
            txtmasp.Focus();
        }

        private void dgDSSP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = dgDSSP.SelectedItem;
            if(item != null)
            {
                var _nhomhang = (dgDSSP.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                var _manhomhang = (from nh in ql.NhomHangs
                                   where nh.TenNhomHang == _nhomhang
                                   select nh.MaNhomHang).Single();
                cbbNhomHang.SelectedItem = _manhomhang;
            }
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            int num1;
            bool ktmasp = Int32.TryParse(txtmasp.Text, out num1);
            int num2;
            bool ktslban = Int32.TryParse(txtslban.Text, out num2);
            double num3;
            bool ktdongia = Double.TryParse(txtdongia.Text, out num3);
            try
            {
                if (txtmasp.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                if (txttensp.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                if (txtdongia.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                if (txtslban.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                if (!ktmasp)
                    throw new Exception("Nhập chưa đúng định dạng mã sp");
                if (!ktdongia)
                    throw new Exception("Nhập chưa đúng định dạng đơn giá");
                if (!ktslban)
                    throw new Exception("Nhập chưa đúng định dạng số lượng bán");
                var _masp = (from sp1 in ql.SanPhams
                             where sp1.MaSp == Int32.Parse(txtmasp.Text)
                             select sp1.MaSp).SingleOrDefault();
                if (_masp != 0)
                    throw new Exception("Trùng mã sản phẩm");
                int sl = Int32.Parse(txtslban.Text);
                if (sl < 1)
                    throw new Exception("Số lượng bán phải lớn hơn 1");

                SanPham sp = new SanPham();
                sp.MaSp = Int32.Parse(txtmasp.Text);
                sp.TenSanPham = txttensp.Text;
                sp.DonGia = Double.Parse(txtdongia.Text);
                sp.SoLuongBan = Int32.Parse(txtslban.Text);
                sp.MaNhomHang = Int32.Parse(cbbNhomHang.Text);
                sp.TienBan = (double)sp.DonGia * sp.SoLuongBan;
                ql.SanPhams.Add(sp);
                ql.SaveChanges();
                Clear();
                Hienthi();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.ShowDialog();
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            int num1;
            bool ktmasp = Int32.TryParse(txtmasp.Text, out num1);
            int num2;
            bool ktslban = Int32.TryParse(txtslban.Text, out num2);
            double num3;
            bool ktdongia = Double.TryParse(txtdongia.Text, out num3);
            try
            {
                if (txtmasp.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                if (txttensp.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                if (txtdongia.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                if (txtslban.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                if (!ktmasp)
                    throw new Exception("Nhập chưa đúng định dạng mã sp");
                if (!ktdongia)
                    throw new Exception("Nhập chưa đúng định dạng đơn giá");
                if (!ktslban)
                    throw new Exception("Nhập chưa đúng định dạng số lượng bán");
                int sl = Int32.Parse(txtslban.Text);
                if (sl < 1)
                    throw new Exception("Số lượng bán phải lớn hơn 1");

                var item = dgDSSP.SelectedItem;
                string _masp = (dgDSSP.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                if (_masp != txtmasp.Text)
                    throw new Exception("Không được thay đổi mã sản phẩm");

                MessageBoxResult mbr = MessageBox.Show("Bạn có chắc chắn muôn sửa?", "Thông báo", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                if(mbr == MessageBoxResult.Yes)
                {
                    var item2 = (from sp in ql.SanPhams
                                 where sp.MaSp == Int32.Parse(txtmasp.Text)
                                 select sp).Single();
                    item2.TenSanPham = txttensp.Text;
                    item2.DonGia = Double.Parse(txtdongia.Text);
                    item2.SoLuongBan = Int32.Parse(txtslban.Text);
                    item2.MaNhomHang = Int32.Parse(cbbNhomHang.Text);
                    item2.TienBan = item2.SoLuongBan * item2.DonGia;
                    ql.SaveChanges();
                    Clear();
                    Hienthi();
                    MessageBox.Show("Đã sửa nhân viên");
                }
                else
                {
                    throw new Exception("Đã hủy thao tác sửa");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbr = MessageBox.Show("Bạn có chắc chắn muôn xóa?", "Thông báo", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (mbr == MessageBoxResult.Yes)
            {
                var item2 = (from sp in ql.SanPhams
                             where sp.MaSp == Int32.Parse(txtmasp.Text)
                             select sp).Single();
                ql.SanPhams.Remove(item2);
                ql.SaveChanges();
                Clear();
                Hienthi();
                MessageBox.Show("Đã xóa nhân viên");
            }
            else
            {
                MessageBox.Show("Đã hủy thao tác xóa");
            }
        }

        private void btnThongke_Click(object sender, RoutedEventArgs e)
        {
            Window2 w = new Window2();
            w.ShowDialog();
        }
    }
}
