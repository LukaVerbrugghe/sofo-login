using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//stap 3
using MySql.Data.MySqlClient;

namespace prjLogin.Helper //dit is de locatie
{
    //stap 1: klasse public maken (public ipv internal)
    //stap 2: we gaan moeten kunnen werken met SQL
    //  bibliotheek nodig om er te kunnen mee werken
    //  moet je nog toevoegen --> References (mysql.data.dll in 0opdrachten)
    //stap 3: bovenaan plaatsen (de reference) om deze gemakkelijk te kunnen gebruiken (using...)
    public class Database
    {
        //stap 4: in de klasse database (hier dus) moeten we een verbinding leggen met de database, dan kunnen we gwn de klasse database oproepen als we de databank nodig hebben --> Mysqlconnection vereist
        public static MySqlConnection MaakVerbinding()
        {
            //2 dingen nodig
            //  1 connectionstringbuilder maken om alle eigenschappen aan te geven
            //  2 je connection maken

            //connectionstringbuilder maken
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder()
            {
                //eigenschappen instellen
                Server = "Localhost",
                Database = "login",
                UserID = "root",
                Password = "usbw",
                Port = 3307, //zie usbwebserver settings
                ConnectionTimeout = 60,
                AllowZeroDateTime = true //je kan lege data hebben
            };
            //eigenlijke connectie maken
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
