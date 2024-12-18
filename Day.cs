using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_TOPClassWork
{
    public class Day
    {
        public string Location { get; set; }
        public string Wheather { get; set; }
        public DateTime Date { get; set; }
        public string WeekDay { get; set; }
        public int MaxTemperature { get; set; }
        public int MinTemperature { get; set; }
        public double Pressure { get; set; }
        public int WindSpeed { get; set; }
        public string WindDirection { get; set; }
    }
}
