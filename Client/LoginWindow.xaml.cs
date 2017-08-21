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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Client.UrenregistratieServiceReference;

namespace Client
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

        private void LoginRegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var regWindow = new RegisterWindow
            {
                UsernameBox = {Text = UsernameBox.Text}
            };
            regWindow.Show();
            this.Close();
        }

        private void UsernameBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (UsernameBox.Text.Equals("Gebruikersnaam"))
            {
                UsernameBox.Text = "";
            }
        }


        private void UsernameBox_OnLostFocus(object sender, RoutedEventArgs e)
        {
            if (UsernameBox.Text.Equals(""))
            {
                UsernameBox.Text = "Gebruikersnaam";
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            using (var svc = new UrenregistratieServiceClient())
            {
                if (!svc.Login(UsernameBox.Text, PasswordBox.Password))
                {
                    MessageBlock.Text = "Gebruikersnaam of wachtwoord ongeldig!";
                }
                else
                {   
                    var appUser = svc.GetUser(UsernameBox.Text, PasswordBox.Password);
                    var main = new MainWindow()
                    {
                        CurrentUser = appUser
                    };
                    main.Show();
                    Close();
                }
            }
        }
    }
}
