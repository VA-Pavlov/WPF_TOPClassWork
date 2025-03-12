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
    /// Логика взаимодействия для StateElement.xaml
    /// </summary>
    public partial class StateElement : UserControl
    {
        public string Text { get; set; }
        public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register(
            "Text",
            typeof(string),
            typeof(StateElement),
            new FrameworkPropertyMetadata(string.Empty));
        public StateElement()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
