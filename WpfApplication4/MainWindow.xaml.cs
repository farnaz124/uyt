using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication4
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

        private void New_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
        }
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog open = new Microsoft.Win32.OpenFileDialog();
            open.Filter = "text file|*.txt";
            open.FileName = "";
            open.Title = "لطفا یک فایل متنی انتخاب کنید";
            open.ShowDialog();
           textBox1.Text= System.IO.File.ReadAllText(open.FileName);
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog save = new Microsoft.Win32.SaveFileDialog();
            save.Filter = "text file|*.txt";
            save.FileName = "faradars";
            save.ShowDialog();
            System.IO.File.WriteAllText(save.FileName,textBox1.Text);
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void BackColor_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ForeColor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Background = Brushes.Red;
        }
        private void Yellow_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Background = Brushes.Yellow;
        }
        private void RedF_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Foreground = Brushes.Red;
        }
        private void YellowF_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Foreground = Brushes.Yellow;
        }
    }
}
