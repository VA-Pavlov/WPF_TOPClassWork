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
        private Dictionary<string, MyButton> ButtonsDictionary = new Dictionary<string, MyButton>();
        public MainWindow()
        {
            InitializeComponent();
            CreateDictionary();
        }

        private void CreateDictionary()
        {
            foreach (var line in MainStack.Children)
            {
                if (line is StackPanel)
                    foreach (var border in (line as StackPanel).Children)
                    {
                        var myButton = new MyButton(border as Border);
                        if (char.IsLower(myButton.SmalValue[0]) && myButton.SmalValue.Length == 1)
                        {
                            ButtonsDictionary.Add(myButton.BigValue, myButton);
                        }
                        else if (char.IsDigit(myButton.SmalValue[0]))
                            ButtonsDictionary.Add("D" + myButton.SmalValue, myButton);
                        else
                        {
                            ButtonsDictionary.Add("LeftShift", myButton);
                        }
                    }
                else
                    ButtonsDictionary.Add("Space", (new MyButton((line as Border))));
            }
        }

        private void TextBlock_KeyDown(object sender, KeyEventArgs e)
        {
            if (ButtonsDictionary.TryGetValue(e.Key.ToString(), out var button))
            {
                switch (e.Key)
                {
                    case Key.Space:
                        Text.Text += " ";
                        break;
                    case Key.LeftShift:
                        ButtonUp();
                        break;
                    default:
                        Text.Text += button.TextBlock.Text;
                        break;
                }
                button.Border.Background = Brushes.LightGray;
            }
        }
        private void ButtonUp()
        {
            foreach (var key in ButtonsDictionary.Keys)
                ButtonsDictionary[key].TextBlock.Text = ButtonsDictionary[key].BigValue;

        }

        private void Text_KeyUp(object sender, KeyEventArgs e)
        {
            if (ButtonsDictionary.TryGetValue(e.Key.ToString(), out var button))
            {
                button.Border.Background = new SolidColorBrush(button.Color);
                if (e.Key == Key.LeftShift)
                    ButtonDown();
            }
        }
        private void ButtonDown()
        {
            foreach (var key in ButtonsDictionary.Keys)
                ButtonsDictionary[key].TextBlock.Text = ButtonsDictionary[key].SmalValue;

        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StartButton.IsEnabled = false;
            StopButton.IsEnabled = true;
            Text.Focus();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            StartButton.IsEnabled = true;
            StopButton.IsEnabled = false;
            Keyboard.ClearFocus();
        }
    }
}
