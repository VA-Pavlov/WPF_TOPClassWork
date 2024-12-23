using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPF_TOPClassWork
{
    public class Task
    {
        public string Title {  get; set; }
        public bool Check {  get; set; } = false;
        public Brush TaskBrush { get; set; } = Brushes.Black;
    }
}
