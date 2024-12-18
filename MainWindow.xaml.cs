using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        ObservableCollection<Phone> phones;
        public MainWindow()
        {
            InitializeComponent();

            phones = new ObservableCollection<Phone>()
            {
                new Phone{Id=1,Title="iPhone 6S", Company="Apple" },
                new Phone {Id=2,Title="Lumia 950", Company="Microsoft" },
                new Phone {Id=3,Title="Nexus 5X", Company="Google" },
                new Phone {Id=4,Title="Galaxy S6", Company="Samsung"}
            };


            phonesList.ItemsSource = phones;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var phone = new Phone() { Id = Int32.Parse(IdBox.Text), Title = TitleBox.Text, Company = CompanyBox.Text };
            phones.Add(phone);
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            phones.Remove((Phone)phonesList.SelectedItem);
        }

        private void phonesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InfoStack.DataContext = phonesList.SelectedItem;
        }

    }
}
