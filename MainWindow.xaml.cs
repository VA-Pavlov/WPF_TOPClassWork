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

namespace WPF_TOPClassWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            count++;
        }

        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            count--;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string massag;
            if (count <= 2)
            {
                massag = "Ты - “Новичок”.";
            }
            else if (count <= 4)
                massag = "Ты - “Знаток”";
            else
                massag = "Ты - “Эксперт”.";
            MessageBox.Show(massag);
        }
    }
}
