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
    /// Interaction logic for OldRegisterWindow.xaml
    /// </summary>
    public partial class OldRegisterWindow : Window
    {
        public OldRegisterWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var svc = new UrenregistratieServiceClient();
            var username = UsernameBox.Text;
            var pw = PasswordBox.Password;
            var pwConfirm = PasswordBox_Confirm.Password;

            if (!username.Equals("Gebruikersnaam") && !string.IsNullOrWhiteSpace(pw) && !string.IsNullOrWhiteSpace(pwConfirm))
            {
                MessageBlock.Text = !pw.Equals(pwConfirm) ? "Wachtwoorden komen niet overeen!" : svc.Register(username, pw);
            } else MessageBlock.Text = "Vul aub alle velden in!";
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
    }
}
