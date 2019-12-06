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
using DataAccess;
using DataModeling;
using DataModeling.Model;

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for HotelReservationScreen.xaml
    /// </summary>
    public partial class HotelReservationScreen : Page
    {
        private int tripID;
        private string connectionString;

        public HotelReservationScreen()
        {
            InitializeComponent();
        }

        public HotelReservationScreen(string connectionString, int tripID, string country, string region, string cityName)
        {
            InitializeComponent();
            this.tripID = tripID;
            this.connectionString = connectionString;
            uxCountry.Text = country;
            uxRegion.Text = region;
            uxCity.Text = cityName;
        }

        /// <summary>
        /// Autofills the hotel information from valid hotel id when user clicks "Autofill" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void Autofill_Click(object sender, RoutedEventArgs args)
        {
            string message = "";
            if(Check.ValidPositiveInt("Hotel ID", uxHotelID.Text, out message))
            {
                // CONNECT

                SqlCommandExecutor executor = new SqlCommandExecutor(connectionString);

                int hotelID = int.Parse(uxHotelID.Text);
                // Lookup hotel using hotelID

                Hotel hotel = executor.ExecuteReader(new HotelsGetHotelDelegate(hotelID));

                if (hotel == null)
                {
                    MessageBox.Show("Hotel ID does not exist");
                }
                else
                {
                    
                        uxHotelName.Text = hotel.Name;
                        uxHotelName.Text = hotel.FullAddress;
                    City city = executor.ExecuteNonQuery(new LocationCreateCityDelegate(hotel.CityID));
                    
                        uxCity.Text = city.CityName; 
                        uxRegion.Text = city.Region;
                        uxCountry.Text = city.Country;
                    
              
                    // if null
                    //      MessageBox.Show("Hotel ID does not already exist");
                    // else
                    // Hotel hotel = found hotel
                    // City city = findCity(hotel.CityID);
                //uxHotelName.Text = ""; // = hotel.Name;
                //uxHotelAddress.Text = ""; // = hotel.Address;
                //uxCity.Text = ""; // = city.CityName;
                //uxRegion.Text = ""; // = city.Region;
                //uxCountry.Text = ""; // = city.Country;
                }
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        /// <summary>
        /// If valid inputs, adds a hotel reservation to the trip when the user clicks "Add Reservation" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddReservation_Click (object sender, RoutedEventArgs args)
        {
           if(CheckValidInputs())
            {
                string hotelName = Check.FormatName(uxHotelName.Text);
                string address = uxHotelAddress.Text;

                string country = Check.FormatName(uxCountry.Text);
                string region = Check.FormatName(uxRegion.Text);
                string cityname = Check.FormatName(uxCity.Text);

                float roomPrice = float.Parse(uxRoomPrice.Text);
                DateTime checkInDate = (DateTime)uxCheckinDate.SelectedDate;

                // CONNECT

                int cityID = 0;
                SqlCommandExecutor executor = new SqlCommandExecutor(connectionString);

                City citysearch = executor.ExecuteReader(new LocationGetCityDelegate(country, region, cityname));

                if (citysearch == null)
                {
                    City city = executor.ExecuteNonQuery(new LocationCreateCityDelegate(cityname,region, country));
                    cityID = city.CityID;
                }
                else
                {
                    cityID = citysearch.CityID;
                }
                //Lookup city using country, region, city
                // if null
                //      create city
                //      cityID = newly created city
                // else
                //      cityID = found city

                // CONNECT
                int hotelID = 0;

                Hotel hotelsearch = executor.ExecuteReader(new HotelsGetHotelDelegate(hotelID));
                if (hotelsearch == null)
                {
                    Hotel hotel = executor.ExecuteNonQuery(new HotelsCreateHotelDelegate(hotelID));
                    hotelID = hotel.HotelID;
                }
                else
                {
                    hotelID = hotelsearch.HotelID;
                }
                //Lookup hotel using hotelName, address, and cityID
                // if null
                //      create hotel
                //      hotelID = newly created hotel
                // else
                //      hotelID = found hotel

                // CONNECT
                int reservationID = 0;

                Reservation res = executor.ExecuteNonQuery(new CreateReservationDelegate(tripID,false, true, false, false, false));
                reservationID = res.ReservationID;

                HotelReservation hr = executor.ExecuteNonQuery(new HotelsCreateHotelReservationDelegate(reservationID, hotelID, checkInDate, roomPrice));

                // Create new reservation, using tripID (field), and set hotel reservation to 1, and all others to 0
                // reservationID = newly created reservation ID

                // CONNECT
                // Create new hotel reservation using reservationID, hotelID, checkInDate, roomPrice

                MessageBox.Show("Reservation at " + hotelName + " successfully added");
            }
        }

        /// <summary>
        /// Return to the trip planning screen when the user clicks "Done" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void Done_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }

        /// <summary>
        /// Whether all valid inputs have been entered; if not, display appropriate message to user
        /// </summary>
        /// <returns>Whether all valid inputs have been entered</returns>
        private bool CheckValidInputs()
        {
            string message = "";
            if(Check.ValidName("Hotel name", uxHotelName.Text, out message) && Check.NonNull("Hotel address", uxHotelAddress.Text, out message)
                && Check.ValidName("Country", uxCountry.Text, out message) && Check.ValidName("Region", uxRegion.Text, out message)
                && Check.ValidName("City", uxCity.Text, out message) && Check.ValidPositiveFloat("Room price", uxRoomPrice.Text, out message) 
                && Check.NonNull("Check-in date", uxCheckinDate.SelectedDate, out message))
            {
                return true;
            }
            MessageBox.Show(message);
            return false;
        }     

    }
}
