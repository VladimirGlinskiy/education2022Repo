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

namespace VGlinskii.WPF.Lab1._1_wpfHello
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try {
                System.IO.StreamWriter sw = new System.IO.StreamWriter("D:\\username.txt");
                sw.WriteLine(textBox.Text);
                sw.Close();
            } catch (Exception ex) {
            
                MessageBox.Show(ex.Message);
            }
                
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try {
            System.IO.StreamReader sr = new System.IO.StreamReader("D:\\username.txt");
                label.Content = "Приветствую Вас, дорогой " + sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);

            }
        }
    }
}
