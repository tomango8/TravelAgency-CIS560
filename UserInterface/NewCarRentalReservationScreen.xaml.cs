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

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for NewCarRentalReservationScreen.xaml
    /// </summary>
    public partial class NewCarRentalReservationScreen : Page
    {
        private int tripID;

        public NewCarRentalReservationScreen()
        {
            InitializeComponent();
        }

        public NewCarRentalReservationScreen(int tripID, string city, string region, string country)
        {
            InitializeComponent();
            this.tripID = tripID;
            uxCity.Text = city;
            uxRegion.Text = region;
            uxCountry.Text = country;
        }

        /// <summary>
        /// Return to the plan trip screen when the user clicks "Done" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void Done_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }

        /// <summary>
        /// Autofills the car rental information for car rental id when the user clicks "Autofill" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void Autofill_Click(object sender, RoutedEventArgs args)
        {
            string message = "";
            if(Check.ValidPositiveInt("Car Rental ID", uxCarRentalID.Text, out message))
            {
                int carRentalID = int.Parse(uxCarRentalID.Text);

                // CONNECT
                // Lookup CarRentalAgency using carRentalID
                // if null
                //      MessageBox.Show("Car Rental Agency does not yet exist");
                // else
                // {
                //      CarRentalAgency agency = get CarRentalAgency(carRentalID)
                //      City city = get city (agency.CityID)

                // CONNECT
                        uxCarRentalAgencyName.Text = ""; // = agency.Name;
                        uxCity.Text = ""; // = city.Name;
                        uxCountry.Text = ""; // = city.Country;
                        uxRegion.Text = ""; // = city.Region;
                // } end else
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        /// <summary>
        /// If valid inputs, create new car rental reservation when the user clicks "Add Reservation" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddReservation_Click(object sender, RoutedEventArgs args)
        {
            if(CheckValidInputs())
            {
                string carAgencyName = Check.FormatName(uxCarRentalAgencyName.Text);
                string carModel = Check.FormatName(uxCarModel.Text);
                float rentalPrice = float.Parse(uxRentalPrice.Text);
                DateTime rentalDate = (DateTime)uxRentalDate.SelectedDate;

                string city = Check.FormatName(uxCity.Text);
                string country = Check.FormatName(uxCountry.Text);
                string region = Check.FormatName(uxRegion.Text);

                // CONNECT
                int cityID = 0;

                // Lookup city, using city, country, and region
                // if null
                //      create new city
                //      cityID = newly created city
                // else
                //      cityID = foundCity

                // CONNECT
                int carRentalID = 0;

                // Lookup CarRentalAgency using carAgencyName, cityID
                // if null
                //      create new agency
                //      carRentalID = newly created agency
                // else
                //      carRentalID = found agency

                // CONNECT
                int reservationID = 0;

                // Create new reservation using tripID (field) and set CarReservation bit to 1 and the rest to 0
                // reservationID = newly created reservation

                // CONNECT
                // Create new CarRentalReservation using reservationID, carRentalID, rentalDate, carModel, rentalPrice

                MessageBox.Show("Car successfully reserved with agency " + carAgencyName);
            }
        }

        /// <summary>
        /// Check that all entries are valid; if not, display appropriate message to user
        /// </summary>
        /// <returns>Whether all entries are valid</returns>
        private bool CheckValidInputs()
        {
            string message = "";
            if (Check.ValidName("Car Rental Agency Name", uxCarRentalAgencyName.Text, out message)
                && Check.NonNull("Model of Car", uxCarModel.Text, out message)
                && Check.ValidPositiveFloat("Rental price", uxRentalPrice.Text, out message)
                && Check.NonNull("Rental date", uxRentalDate.SelectedDate, out message)
                && Check.ValidName("City", uxCity.Text, out message)
                && Check.ValidName("Country", uxCountry.Text, out message)
                && Check.ValidName("Region", uxRegion.Text, out message))
            {
                return true;
            }
            MessageBox.Show(message);
            return false;
        }
    }
}
