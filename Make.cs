﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPF_TOPClassWork
{
    public class Make
    {
        public DateTime Date { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
