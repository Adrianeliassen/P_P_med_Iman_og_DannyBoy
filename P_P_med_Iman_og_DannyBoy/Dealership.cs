using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P_P_med_Iman_og_DannyBoy
{

    //Lag en klasse som representerer en bil.Klassen skal ha følgende egenskaper:

    //Merke(string)

    //Registreringsnummer(string)

    //Årgang(int)

    //Antall kilometer(int)


    //Lag også en klasse som representerer en bilforhandler.Denne klassen skal ha følgende egenskaper:

    //Navn (string)

    //Adresse (string)

    //En liste av biler (List<Bil>)


    //Implementer følgende funksjonalitet i bilforhandler-klassen:

    //En metode som legger til en bil i listen over biler

    //    En metode som fjerner en bil fra listen over biler, basert på registreringsnummeret til bilen

    //En metode som returnerer en liste over alle biler som er mer enn X år gamle

    //En metode som returnerer en liste over alle biler som har kjørt mer enn Y kilometer
    public class Dealership
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public List<Car> Cars { get; private set; }

        public Dealership(string name, string address)
        {
            Name = name;
            Address = address;
            Cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
            
        }

        public void RemoveCar(string licenceNr)
        {
          
            foreach (Car car in Cars)
            {
                if (car.LicenceNr == licenceNr)
                {
                    Cars.Remove(car);
                   
                }
                
            }
        }

        public List<Car> OldCars(int modelYear)
        {
            var tempList = new List<Car>();

            foreach (var car in Cars)
            {
                if (car.Model <= modelYear)
                {
                    tempList.Add(car);
                }
            }
            return tempList;
        }
    }
}
