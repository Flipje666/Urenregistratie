using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
using Task = Client.UrenregistratieServiceReference.Task;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AppUser CurrentUser { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TaskListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TaskBox.Text = TaskListBox.SelectedValue.ToString().Split(' ').Last();
            HourBox.Text = "";
        }

        private void HourSaveButton_Click(object sender, RoutedEventArgs e)
        {
            var task = TaskBox.Text;
            var hourtext = HourBox.Text;
            int hours;
            var isNumeric = int.TryParse(hourtext, out hours);
            if (!isNumeric) MessageBlock.Text = "Voer een heel getal in voor uren!";
            else if (hours <= 0) MessageBlock.Text = "Voer een getal groter dan 0 in!";
            else
            {
                using (var svc = new UrenregistratieServiceClient())
                {
                    var u = svc.SaveHours(task, hours, CurrentUser);
                    if (u != null)
                    {
                        CurrentUser = u;
                        HourBox.Text = "";
                        HourListBox.ItemsSource = svc.GetUserTasks(CurrentUser);
                        MessageBlock.Text = "Uren toegevoegd!";

                    }
                    else
                    {
                        MessageBlock.Text = "Toevoegen niet gelukt, controleer uw invoer.";
                    }
                }
            }
        }

        private void HourEditButton_Click(object sender, RoutedEventArgs e)
        {
            var task = TaskBox.Text;
            var hourtext = HourBox.Text;
            int hours;
            var isNumeric = int.TryParse(hourtext, out hours);
            if (!isNumeric) MessageBlock.Text = "Voer een heel getal in voor uren!";
            else if (hours <= 0) MessageBlock.Text = "Voer een getal groter dan 0 in!";
            else
            {
                using (var svc = new UrenregistratieServiceClient())
                {
                    var u = svc.EditHours(task, hours, CurrentUser);
                    if (u != null)
                    {
                        CurrentUser = u;
                        HourBox.Text = "";
                        HourListBox.ItemsSource = svc.GetUserTasks(CurrentUser);
                        MessageBlock.Text = "Uren gewijzigd!";

                    }
                    else
                    {
                        MessageBlock.Text = "Wijzigen niet gelukt, controleer uw invoer.";
                    }
                }
            }
        }

        private void HourDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var task = TaskBox.Text;
            
            using (var svc = new UrenregistratieServiceClient())
            {
                var u = svc.DeleteHours(task, CurrentUser);
                if (u != null)
                {
                    CurrentUser = u;
                    HourBox.Text = "";
                    HourListBox.ItemsSource = svc.GetUserTasks(CurrentUser);
                    MessageBlock.Text = "Uren verwijderd!";

                }
                else
                {
                    MessageBlock.Text = "Verwijderen niet gelukt, controleer uw invoer.";
                }
            }
        }

        private void MainWindow_OnMouseEnter(object sender, MouseEventArgs e)
        {
            MainProjectLabel.Content = CurrentUser.Project.ProjectName;
            using (var svc = new UrenregistratieServiceClient())
            {
                HourListBox.ItemsSource = svc.GetUserTasks(CurrentUser);
            }
        }

        private void HourBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            MessageBlock.Text = "Voer uw gewerkte uren in de vorm van een heel getal in.";
        }
    }
}
