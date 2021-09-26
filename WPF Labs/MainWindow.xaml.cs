using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WPF_Labs.Model;

namespace WPF_Labs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private ObservableCollection<Client> _clients = new ObservableCollection<Client>();

        public MainWindow()
        {
            InitializeComponent();

            SetComboBox();

            clientsTable.DataContext = _clients;
        }

        private void SetComboBox()
        {
            city.ItemsSource = Enum.GetValues(typeof(City)).Cast<City>();
            city.SelectedValue = City.Kyiv;
        }

        private void Exit_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddClient_OnClick(object sender, RoutedEventArgs e)
        {
            var client = new Client {FirstName = firstName.Text, LastName = lastName.Text};

            int sitNumber = 0;
            int flighNum = 0;

            if (!SitIsCorrect(out sitNumber)) return;

            if (!FlightIsCorrect(out flighNum)) return;

            client.SitNumber = sitNumber;
            client.FlightNumber = flighNum;

            client.TakeOffDate = calendar.SelectedDate ?? DateTime.Today;
            client.DestinationCity = (City) city.SelectedItem;

            client.Cost = new Random().Next(1500, 2000);

            client.IsVip = vip.IsChecked;
            if (client.IsVip == true)
            {
                client.Cost /= 2;
            }

            _clients.Add(client);
        }

        private bool FlightIsCorrect(out int flightNumber)
        {
            bool flightIsCorrect = Int32.TryParse(this.flightNum.Text, out flightNumber);

            if (!flightIsCorrect)
            {
                MessageBox.Show("Flight number is not in range of 1-10! Try again.");
                return false;
            }

            return true;
        }

        private bool SitIsCorrect(out int sitNumber)
        {
            bool sitIsCorrect = Int32.TryParse(sitNum.Text, out sitNumber);
            var i = sitNumber;
            var isOcuppied = _clients.FirstOrDefault(c => c.SitNumber == i) != null;

            if (!sitIsCorrect || isOcuppied)
            {
                MessageBox.Show("Sit number is not in range of 1-300 or has already been occupied! Try again.");
                return false;
            }

            return true;
        }

        private void ClearAll_OnClick(object sender, RoutedEventArgs e)
        {
            _clients.Clear();
        }

        private void ClearFields_OnClick(object sender, RoutedEventArgs e)
        {
            firstName.Text = "";
            lastName.Text = "";
            sitNum.Text = "0";
            flightNum.Text = "0";
            vip.IsChecked = false;
            calendar.SelectedDate = null;
        }
    }
}