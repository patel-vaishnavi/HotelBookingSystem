using HotelBookingSystem.HotelDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.UserRegistration
{
    internal interface IUserSignup
    {
        bool createUser (UserDao userDao);
      /*  UserDao getUserDetailByID(int userId);
        bool updateUserData(UserDao userDao);
      */
    }
}
