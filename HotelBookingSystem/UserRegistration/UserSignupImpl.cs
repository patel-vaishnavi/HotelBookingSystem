using HotelBookingSystem.HotelDAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.UserRegistration {
    public class UserSignupImpl : IUserSignup {
        public bool createUser(UserDao userDao) {

            string[] lines = System.IO.File.ReadAllLines("C:\\Users\\Vaishnavi Patel\\Documents\\Users.csv");
            foreach (string line in lines)
            {    
                String[] columns = line.Split(',');
                if (userDao.Email == columns[3])
                    return false;

            }
                File.AppendAllText("C:\\Users\\Vaishnavi Patel\\Documents\\Users.csv",lines.Length+1 +","+userDao + Environment.NewLine);
                return true;

        }
    }
}
