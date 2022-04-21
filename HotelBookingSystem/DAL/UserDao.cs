using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.HotelDAL
{
    public class UserDao
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        public UserDao(string firstname,string lastname,string email,string password,string address) { 
            
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Password = password;
            Address = address;
        
        }
        public override string ToString()
        {
            return FirstName+","+LastName+","+Email+","+Password+","+Address;
        }
    }
}
