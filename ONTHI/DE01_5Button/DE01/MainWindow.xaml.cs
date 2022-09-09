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
using DE01.Models;
using static System.Net.Mime.MediaTypeNames;

namespace DE01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QuanLyBenhNhanDBContext ql = new QuanLyBenhNhanDBContext();
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            LoadItem();
            DataComboBox();
        }

        private void DataComboBox()
        {
            var query = from k in ql.Khoas
                        select k.MaKhoa;
            cbbKhoaKham.ItemsSource = query.ToList();
        }

        private void LoadItem()
        {
            var query = from k in ql.Khoas
                        join bn in ql.BenhNhans
                        on k.MaKhoa equals bn.MaKhoa
                        orderby bn.SoNgayNamVien descending
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
        private void HienThi()
        {
            var query = from k in ql.Khoas
                        join bn in ql.BenhNhans
                        on k.MaKhoa equals bn.MaKhoa
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

        private void Clear()
        {
            txtMaBN.Clear();
            txtHoTen.Clear();
            txtSongaynamvien.Clear();
            cbbKhoaKham.SelectedIndex = 0;
            txtMaBN.Focus();
        }
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            int num1;
            bool ktMaBN = Int32.TryParse(txtMaBN.Text, out num1);
            int num2;
            bool ktSongay = Int32.TryParse(txtSongaynamvien.Text, out num2);
            try
            {
                if(txtMaBN.Text == "")
                    throw new Exception("Vui lòng nhập mã bệnh nhân");
                if (!ktMaBN)
                    throw new Exception("Nhập chưa đúng định dạng mã bệnh nhân");
                if(txtHoTen.Text == "")
                    throw new Exception("Vui lòng nhập tên bệnh nhân");
                if (txtSongaynamvien.Text == "")
                    throw new Exception("Vui lòng nhập số ngày nằm viện");
                if (!ktSongay)
                    throw new Exception("Nhập chưa đúng định dạng số ngày nằm viện");
                var sobn = (from bn2 in ql.BenhNhans
                            where bn2.MaBn == Int32.Parse(txtMaBN.Text)
                            select bn2.MaBn).SingleOrDefault();
                if (sobn != 0)
                    throw new Exception("Trùng mã bệnh nhân");
                int songay = Int32.Parse(txtSongaynamvien.Text);
                if(songay < 1)
                    throw new Exception("Số ngày nằm viện phải lớn hơn 1");
                BenhNhan bn = new BenhNhan();
                bn.MaBn = Int32.Parse(txtMaBN.Text);
                bn.HoTen = txtHoTen.Text;
                bn.SoNgayNamVien = Int32.Parse(txtSongaynamvien.Text);
                bn.VienPhi = bn.SoNgayNamVien * 200000;
                bn.MaKhoa = Int32.Parse(cbbKhoaKham.Text);
                ql.BenhNhans.Add(bn);
                ql.SaveChanges();
                Clear();
                HienThi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgDSBN_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = dgDSBN.SelectedItem;
            if(item != null)
            {
                string tenk = (dgDSBN.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                var mak = (from k in ql.Khoas
                           where k.TenKhoa == tenk
                           select k.MaKhoa).Single();
                cbbKhoaKham.SelectedItem = mak;
            }
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.ShowDialog();
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            //Click vào một dòng của datagrid mới thực hiện được mục sửa
            int num1;
            bool ktMaBN = Int32.TryParse(txtMaBN.Text, out num1);
            int num2;
            bool ktSongay = Int32.TryParse(txtSongaynamvien.Text, out num2);
            try
            {
                if (txtMaBN.Text == "")
                    throw new Exception("Vui lòng nhập mã bệnh nhân");
                if (!ktMaBN)
                    throw new Exception("Nhập chưa đúng định dạng mã bệnh nhân");
                if (txtHoTen.Text == "")
                    throw new Exception("Vui lòng nhập tên bệnh nhân");
                if (txtSongaynamvien.Text == "")
                    throw new Exception("Vui lòng nhập số ngày nằm viện");
                if (!ktSongay)
                    throw new Exception("Nhập chưa đúng định dạng số ngày nằm viện");
                /*var sobn = (from bn2 in ql.BenhNhans
                            where bn2.MaBn == Int32.Parse(txtMaBN.Text)
                            select bn2.MaBn).SingleOrDefault();
                if (sobn != 0)
                    throw new Exception("Trùng mã bệnh nhân");*/
                int songay = Int32.Parse(txtSongaynamvien.Text);
                if (songay < 1)
                    throw new Exception("Số ngày nằm viện phải lớn hơn 1");
                var item = dgDSBN.SelectedItem;
                string MaBN = (dgDSBN.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                if(MaBN != txtMaBN.Text)
                    throw new Exception("Không thể sửa mã bệnh nhân");
                MessageBoxResult dialogResult = MessageBox.Show("Bạn có chắc chắn sửa lại thông tin?", "Thông báo", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

                if (dialogResult == MessageBoxResult.Yes)
                {
                    var item2 = (from bn2 in ql.BenhNhans
                                 where bn2.MaBn == Int32.Parse(txtMaBN.Text)
                                 select bn2).SingleOrDefault();
                    if (item2 == null)
                        throw new Exception("Không tìm được sản phẩm này");
                    item2.HoTen = txtHoTen.Text;
                    item2.SoNgayNamVien = Int32.Parse(txtSongaynamvien.Text);
                    item2.VienPhi = item2.SoNgayNamVien * 200000;
                    item2.MaKhoa = Int32.Parse(cbbKhoaKham.Text);
                    ql.SaveChanges();
                    Clear();
                    HienThi();
                    MessageBox.Show("Sửa thông tin thành công");
                }
                else
                {
                    MessageBox.Show("Hủy sửa thông tin thành công");
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            //Click vào một dòng của datagrid rồi thực hiện lệnh xóa
            MessageBoxResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

            if (dialogResult == MessageBoxResult.Yes)
            {
                var item2 = (from bn in ql.BenhNhans
                             where bn.MaBn == Int32.Parse(txtMaBN.Text)
                             select bn).SingleOrDefault(); 
                if(item2 == null)
                {
                    MessageBox.Show("Sản phẩm không tồn tại trên cơ sở dữ liệu");
                    return;
                }
                ql.BenhNhans.Remove(item2);
                ql.SaveChanges();
                Clear();
                HienThi();
                MessageBox.Show("Xóa bệnh nhân thành công");
            }
            else
            {
                MessageBox.Show("Đã hủy lệnh xóa");
            }
        }

        private void btnTim2_Click(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            w2.ShowDialog();
        }
    }
}
