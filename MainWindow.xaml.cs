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

           // MainGrid.Children.Add(new DogCard() { DataContext = DogsRepositoriy.GetDog()[0] });
            DogsListBox.ItemsSource = DogsRepositoriy.GetDog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Gray;
        }

        private void DogsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DogCard dogCard = new DogCard();
            dogCard.DataContext = DogsListBox.SelectedItem;
            MainGrid.Children.Add(dogCard);
            Grid.SetColumn(dogCard, 1);
        }
    }
}
