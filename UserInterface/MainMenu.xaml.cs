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
    /// Main menu for travel agency
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open new trip setup page when user clicks "New Trip" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void NewTrip_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new TripSetupScreen());
        }

        /// <summary>
        /// Open new search trip screen when user clicks "Search Trips" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SearchTrips_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SearchTripsScreen());
        }

        /// <summary>
        /// Open trip statistics page when user clicks "Trip Statistics" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void TripStatistics_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new TripStatisticsScreen());
        }
    }
}
