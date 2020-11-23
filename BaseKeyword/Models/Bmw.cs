using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeyword.Models
{
    public class Bmw : Auto
    {
        public new int NumberOfDoors { get; set; } = 4;

        public void Print()
        {
            NumberOfDoors++;
            Console.WriteLine(base.NumberOfDoors);

            
        }
    }
}
