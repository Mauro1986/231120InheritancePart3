using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideDemo.Models
{
    public class Child : Parent
    {
        public override void Print()                //Polymorphisme
        {
            Console.WriteLine("Ik ben child");
        }

        public override string ToString()
        {
            string s = Id + " " + Name;
            return s;
        }
    }
}
