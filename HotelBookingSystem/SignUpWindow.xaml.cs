using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using HotelBookingSystem.HotelDAL;
using HotelBookingSystem.UserRegistration;
namespace HotelBookingSystem {
    //<summary>
    //Interaction logic for SignUpWindow.xaml
    //</summary>
    public partial class SignUpWindow : Window {
        
        public SignUpWindow() {
            InitializeComponent();
        }

        private void SignUP_Click(object sender, RoutedEventArgs e) {
            LoginWindow loginWindow = new LoginWindow();
            UserSignupImpl userSignupImpl = new UserSignupImpl();
           bool result= userSignupImpl.createUser(new UserDao(FirstName.Text,LastNameBox.Text,EmailIdBox.Text,Password_Box.Text,AddressBox.Text));



            loginWindow.Show();
            this.Close();
            if (result)
            {
               MessageBox.Show("user created now login");
            }
            else
            {
               MessageBox.Show("user already exists please login");
            }
            
        }
       
    }
}
