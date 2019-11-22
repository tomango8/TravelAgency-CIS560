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
        public PlanTripScreen()
        {
            InitializeComponent();
        }

        public void Done_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MainMenu());
        }

        public void NewHotelReservation_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new HotelReservationScreen());
        }

        public void NewBoardingPass_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new BoardingPassScreen());
        }
    }
}
