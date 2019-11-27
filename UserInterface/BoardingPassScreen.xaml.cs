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
    /// Interaction logic for BoardingPassScreen.xaml
    /// </summary>
    public partial class BoardingPassScreen : Page
    {
        public BoardingPassScreen()
        {
            InitializeComponent();
        }

        public void AddBoardingPass_Click(object sender, RoutedEventArgs args)
        {
            if(CheckValidInputs())
            {

            }
        }

        public void Done_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }

        /// <summary>
        /// Checks whether all valid inputs have been entered; if not, display appropriate message to user
        /// </summary>
        /// <returns>Whether all valid inputs or not</returns>
        private bool CheckValidInputs()
        {
            string message = "";
            if(Check.ValidName("Airline", uxAirlineName.Text, out message)
                && Check.ValidPositiveFloat("Boarding pass price", uxBoardingPassPrice.Text, out message)
                && Check.ValidTime("Departure Time", uxDepartureTime.Text, out message)
                && Check.ValidName("Departure City", uxDepartureCity.Text, out message)
                && Check.ValidName("Departure Country", uxDepartureCountry.Text, out message)
                && Check.ValidName("Departure Region", uxDepartureRegion.Text, out message)
                && Check.NonNull("Departure Date", uxDepartureDate.SelectedDate, out message)
                && Check.ValidTime("Arrival Time", uxArrivalTime.Text, out message)
                && Check.ValidName("Arrival City", uxArrivalCity.Text, out message)
                && Check.ValidName("Arrival Country", uxArrivalCountry.Text, out message)
                && Check.ValidName("Arrival Region", uxArrivalRegion.Text, out message)
                && Check.NonNull("Arrival Date", uxArrivalDate.SelectedDate, out message))
            {
                return true;
            }
            MessageBox.Show(message);
            return false;
        }
    }
}
