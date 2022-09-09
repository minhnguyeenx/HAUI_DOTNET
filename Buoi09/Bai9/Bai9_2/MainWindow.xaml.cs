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

namespace Bai9_2
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

        private void hoTen_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void gioiTinh_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void phongBan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            string ht = hoTen.Text;
            string gt = gioiTinh.Text;
            string pb = phongBan.Text;
            listBox1.Items.Add(ht + " - " + gt + " - " + pb);
        }

        private void thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
