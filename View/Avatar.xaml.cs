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
    /// Логика взаимодействия для Avatar.xaml
    /// </summary>
    public partial class Avatar : UserControl
    {
        public static readonly DependencyProperty PathIconProperty =
  DependencyProperty.Register(
      "PathIcon",
      typeof(string),
      typeof(StatusButton),
      new FrameworkPropertyMetadata(
          string.Empty));
        public double Size {  get; set; }
        public string PathIcon {  get; set; }
        public Avatar()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
