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
        public MainWindow()
        {
            InitializeComponent();
            Binding binding = new Binding();

            binding.ElementName = "SylfaenBox"; // элемент-источник
            binding.Path = new PropertyPath("Text"); // свойство элемента-источника
            SylfaenBlock.SetBinding(TextBlock.TextProperty, binding); // установка привязки для элемента-приемника

            binding = new Binding();
            binding.ElementName = "CalibriBox"; // элемент-источник
            binding.Path = new PropertyPath("Text"); // свойство элемента-источника
            CalibriBlock.SetBinding(TextBlock.TextProperty, binding); // установка привязки для элемента-приемника
        }
    }
}
