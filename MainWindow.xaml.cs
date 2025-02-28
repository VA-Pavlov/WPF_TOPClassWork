using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
        }

        private void ABackSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var value = (byte)(sender as Slider).Value;
            FontA.Text = value.ToString();
            ExempleBorder.Background = new SolidColorBrush(Color.FromArgb(a: byte.Parse(FontA.Text), r: byte.Parse(FontR.Text), g: byte.Parse(FontG.Text), b: byte.Parse(FontB.Text)));
            ARGBToHex((ExempleBorder.Background as SolidColorBrush).Color);
        }

        private void RBackSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var value = (byte)(sender as Slider).Value;
            FontR.Text = value.ToString();
            ExempleBorder.Background = new SolidColorBrush(Color.FromArgb(a: byte.Parse(FontA.Text), r: byte.Parse(FontR.Text), g: byte.Parse(FontG.Text), b: byte.Parse(FontB.Text)));
            ARGBToHex((ExempleBorder.Background as SolidColorBrush).Color);
        }

        private void GBackSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var value = (byte)(sender as Slider).Value;
            FontG.Text = value.ToString();
            ExempleBorder.Background = new SolidColorBrush(Color.FromArgb(a: byte.Parse(FontA.Text), r: byte.Parse(FontR.Text), g: byte.Parse(FontG.Text), b: byte.Parse(FontB.Text)));
            ARGBToHex((ExempleBorder.Background as SolidColorBrush).Color);
        }
        private void BBackSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var value = (byte)(sender as Slider).Value;
            FontB.Text = value.ToString();
            ExempleBorder.Background = new SolidColorBrush(Color.FromArgb(a: byte.Parse(FontA.Text), r: byte.Parse(FontR.Text), g: byte.Parse(FontG.Text), b: byte.Parse(FontB.Text)));
            ARGBToHex((ExempleBorder.Background as SolidColorBrush).Color);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var hexColor = HexTextBlock.Text;
            // Удаляем символ # если он есть
            hexColor = hexColor.StartsWith("#") ? hexColor.Substring(1) : hexColor;

            if (hexColor.Length == 8)
            {
                byte a = Convert.ToByte(hexColor.Substring(0, 2), 16);
                byte r = Convert.ToByte(hexColor.Substring(2, 2), 16);
                byte g = Convert.ToByte(hexColor.Substring(4, 2), 16);
                byte b = Convert.ToByte(hexColor.Substring(6, 2), 16);

                ExempleBorder.Background = new SolidColorBrush(Color.FromArgb(a, r, g, b));
                ChangeControlsCollorBackgrounf(a, r, g, b);
            }
            else if (hexColor.Length == 6)
            {
                // Преобразуем каждый компонент
                byte r = Convert.ToByte(hexColor.Substring(0, 2), 16);
                byte g = Convert.ToByte(hexColor.Substring(2, 2), 16);
                byte b = Convert.ToByte(hexColor.Substring(4, 2), 16);

                // Устанавливаем полную непрозрачность (FF)
                ExempleBorder.Background = new SolidColorBrush(Color.FromArgb(255, r, g, b));
                ChangeControlsCollorBackgrounf(255, r, g, b);
            }
            else
                MessageBox.Show("Некорректный hex код");
        }
        private void ChangeControlsCollorBackgrounf(byte a, byte r, byte g, byte b)
        {
            FontA.Text = a.ToString();
            ASlider.Value = (int)a;
            FontR.Text = r.ToString();
            RSlider.Value = (int)r;
            FontG.Text = g.ToString();
            GSlider.Value = (int)g;
            FontB.Text = b.ToString();
            BSlider.Value = (int)b;
        }
        private void ARGBToHex(Color color)
        {
            HexTextBlock.Text = $"#{color.A:X2}{color.R:X2}{color.G:X2}{color.B:X2}";
        }

        private void FontButton_Click(object sender, RoutedEventArgs e)
        {
            var font = ((Button)sender).Content.ToString();
            ExempleTextBlock.FontFamily = new FontFamily(font);
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SizeBlock.Text = (sender as Slider).Value.ToString();
            ExempleTextBlock.FontSize = Int32.Parse(SizeBlock.Text);
        }

        private void WeightButton_Click(object sender, RoutedEventArgs e)
        {
            var font = ((Button)sender).Content.ToString();
            switch (font)
            {
                case "Bold":
                    ExempleTextBlock.FontWeight = FontWeights.Bold;
                    break;
                case "Medium":
                    ExempleTextBlock.FontWeight = FontWeights.Medium;
                    break;
                case "Light":
                    ExempleTextBlock.FontWeight = FontWeights.Light;
                    break;
            }
        }

        private void StyleButton_Click(object sender, RoutedEventArgs e)
        {
            var font = ((Button)sender).Content.ToString();
            switch (font)
            {
                case "Normal":
                    ExempleTextBlock.FontStyle = FontStyles.Normal;
                    break;
                case "Italic":
                    ExempleTextBlock.FontStyle = FontStyles.Italic;
                    break;
                case "Oblique":
                    ExempleTextBlock.FontStyle = FontStyles.Oblique;
                    break;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ExempleBorder.Background = ((ColorBox.SelectedItem as Grid).Children[0] as Label).Background as SolidColorBrush;
            var color = (ExempleBorder.Background as SolidColorBrush).Color;
            ARGBToHex(color);
            ChangeControlsCollorBackgrounf(color.A, color.R, color.G, color.B);
        }
    }
}

