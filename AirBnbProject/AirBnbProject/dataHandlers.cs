using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsForms
{

    class Country
    {
        private string country;
        private int population;
        private int bnbPerCap;
        List<City> cities = new List<City>();

        public Country(String Name, int Cap, int pop)
        {
            country = Name;
            bnbPerCap = Cap;
            population = pop;
        }
        public void addCity(City city)
        {
            cities.Add(city);
        }
    }

    class City
    {
        private string cityName;
        private int population;
        private int avgIncome;
        private int turistYear;
        List<Accommodations> accommodations = new List<Accommodations>();

        public City(String name, int avg, int turist, int pop)
        {
            cityName = name;
            avgIncome = avg;
            turistYear = turist;
            population = pop;
        }

        public void addRoom(Accommodations room)
        {
            accommodations.Add(room);
        }
    }

    class Accommodations
    {
        private int room_id;
        private int host_id;
        private string room_type;
        private string borough;
        private string neighbourhood;
        private int reviews;
        private double overall_satisfaction;
        private int Accomodates;
        private int bedrooms;
        private int price;
        private int minstay;
        private double latitude;
        private double longitude;
        private string last_modifified;

        public Accommodations()
        {

        }
    }

}
