using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme.Models
{
    public class Auto
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            string s = $"{Name} {Color}";
            return s;
        }
    }
}
