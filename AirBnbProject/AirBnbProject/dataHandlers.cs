using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AirBnbProject
{
    class Country
    {
        private string country;
        private int population;
        private int bnbPerCap;
        private List<City> city;

        public Country(List<City> city)
        {

        }
    }

    class City
    {
        private string cityName;
        private int population;
        private int avgIncome;
        private int turistYear;
        private List<Accommodations> Accommodations;

        public City(List<Accommodations> Accommodations)
        {

        }
    }

    class Accommodations // Boende 
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
    /*
    class Connection
    {
        static string server = "mydb8.surf-town.net";
        static string user = "hdb64894_handin3";
        static string pw = "teamhandin3";
        private MySqlConnection conn;
        string connStr = $"server={server};user={user};database=hb64894_airbnb;port=3306;password={pw};";
        
        public Connection()
        {
            conn = new MySqlConnection(connStr);
        }

        public MySqlConnection GetConn()
        {
            return conn;
        }
    }
    */
}
