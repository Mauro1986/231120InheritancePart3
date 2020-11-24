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
                //Console.WriteLine(item);
                Print(item);

            }
  
            //Print(auto);
            //Print(bmwTemp);
            //Print(audi);
            
        }
        public static void Print(Auto auto)
        {

            Console.WriteLine("***************Print method*********************"); ;
            if (auto is Auto)
            {
                Console.WriteLine(auto.Name);
                Console.WriteLine(auto.Color);
            }

            if (auto is Bmw)
            {
                Bmw bmw = auto as Bmw;       // is het zelfde als Casting zoals vb Audi audi = (Audi)auto;
                Console.WriteLine($"{bmw.Id}");
                Console.WriteLine($"{bmw.Name}");
                Console.WriteLine($"{bmw.Color}");
            }
            if (auto is Audi)
            {
                Audi audi = (Audi)auto;
                Console.WriteLine($"{audi.Id}");
                Console.WriteLine($"{audi.Name}");
                Console.WriteLine($"{audi.Color}");
            }
        }

    }
}
