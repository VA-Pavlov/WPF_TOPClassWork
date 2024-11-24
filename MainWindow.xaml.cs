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
        StackPanel openTextBox;
        StackPanel clouseTextBox;
        bool flag = true;
        public MainWindow()
        {
            InitializeComponent();
            openTextBox = new StackPanel() { Orientation = Orientation.Horizontal };
            TextBox passwordTextBox = new TextBox() { FontSize = 20, Width = 313 };
            Button button = new Button();
            button.Click += Button_Click;

            Image image = new Image();
            image.Source = new BitmapImage(new Uri(@"/icons/Clouse.png", UriKind.Relative));
            image.Width = 30;
            image.Height = 30;

            button.Content = image;
            openTextBox.Children.Add(passwordTextBox);
            openTextBox.Children.Add(button);
            clouseTextBox = (StackPanel)GridStack.Children[0];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GridStack.Children.Clear();
            var passwordbox = (PasswordBox)clouseTextBox.Children[0];
            var textbox = (TextBox)openTextBox.Children[0];
            if (flag)
            {
                textbox.Text = passwordbox.Password;
                GridStack.Children.Add(openTextBox);
                flag = false;
            }
            else
            {
                passwordbox.Password = textbox.Text;
                GridStack.Children.Add(clouseTextBox);
                flag = true;
            }
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var passwordbox = (PasswordBox)clouseTextBox.Children[0];
            var textbox = (TextBox)openTextBox.Children[0];
            var password = flag ? passwordbox.Password : textbox.Text;
            if (LoginBox.Text == "admin" && password == "12345")
                MessageBox.Show("Вы вошли!");
            else
                ErrorTextBox.Text = "Неправильный логин или пароль";
        }
    }
}
