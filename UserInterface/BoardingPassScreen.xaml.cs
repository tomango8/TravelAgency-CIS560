using DataAccess;
using DataModeling;
using DataModeling.Model;
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
        private int tripID;
        private string connectionString;
        public BoardingPassScreen()
        {
            InitializeComponent();
        }

        public BoardingPassScreen(string connectionString, int tripID, string city, string country, string region)
        {
            InitializeComponent();
            this.tripID = tripID;
            this.connectionString = connectionString;
            uxArrivalCity.Text = city;
            uxArrivalCountry.Text = country;
            uxArrivalRegion.Text = region;
        }

        /// <summary>
        /// Autofill the flight information given a valid flightID when user clicks "Autofill" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void Autofill_Click(object sender, RoutedEventArgs args)
        {
            string message = "";
            if(Check.ValidPositiveInt("Flight ID", uxFlightID.Text, out message))
            {
                int flightID = int.Parse(uxFlightID.Text);

                // CONNECT TODO

                SqlCommandExecutor executor = new SqlCommandExecutor(connectionString);

                Flight flight = executor.ExecuteNonQuery(new CreateFlightDelegate(flightID));

                if (flight == null)
                {
                    MessageBox.Show("Flight does not exist");
                }
                else
                {
                   
                    Cities departurecity = executor.ExecuteNonQuery(new LocationFetchCityDelegate(flight.CityDepartureID));
                    Cities arrivalcity = executor.ExecuteNonQuery(new LocationFetchCityDelegate(flight.CityArrivalID));

                    uxDepartureCity.Text = departurecity.CityName;
                    uxDepartureCountry.Text = departurecity.Country;
                    uxDepartureRegion.Text = departurecity.Region;
                    uxDepartureTime.Text = flight.DepartureTime.Hour + ":" + flight.DepartureTime.Minute;
                    uxDepartureDate.SelectedDate = new DateTime(flight.DepartureTime.Year, flight.DepartureTime.Month, flight.DepartureTime.Day, 0,0,0);

                    uxArrivalCity.Text = arrivalcity.CityName;
                    uxDepartureCountry.Text = arrivalcity.Country;
                    uxDepartureRegion.Text = arrivalcity.Region;
                    uxArrivalTime.Text = flight.ArrivalTime.Hour + ":" + flight.ArrivalTime.Minute;
                    uxArrivalDate.SelectedDate = new DateTime(flight.ArrivalTime.Year, flight.ArrivalTime.Month, flight.ArrivalTime.Day, 0, 0, 0);

                    // Lookup flight using flightID
                    // if null
                    //      MessageBox.Show("Flight does not already exist");
                    // else
                    // {
                    //      Flight flight = get Flight
                    //      City departureCity = get City (flight.DepartureCityID)
                    //      City arrivalCity = get City (flight.ArrivalCityID)
                    //

                    // CONNECT
                    //uxAirlineName.Text = ""; // = flight.Airline;

                    // CONNECT
                    //  uxDepartureCity.Text = ""; // = departureCity.City;
                    //  uxDepartureCountry.Text = ""; // = departureCity.Country;
                    //  uxDepartureRegion.Text = ""; // = departureCity.Region;
                    //  uxDepartureTime.Text = ""; // = flight.DepartureTime.Hour + ":" + flight.DepartureTime.Minute;
                    //uxDepartureDate.SelectedDate = new DateTime(); // = new DateTime(flight.DepartureTime.Year, 
                                                                   // flight.DepartureTime.Month, flight.DepartureTime.Day, 0,0,0);

                    // CONNECT
                    //uxArrivalCity.Text = ""; // arrivalCity.City;
                    //uxArrivalCountry.Text = ""; // arrivalCity.Country;
                    //uxArrivalRegion.Text = ""; // arrivalCity.Region;
                    //uxArrivalTime.Text = ""; // flight.ArrivalTime.Hour + ":" + flight.DepartureTime.Minute;
                    //uxArrivalDate.SelectedDate = new DateTime(); // = new DateTime(flight.ArrivalTime.Year, 
                                                               // flight.ArrivalTime.Month, flight.ArrivalTime.Day, 0,0,0);
                // } end else
                }
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        /// <summary>
        /// If valid inputs, adds a boarding pass using info when the user clicks "Add Boarding Pass" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddBoardingPass_Click(object sender, RoutedEventArgs args)
        {
            if(CheckValidInputs())
            {
                string airlineName = Check.FormatName(uxAirlineName.Text);
                float boardingPassPrice = float.Parse(uxBoardingPassPrice.Text);

                DateTime departureTime = new DateTime(((DateTime)uxDepartureDate.SelectedDate).Year, ((DateTime)uxDepartureDate.SelectedDate).Month,
                    ((DateTime)uxDepartureDate.SelectedDate).Day, int.Parse(uxDepartureTime.Text.Split(':')[0]),
                    int.Parse(uxDepartureTime.Text.Split(':')[1]), 0);
                string departureCity = Check.FormatName(uxDepartureCity.Text);
                string departureCountry = Check.FormatName(uxDepartureCountry.Text);
                string departureRegion = Check.FormatName(uxDepartureRegion.Text);

                DateTime arrivalTime = new DateTime(((DateTime)uxArrivalDate.SelectedDate).Year, ((DateTime)uxArrivalDate.SelectedDate).Month,
                    ((DateTime)uxArrivalDate.SelectedDate).Day, int.Parse(uxArrivalTime.Text.Split(':')[0]),
                    int.Parse(uxArrivalTime.Text.Split(':')[1]), 0);
                string arrivalCity = Check.FormatName(uxArrivalCity.Text);
                string arrivalCountry = Check.FormatName(uxArrivalCountry.Text);
                string arrivalRegion = Check.FormatName(uxArrivalRegion.Text);

                // CONNECT
                int departureCityID = 0;
                SqlCommandExecutor executor = new SqlCommandExecutor(connectionString);

                Cities departurecitysearch = executor.ExecuteReader(new LocationGetCityDelegate(departureCountry, departureRegion, departureCity));
                //Lookup departure city, using departureCity, departureCountry, departureRegion
                if (departurecitysearch == null)
                {
                    Cities newdeparturecity = executor.ExecuteNonQuery(new LocationCreateCityDelegate(departureCity,departureRegion,departureCountry));
                //      create new city
                    departureCityID = newdeparturecity.CityID;
                //      departureCityID = newly created city
                }
                else
                {
                    departureCityID = departurecitysearch.CityID;
                //      departureCityID = found city
                }


                // CONNECT
                int arrivalCityID = 0;

                Cities arrivalcitysearch = executor.ExecuteReader(new LocationGetCityDelegate(arrivalCountry, arrivalRegion, arrivalCity));
                //Lookup arrival city, using arrivalCity, arrivalCountry, arrivalRegion
                if (arrivalcitysearch == null)
                {
                    Cities newarrivalcity = executor.ExecuteNonQuery(new LocationCreateCityDelegate(arrivalCity,arrivalRegion,arrivalCountry));
                //      create new city
                    arrivalCityID = newarrivalcity.CityID;
                //      arrivalCityID = newly created city
                }
                else
                {
                    arrivalCityID = arrivalcitysearch.CityID;
                }
                //      arrivalCityID = found city


                // CONNECT
                int flightID = 0;

                Flight flightsearch = executor.ExecuteReader(new GetFlightDelegate(airlineName, departureTime, departureCityID, arrivalTime, arrivalCityID));
                if (flightsearch == null)
                {
                    Flight flight = executor.ExecuteNonQuery(new CreateFlightDelegate(flightID));
                    flightID = flight.FlightID;
                }
                else
                {
                    flightID = flightsearch.FlightID;
                }

                //Lookup flight info, using airlineName, departureTime, departureCityID, arrivalTime, arrivalCityID
                // if null
                //      create new flight - might want to switch depatureTime to be a DATETIME in SQL
                //      flightID = newly created flight
                // else)
                //      flightID = found flight

                // CONNECT
                int reservationID = 0;

                Reservation res = executor.ExecuteNonQuery(new CreateReservationDelegate(tripID, false, false, true, false, false));
                reservationID = res.ReservationID;

                BoardingPass bp = executor.ExecuteNonQuery(new CreateBoardingPassDelegate(reservationID, flightID, boardingPassPrice));
                // Create new reservation using tripID(field) and set BoardingPass to 1, everything else to 0
                // reservationID = newly created reservation

                // CONNECT
                // Create new boarding pass using reservationID, flightID, boardingPassPrice,  

                MessageBox.Show("Boarding pass successfully added to flight " + flightID + " with airline " + airlineName);                
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
