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
    /// Interaction logic for HotelReservationScreen.xaml
    /// </summary>
    public partial class HotelReservationScreen : Page
    {
        private int tripID;

        public HotelReservationScreen()
        {
            InitializeComponent();
        }

        public HotelReservationScreen(int tripID, string country, string region, string cityName)
        {
            InitializeComponent();
            this.tripID = tripID;
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
            if(CheckValidPositiveInt("Hotel ID", uxHotelID.Text))
            {
                // CONNECT

                int hotelID = int.Parse(uxHotelID.Text);
                // Lookup hotel using hotelID
                // if null
                //      MessageBox.Show("Hotel ID does not already exist");
                // else
                // Hotel hotel = found hotel
                // City city = findCity(hotel.CityID);
                uxHotelName.Text = ""; // = hotel.Name;
                uxHotelAddress.Text = ""; // = hotel.Address;
                uxCity.Text = ""; // = city.CityName;
                uxRegion.Text = ""; // = city.Region;
                uxCountry.Text = ""; // = city.Country;
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
                string hotelName = FormatName(uxHotelName.Text);
                string address = uxHotelAddress.Text;

                string country = FormatName(uxCountry.Text);
                string region = FormatName(uxRegion.Text);
                string city = FormatName(uxCity.Text);

                float roomPrice = float.Parse(uxRoomPrice.Text);
                DateTime checkInDate = (DateTime)uxCheckinDate.SelectedDate;

                // CONNECT

                int cityID = 0;
                //Lookup city using country, region, city
                // if null
                //      create city
                //      cityID = newly created city
                // else
                //      cityID = found city

                // CONNECT
                int hotelID = 0;
                //Lookup hotel using hotelName, address, and cityID
                // if null
                //      create hotel
                //      hotelID = newly created hotel
                // else
                //      hotelID = found hotel

                // CONNECT
                int reservationID = 0;
                // Create new reservation ID, using tripID (field), and set hotel reservation to 1, and all others to 0
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
            if(CheckValidName("Hotel name", uxHotelName.Text) && CheckValidAddress()
                && CheckValidName("Country", uxCountry.Text) && CheckValidName("Region", uxRegion.Text)
                && CheckValidName("City", uxCity.Text) && CheckValidPrice("Room price", uxRoomPrice.Text) 
                && CheckValidDate())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks whether name contains only characters or not; if not, displays appropriate message to user
        /// </summary>
        /// <param name="name">The name of the variable</param>
        /// <param name="s">The string to check</param>
        /// <returns>Whether name contains only characters or not</returns>
        private bool CheckValidName(string name, string s)
        {
            if (s == "")
            {
                MessageBox.Show("Must enter a " + name);
            }
            else
            {
                foreach (char c in s)
                {
                    if (!IsLetter(c) && c != ' ')
                    {
                        MessageBox.Show(name + " must contain only characters");
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks whether a valid hotel address has been entered; if not, display message to user.
        /// </summary>
        /// <returns>Whether valid hotel address has been entered</returns>
        private bool CheckValidAddress()
        {
            if(uxHotelAddress.Text == "")
            {
                MessageBox.Show("Please enter a hotel address");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if char c is a number or not
        /// </summary>
        /// <param name="c">The character to check</param>
        /// <returns>Whether char c is a number or not</returns>
        public bool IsNumber(char c)
        {
            if (c >= '0' && c <= '9')
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Check whether valid price or not; if not, display message to user
        /// </summary>
        /// <param name="name">The name of the variable</param>
        /// <param name="price">The price in question</param>
        /// <returns></returns>
        public bool CheckValidPrice(string name, string price)
        {
            if (price == "")
            {
                MessageBox.Show("Please enter a " + name);
            }
            else
            {
                int numPeriods = 0;
                if (price[0] == '-')
                {
                    MessageBox.Show("Please enter a non-negative value");
                }
                for (int i = 1; i < price.Length; i++)
                {
                    char c = price[i];
                    if (c == '.')
                    {
                        numPeriods++;
                    }

                    if (!IsNumber(c) && c != '.')
                    {
                        MessageBox.Show(name + " must be a number");
                        return false;
                    }

                    if (numPeriods > 1)
                    {
                        MessageBox.Show(name + " must be a valid number");
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks whether char c is a letter or not
        /// </summary>
        /// <param name="c">Whether c is a letter or not</param>
        /// <returns>Whether c is a letter or not</returns>
        public bool IsLetter(char c)
        {
            if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Check to see if check in date has been selected
        /// </summary>
        /// <returns>Whether check in date has been selected</returns>
        private bool CheckValidDate()
        {
            if(uxCheckinDate.SelectedDate == null)
            {
                MessageBox.Show("Please select a check-in date");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Check whether number is a valid positive integer; if not, display message to user
        /// </summary>
        /// <param name="name">Name of the variable</param>
        /// <param name="num">The number to check</param>
        /// <returns>Whether number is a valid positive integer</returns>
        public bool CheckValidPositiveInt(string name, string num)
        {
            if (num == "")
            {
                MessageBox.Show("Please enter a " + name);
            }
            else
            {
                if (num[0] == '-')
                {
                    MessageBox.Show(name + " must be a non-negative integer");
                }
                else
                {
                    foreach (char c in num)
                    {
                        if (!IsNumber(c))
                        {
                            MessageBox.Show(name + " must contain only numbers");
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }



        /// <summary>
        /// Formats string name to be upper case for first letter and lower for rest 
        /// </summary>
        /// <param name="name">The name to format</param>
        /// <returns>Formated string</returns>
        private string FormatName(string name)
        {
            string formatName = "";
            if (name != "")
            {
                bool toUpper = true;                
                for (int i = 0; i < name.Length; i++)
                {
                    if(toUpper)
                    {
                        formatName += char.ToUpper(name[i]);
                        if(IsLetter(name[i]))
                        {
                            toUpper = false;
                        }
                    }
                    else
                    {
                        formatName += char.ToLower(name[i]);
                    }

                    if(name[i] == ' ')
                    {
                        toUpper = true;
                    }
                }
            }
            return formatName;
        }
    }
}
