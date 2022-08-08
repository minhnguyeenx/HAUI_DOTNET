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

namespace Bai9_1
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items[i]);
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            listBox2.Items.Remove(listBox1.SelectedItem);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox2.Items.Remove(listBox2.Items[i]);
            }
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
