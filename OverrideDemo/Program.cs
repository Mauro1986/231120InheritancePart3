using OverrideDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Id = 1011;
            child.Name = "Jan";
            child.Print();

            Console.WriteLine(child.ToString());

            Child c1 = new Child();
            c1.Id = 500;
            c1.Name = "Emre";

            Console.WriteLine(c1.ToString());

            Child c2 = new Child();
            c2.Id = 700;
            c2.Name = "Jeff";

            Console.WriteLine(c2.ToString());
        }
    }
}
