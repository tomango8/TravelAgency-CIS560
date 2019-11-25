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
    /// Interaction logic for SearchTripsScreen.xaml
    /// </summary>
    public partial class SearchTripsScreen : Page
    {
        public SearchTripsScreen()
        {
            InitializeComponent();
        }

        public void MainMenu_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }

        public void UpdateTrip_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new PlanTripScreen());
        }
    }
}
