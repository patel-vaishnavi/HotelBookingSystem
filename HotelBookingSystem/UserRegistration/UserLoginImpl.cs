using HotelBookingSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.UserRegistration {
    internal class UserLoginImpl : IUserLogin
    {

        public bool authenticateUser(LoginDao loginDao)
        {


            string[] lines = System.IO.File.ReadAllLines("C:\\Users\\Vaishnavi Patel\\Documents\\Users.csv");
            foreach (string line in lines)
            {
                String[] columns = line.Split(',');
                if (loginDao.Username == columns[3] && loginDao.Password==columns[4])
                    return true;
            }

          return false;
        }
    }
}
