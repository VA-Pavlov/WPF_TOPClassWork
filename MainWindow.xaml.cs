﻿using System;
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
        ObservableCollection<Make> makes;
        public MainWindow()
        {
            InitializeComponent();

            makes = new ObservableCollection<Make>()
            {
                new Make{Date=DateTime.Now,Title="Дело 1", Description="qwweq wqe qweqwe qw ew sdasdw  dasdwe dasdf ersd d f asada feddsg ffsddfda asdas faasdd as"}
            };

            //maksList.ItemsSource = makes;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var make = new Make {
                Date = DateBox.DisplayDate,
                Title = TitleBox.Text,
                Description = DescriptionBox.Text
            };
            makes.Add(make);
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            //makes.Remove((Make)maksList.SelectedItem);
        }

        //private void phonesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    //InfoStack.DataContext = phonesList.SelectedItem;
        //}

    }
}
