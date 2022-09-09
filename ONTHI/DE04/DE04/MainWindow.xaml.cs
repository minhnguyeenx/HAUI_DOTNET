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
using DE04.Models;

namespace DE04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLBanHang1Context ql = new QLBanHang1Context();
        public MainWindow()
        {
            InitializeComponent();
            LoadItem();
            DataComboBox();
        }

        private void DataComboBox()
        {
            var query = from lsp in ql.LoaiSps
                        select lsp.TenLoai;
            cbbLoaiSp.ItemsSource = query.ToList();
        }

        private void LoadItem()
        {
            var query = from lsp in ql.LoaiSps
                        join sp in ql.SanPhams
                        on lsp.MaLoai equals sp.MaLoai
                        orderby sp.TenSp descending
                        select new
                        {
                            sp.MaSp,
                            sp.TenSp,
                            sp.MaLoai,
                            sp.SoLuongCo,
                            sp.DonGia
                        };
            dgDSSP.ItemsSource = query.ToList();
        }

        private void Clear()
        {
            txtMaSp.Clear();
            txtTenSp.Clear();
            txtSLCo.Clear();
            txtDonGia.Clear();
            cbbLoaiSp.SelectedIndex = 0;
            txtMaSp.Focus();
        }
        private void HienThi()
        {
            var query = from lsp in ql.LoaiSps
                        join sp in ql.SanPhams
                        on lsp.MaLoai equals sp.MaLoai
                        select new
                        {
                            sp.MaSp,
                            sp.TenSp,
                            sp.MaLoai,
                            sp.SoLuongCo,
                            sp.DonGia
                        };
            dgDSSP.ItemsSource = query.ToList();
        }

        private void dgDSSP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = dgDSSP.SelectedItem;
            if(item != null)
            {
                var mal = (dgDSSP.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                string loaisp = (from lsp in ql.LoaiSps
                                 where lsp.MaLoai == mal
                                 select lsp.TenLoai).Single();
                cbbLoaiSp.SelectedItem = loaisp;
            }
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            int num1;
            bool ktdongia = Int32.TryParse(txtDonGia.Text, out num1);
            int num2;
            bool ktslco = Int32.TryParse(txtSLCo.Text, out num2);
            try
            {
                if (txtMaSp.Text == "")
                    throw new Exception("Vui lòng nhập đầu đủ thông tin");
                if (txtTenSp.Text == "")
                    throw new Exception("Vui lòng nhập đầu đủ thông tin");
                if (txtDonGia.Text == "")
                    throw new Exception("Vui lòng nhập đầu đủ thông tin");
                if (txtSLCo.Text == "")
                    throw new Exception("Vui lòng nhập đầu đủ thông tin");
                var _masp = (from sp0 in ql.SanPhams
                            where sp0.MaSp == txtMaSp.Text
                            select sp0.MaSp).SingleOrDefault();
                if (_masp != null)
                    throw new Exception("Trùng mã sản phẩm");
                if (!ktdongia)
                    throw new Exception("Chưa đúng địn dạng đơn giá");
                if (!ktslco)
                    throw new Exception("Chưa đúng định dạng số lượng có");
                SanPham sp = new SanPham();
                sp.MaSp = txtMaSp.Text;
                sp.TenSp = txtTenSp.Text;
                sp.DonGia = Int32.Parse(txtDonGia.Text);
                sp.SoLuongCo = Int32.Parse(txtSLCo.Text);
                var _ml = (from lsp2 in ql.LoaiSps
                           where lsp2.TenLoai == cbbLoaiSp.Text
                           select lsp2.MaLoai).Single();
                sp.MaLoai = _ml;
                ql.SanPhams.Add(sp);
                ql.SaveChanges();
                Clear();
                HienThi();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            int num1;
            bool ktdongia = Int32.TryParse(txtDonGia.Text, out num1);
            int num2;
            bool ktslco = Int32.TryParse(txtSLCo.Text, out num2);
            try
            {
                if (txtMaSp.Text == "")
                    throw new Exception("Vui lòng nhập đầu đủ thông tin");
                if (txtTenSp.Text == "")
                    throw new Exception("Vui lòng nhập đầu đủ thông tin");
                if (txtDonGia.Text == "")
                    throw new Exception("Vui lòng nhập đầu đủ thông tin");
                if (txtSLCo.Text == "")
                    throw new Exception("Vui lòng nhập đầu đủ thông tin");
                if (!ktdongia)
                    throw new Exception("Chưa đúng địn dạng đơn giá");
                if (!ktslco)
                    throw new Exception("Chưa đúng định dạng số lượng có");

                var item = dgDSSP.SelectedItem;
                string _masp = (dgDSSP.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                if (_masp != txtMaSp.Text)
                    throw new Exception("Không được đổi mã sản phẩm");
                MessageBoxResult dialogMessage = MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Thông báo", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                if (dialogMessage == MessageBoxResult.Yes)
                {
                    var item2 = (from sp in ql.SanPhams
                                 where sp.MaSp == _masp
                                 select sp).SingleOrDefault();
                    if (item2 == null)
                        throw new Exception("Sản phẩm không có trong csdl");
                    item2.MaSp = txtMaSp.Text;
                    item2.TenSp = txtTenSp.Text;
                    item2.SoLuongCo = Int32.Parse(txtSLCo.Text);
                    item2.DonGia = Int32.Parse(txtDonGia.Text);
                    var _ml = (from lsp2 in ql.LoaiSps
                               where lsp2.TenLoai == cbbLoaiSp.Text
                               select lsp2.MaLoai).Single();
                    item2.MaLoai = _ml;
                    ql.SaveChanges();
                    Clear();
                    HienThi();
                    MessageBox.Show("Sửa thành công");
                }
                else
                    throw new Exception("Đã hủy thao tác sửa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            var item = dgDSSP.SelectedItem;
            string _masp = (dgDSSP.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            MessageBoxResult dialogMessage = MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Thông báo", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (dialogMessage == MessageBoxResult.Yes)
            {
                var item2 = (from sp in ql.SanPhams
                             where sp.MaSp == _masp
                             select sp).SingleOrDefault();
                if (item2 == null)
                {
                    MessageBox.Show("Sản phẩm không có trong csdl");
                    return;
                }
                ql.SanPhams.Remove(item2);
                ql.SaveChanges();
                Clear();
                HienThi();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Đã hủy thao tác xóa");
                return;
            }
                
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.ShowDialog();
        }

        private void btnThongKe_Click(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            w2.ShowDialog();
        }
    }
}
