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

namespace Bai9_5
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checkBox3_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checkBox4_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checkBox5_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void goiDoUong_Click(object sender, RoutedEventArgs e)
        {
            int dem = 0;
            string douong = "";
            if(checkBox1.IsChecked == true)
            {
                dem++;
                douong += "Nước cam; ";
            }
            if (checkBox2.IsChecked == true)
            {
                dem++;
                douong += "Nước kiwi; ";
            }
            if (checkBox3.IsChecked == true)
            {
                dem++;
                douong += "Nước xoài; ";
            }
            if (checkBox4.IsChecked == true)
            {
                dem++;
                douong += "Sữa tươi; ";
            }
            if (checkBox5.IsChecked == true)
            {
                dem++;
                douong += "Cà phê";
            }
            if (dem == 0)
                messagetext.Text = "Bạn chưa chọn đồ uống nào";
            else
                messagetext.Text = "Bạn đã chọn " + douong;
            message1.Visibility = Visibility;
        }

        private void exit1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    private void exit2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
