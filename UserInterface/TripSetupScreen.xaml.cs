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
    /// Interaction logic for TripSetupScreen.xaml
    /// </summary>
    public partial class TripSetupScreen : Page
    {
        public TripSetupScreen()
        {
            InitializeComponent();
        }

        public void NewAgent_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new NewAgentScreen());
        }

        public void NewCustomer_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new NewCustomerScreen());
        }

        public void MainMenu_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }

        public void Done_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MainMenu());
        }

        public void PlanTrip_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new PlanTripScreen());
        }
    }
}
