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

namespace Bai9_3
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

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
     
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ht = hoTen.Text;
            string gt;
            string tthn;
            string st = "";
            //bool checkgt = checkNam.Checked;
            if (checkNam.IsChecked == true)
                gt = "Nam";
            else gt = "Nữ";
            if (checkChuakh.IsChecked == true)
                tthn = "Chưa kết hôn";
            else tthn = "Đã kết hôn";
            if (bongDa.IsChecked == true)
            {
                st += bongDa.Content;
                st += ". ";
            }
            if (boiLoi.IsChecked == true)
            {
                st += boiLoi.Content;
                st += ". ";
            }
            if (amNhac.IsChecked == true)
            {
                st += amNhac.Content;
                st += ". ";
            }
            if (leoNui.IsChecked == true)
            {
                st += leoNui.Content;
                st += ". ";
            }
            listbox1.Items.Add("Họ tên: " + ht + "\nGiới tính: " + gt + "\nTình trạng hôn nhân: " + tthn + "\nSở thích: " + st);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
