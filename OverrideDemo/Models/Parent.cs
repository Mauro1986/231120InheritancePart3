using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideDemo.Models
{
   public class Parent
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public virtual void Print()
        { 
            Console.WriteLine(Id);
            Console.WriteLine(Name); 
        }

        public override string ToString()
        {
            string s = $"Hello from parrent";
            return s;
        }
    }
}
