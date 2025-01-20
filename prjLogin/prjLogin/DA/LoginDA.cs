using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//verbinding
using prjLogin.Helper;
using prjLogin.Model;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace prjLogin.DA
{
    //internal naar public
    public class LoginDA
    {
        //methode maken
        public static bool LoginValidate(Model.Login L)
        {
            //controleren of de gebruikersnaam en wachtwoord uit de tabel correct zijn
            //hoe? met een bool (vanzelfspreken)
            bool blnLogin = false;

            //eerst verbinding maken met de database
            MySqlConnection conn = Database.MaakVerbinding();

            //we gaan tellen hoeveel records overeenkomen met de gebruikersnaam en wachtwoord --> als letterlijke tekst
            String query = "SELECT COUNT(1) FROM login.tbllogin WHERE Username = @Username AND Password = @Password";
            //commando maken
            MySqlCommand sqlCmd = new MySqlCommand(query, conn);
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Username", L.Username);
            sqlCmd.Parameters.AddWithValue("@Password", L.Password);

            //we moeten nog checken of de gebruikersnaam en wachtwoord wel juist zijn, oftewel als we tellen dat dat dan 1 is (als er iets is met die username en password)
            int count = Convert.ToInt32(sqlCmd.ExecuteScalar()); 
            //ececutescalar: om je commando uit te voeren als je 1 gegeven uit je db wilt halen
            //executereader: om je commando uit te voeren als je meerdere gegevens uit de databank wilt halen --> datareader nodig
            //executenonquery: om je commando uitte voeren als je aanpassingen wilt maken aan je databank (delete, update, insert)
            //deze 3 zijn ALTIJD een examenvraag!.!.!.!

            //controleren wat er in de count zit
            if(count == 1)
            {
                blnLogin = true;
            }

            conn.Close();
            return blnLogin;
        }
        public static void Register(Model.Login L)
        {
            MySqlConnection conn = Database.MaakVerbinding();
            string query = "INSERT INTO login.tbllogin(username, password) VALUES (@Username, @Password)";
            MySqlCommand sqlCmd = new MySqlCommand(query, conn);
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Username", L.Username);
            sqlCmd.Parameters.AddWithValue("@Password", L.Password);
            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Uw account werd gerigistreerd.");
            conn.Close();
        }

        public static void Delete(Login L)
        {
            MySqlConnection conn = Database.MaakVerbinding();
            string query = "DELETE FROM login.tbllogin(username, password) WHERE Username = @Username AND Password = @Password";
            MySqlCommand sqlCmd = new MySqlCommand(query, conn);
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Username", L.Username);
            sqlCmd.Parameters.AddWithValue("@Password", L.Password);
            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Uw account werd verwijderd.");
            conn.Close();
        }
    }

}
