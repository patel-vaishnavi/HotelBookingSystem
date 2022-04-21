using HotelBookingSystem.DAL;
using HotelBookingSystem.UserRegistration;
using System;
using System.Collections.Generic;
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

namespace HotelBookingSystem
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        public void Login_Button_Click(object sender, RoutedEventArgs e)
        {

           
           

            if (!string.IsNullOrEmpty(username.Text) && !string.IsNullOrEmpty(password.Text))
            {
                UserLoginImpl userLogin = new UserLoginImpl();
                bool result = userLogin.authenticateUser(new LoginDao(username.Text, password.Text));

                if (result)
                {
                    MessageBox.Show("succesfully logged in");
                    HotelDetails win2 = new HotelDetails(username.Text);
                    win2.Show();
                    this.Close();
                }
                else
                { MessageBox.Show("invalid user signup first"); }
            }
            else
            { MessageBox.Show("invalid user"); }
        }
        public void Signup_Button_Click(object sender, RoutedEventArgs e)
        {
            SignUpWindow win2 = new SignUpWindow();
            win2.Show();
            this.Close();
        }
    }
}
