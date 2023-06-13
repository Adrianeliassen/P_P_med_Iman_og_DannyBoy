using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_P_med_Iman_og_DannyBoy
{
    public class Car
    {
        public string Brand { get; private set; }
        public string LicenceNr { get; set; }
        public int Model  { get; private set; }
        public int Mileage { get; private set; }

        public Car(string brand, string licenceNr, int model, int mileage)
        {
            Brand = brand;
            LicenceNr = licenceNr;
            Model = model;
            Mileage = mileage;
        }
    }
}
