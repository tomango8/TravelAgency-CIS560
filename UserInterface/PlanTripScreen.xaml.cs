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
    /// Interaction logic for PlanTripScreen.xaml
    /// </summary>
    public partial class PlanTripScreen : Page
    {
        private int tripID;
        private string country;
        private string region;
        private string cityName;

        public PlanTripScreen()
        {
            InitializeComponent();
        }

        public PlanTripScreen(int tripID, string country, string region, string cityName)
        {
            InitializeComponent();
            this.tripID = tripID;
            this.country = country;
            this.region = region;
            this.cityName = cityName;
        }

        /// <summary>
        /// Return to main menu when user clicks "Done" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void Done_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MainMenu());
        }

        /// <summary>
        /// Navigate to new hotel reservation page when user clicks "New Hotel Reservation" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void NewHotelReservation_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new HotelReservationScreen(tripID, country, region, cityName));
        }

        /// <summary>
        /// Navigate to new boarding pass page when user clicks "New Boarding Pass" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void NewBoardingPass_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new BoardingPassScreen(tripID, cityName, country, region));
        }

        /// <summary>
        /// Navigate to new attraction ticket page when user clicks "New Attraction Ticket" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void NewAttractionTicket_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new NewAttractionTicketScreen(tripID, cityName, region, country));
        }

        /// <summary>
        /// Navigate to new restaurant reservation page when user clicks "New Restaurant Reservation" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void NewRestaurantReservation_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new NewRestaurantReservationScreen(tripID, cityName, region, country));
        }

        /// <summary>
        /// Navigate to new car rental reservation page when user clicks "New Car Rental Reservation" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void NewCarRentalReservation_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new NewCarRentalReservationScreen(tripID, cityName, region, country));
        }
    }
}
