using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_TOPClassWork
{
    public class Phone
    {
        public string Name { get; set; }
        public Company Company { get; set; }
        public decimal Price { get; set; }
    }

    public class Company
    {
        public string Title { get; set; }
    }
}
