using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231120InheritancePart3.Models
{
    public class Auto
    {
        //public const int NumberOfDoors = 4;       //kan verandert worden
        //public readonly int NumberOfDoors;      //kan 1x bij het aanmaken verandert worden
        public string Type { get; set; }
        public static readonly int NumberOfDoors;

        public Auto(int doors) //5
        {
           //NumberOfDoors = doors;        //NumberOfDoors 5
        }

        static Auto()
        {
            NumberOfDoors++;

        }
    }
}
