using HotelBookingSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.UserRegistration
{
    public interface IUserLogin
    {
        
        public bool authenticateUser(LoginDao loginDao);
    }
}
