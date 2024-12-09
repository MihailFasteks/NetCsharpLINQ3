using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace NetCsharpLINQ3
{
    internal class Phone
    {
        public string Name { get; set; }
        public string Manufacture { get; set; }
        public decimal Price { get; set; }
        public DateTime startDate { get; set; }

        public Phone() { }
        public Phone(string n, string mf, decimal p, DateTime d)
        {
            Name = n;
            Manufacture = mf;
            Price = p;
            startDate = d.Date;
        }
        public override string ToString()
        {
            return $"{Name} - {Manufacture} - {Price} - {startDate.ToShortDateString()}";
    }
    }
   
}
