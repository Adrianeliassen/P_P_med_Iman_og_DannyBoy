using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_P_med_Iman_og_DannyBoy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Mercedes = new Car("mercedes", "1234D", 2013, 2000);
            Car Audi = new Car("audi", "GH12345", 2021, 200000);
            Car Toyota = new Car("toyota", "AB12121", 2015, 250000);
            Dealership Ole = new Dealership("Ole", "Karl Johans Gate 12");
            Ole.AddCar(Mercedes);
            Ole.AddCar(Audi);
            Ole.AddCar(Toyota);


            List<Car> olduselesscars = Ole.OldCars(2015);
            for (int i = 0; i < olduselesscars.Count; i++)
            {
                Console.WriteLine(olduselesscars[i].Brand);
            }



        }
    }
}
