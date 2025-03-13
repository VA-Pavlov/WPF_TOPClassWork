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
        public string Text {  get; set; }
        public string PathIcon {  get; set; }
       

        public StatusButton()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
