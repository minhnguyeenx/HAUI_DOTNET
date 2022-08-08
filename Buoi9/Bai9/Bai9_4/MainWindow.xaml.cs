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

namespace Bai9_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void chiSo_cu_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }

        private void soKw_tdm_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void soKw_vdm_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tongTien_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tinh_Click(object sender, RoutedEventArgs e)
        {
            int sokw, sokw_trongdm, sokw_vuotdm;
            sokw = int.Parse(chiSo_moi.Text) - int.Parse(chiSo_cu.Text);
            soKw_tt.Text = sokw.ToString();
            if(sokw <= 50)
            {
                sokw_trongdm = sokw;
                sokw_vuotdm = 0;
            }
            else
            {
                sokw_trongdm = 50;
                sokw_vuotdm = sokw-50;
            }
            soKw_tdm.Text = sokw_trongdm.ToString();
            soKw_vdm.Text = sokw_vuotdm.ToString();
            int tong = sokw_trongdm * 500 + sokw_vuotdm * 1000;
            tongTien.Text = tong.ToString();
        }

        private void In_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add(hoten.Text + "\nSố kw tiêu thụ: " + soKw_tt.Text + "\nTổng tiền: " + tongTien.Text);
        }

        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
