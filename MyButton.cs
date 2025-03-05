using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF_TOPClassWork
{
    public class MyButton
    {
        public string SmalValue { get; set; }
        public string BigValue { get; set; }
        public Color Color { get; set; }
        public TextBlock TextBlock { get; set; }
        public Border Border { get; set; }
        public MyButton(Border border)
        {
            TextBlock = border.Child as TextBlock;
            Border = border;
            Color = (border.Background as SolidColorBrush).Color;
            if (!char.IsDigit(TextBlock.Text[0]) && TextBlock.Text.Length == 1)
            {
                SmalValue = TextBlock.Text;
                BigValue = SmalValue.ToUpper();
            }
            else
            {
                SmalValue = TextBlock.Text;
                switch (SmalValue)
                {
                    case "4":
                        BigValue = "$";
                        break;
                    case "5":
                        BigValue = "%";
                        break;
                    case "6":
                        BigValue = "^";
                        break;
                    case "7":
                        BigValue = "&";
                        break;
                    default:
                        BigValue = SmalValue;
                        break;
                }
            }
        }
    }
}
