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
    /// Логика взаимодействия для DogCard.xaml
    /// </summary>
    public partial class DogCard : UserControl
    {
        public static readonly DependencyProperty NameDogProperty =
       DependencyProperty.Register(
           "NameDog",
           typeof(string),
           typeof(DogCard),
           new FrameworkPropertyMetadata(string.Empty));

        public string NameDog
        {
            get { return (string)GetValue(NameDogProperty); }
            set { SetValue(NameDogProperty, value); }
        }
        public string Icon { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBiesday { get; set; }
        public double Weight { get; set; }
        public int Event { get; set; }
        public int CountPhoto { get; set; }
        public int CountHost { get; set; }
        public int CountNote { get; set; }
        public int CountGraft { get; set; }
        public DogCard()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
