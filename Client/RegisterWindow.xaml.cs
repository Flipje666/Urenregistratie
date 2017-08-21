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
using Client.UrenregistratieServiceReference;

namespace Client
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var svc = new UrenregistratieServiceClient();
            var username = UsernameBox.Text;

            if (!(username.Equals("Gebruikersnaam") || string.IsNullOrWhiteSpace(username)))
            {
                if (!svc.Register(username))
                {
                    MessageBlock.Text = "Deze gebruikersnaam bestaat al!";
                }
                else
                {
                    var chararray = username.ToCharArray();
                    Array.Reverse(chararray);
                    PasswordBlock.Text = "Uw gegenereerde wachtwoord is: " + new string(chararray);
                    MessageBlock.Text = "Registratie succesvol, u kunt het scherm sluiten.";
                }
            }
            else MessageBlock.Text = "Voer een gebruikersnaam in!";
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

        private void RegisterWindow_OnClosed(object sender, EventArgs e)
        {
            var logwindow = new LoginWindow() {UsernameBox = {Text = UsernameBox.Text}};
            logwindow.Show();
        }
    }
}
