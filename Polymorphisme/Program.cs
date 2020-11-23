using Polymorphisme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
      

            Auto[] autos = new Auto[3];
            //Bmw[] autos = new Bmw[3];


            Auto auto = new Auto();
            auto.Name = "Parent";
            auto.Color = "White";

            Auto auto1 = new Bmw();      //Impliciet Casting
            auto1.Color = "Red";
            auto1.Name = "Bmw";
            Bmw bmwTemp = (Bmw)auto1;       //Expleciet Casting
            if (bmwTemp is Bmw && bmwTemp != null)                    //If gebruiken in geval van expleciet casting
            {
                bmwTemp.Id = 998;
            }

            Audi audi = new Audi
            {
                Id = 800,
                Name = "Audi",
                Color = "Black",
            };

            autos[0] = auto;
            autos[1] = bmwTemp;
            autos[2] = audi;

            foreach (var item in autos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(bmwTemp.Id);
            Console.WriteLine(bmwTemp.Id);
            Console.WriteLine(bmwTemp.Color);
        }
    }
}
