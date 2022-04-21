using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.DAL
{
    public class LoginDao
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public LoginDao(string username,string password) { 
            Username = username;
            Password = password;
        }
    }
}
