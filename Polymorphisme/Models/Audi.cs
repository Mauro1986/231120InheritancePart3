using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme.Models
{
    public class Audi : Auto
    {
        public int Id { get; set; }
   

        public override string ToString()
        {
            string s = $"{Name} {Id} {Color}";
            return s;
        }
    }

   
}
