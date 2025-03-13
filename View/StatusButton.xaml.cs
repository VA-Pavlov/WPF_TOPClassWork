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

namespace WPF_TOPClassWork.View
{
    /// <summary>
    /// Логика взаимодействия для StatusButton.xaml
    /// </summary>
    public partial class StatusButton : UserControl
    {
        public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register(
            "Text",
            typeof(string),
            typeof(StatusButton),
            new FrameworkPropertyMetadata(string.Empty));
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        public string PathIcon {  get; set; }
       

        public StatusButton()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
