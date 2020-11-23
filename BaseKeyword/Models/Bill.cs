using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeyword.Models
{
    class Bill : Calculate
    {
        //public string Item { get; set; }
        //public int NumberOfItems { get; set; }
        //public double Prize { get; set; }
        //public double Tax { get; set; } = 21.00;

        public new double Tax { get; set; } = 6.00;

        public void CalculateBill()
        {
            double calk = (NumberOfItems * Prize) * base.Tax/100;  //base. zorgt voor Tax 21 vanuit calculate
            Console.WriteLine(Item);
            Console.WriteLine(calk);
        }
    }
}
