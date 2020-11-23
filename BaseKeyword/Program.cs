using BaseKeyword.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bmw bmw = new Bmw();
            //bmw.NumberOfDoors = 5;
            //bmw.Type = "Sedan";

            //bmw.Print();

            Bill bill = new Bill();
            bill.Item = "Book";
            bill.NumberOfItems = 1;
            bill.Prize = 25.00;
            bill.Tax = 6.00;

            bill.CalculateBill();
            Console.WriteLine();

        }
    }
}
