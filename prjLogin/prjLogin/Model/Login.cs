using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjLogin.Model
{
    //dit bestand heeft altijd de naam van je database
    //stap 1: internal vervangen met public
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
