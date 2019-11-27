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
    /// Interaction logic for NewAttractionTicketScreen.xaml
    /// </summary>
    public partial class NewAttractionTicketScreen : Page
    {
        private int tripID;

        public NewAttractionTicketScreen()
        {
            InitializeComponent();
        }

        public NewAttractionTicketScreen(int tripID, string city, string region, string country)
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
        /// Autofills some of the information given an attractionID when the user clicks "Autofill" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void Autofill_Click(object sender, RoutedEventArgs args)
        {
            string message = "";
            if(Check.ValidPositiveInt("Attraction ID", uxAttractionID.Text, out message))
            {
                int attractionID = int.Parse(uxAttractionID.Text);

                // CONNECT
                // Lookup attraction using attractionID
                // if null
                //      MessageBox.Show("Attraction does not already exist");
                // else
                // {
                //      Attraction attraction = get Attraction (attractionID);
                //      City city = get City (attraction.CityID);

                // CONNECT
                    uxAttractionName.Text = ""; // = attraction.Name;
                    uxCity.Text = ""; // = city.City;
                    uxCountry.Text = ""; // = city.Country;
                    uxRegion.Text = ""; // = city.Region
                // } end else
            }   
            else
            {
                MessageBox.Show(message);
            }
        }

        /// <summary>
        /// If valid inputs, make new attraction ticket when the user clicks "Add Ticket" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTicket_Click(object sender, RoutedEventArgs args)
        {
            if(CheckValidInputs())
            {
                string attractionName = Check.FormatName(uxAttractionName.Text);
                float ticketPrice = float.Parse(uxTicketPrice.Text);
                DateTime ticketDate = (DateTime)uxDate.SelectedDate;

                string country = Check.FormatName(uxCountry.Text);
                string region = Check.FormatName(uxRegion.Text);
                string city = Check.FormatName(uxCity.Text);

                // CONNECT
                int cityID = 0;

                // Lookup city, using country, region, city
                // if null
                //      create new city
                //      cityID = newly created city
                // else
                //      cityID = found city

                // CONNECT
                int attractionID = 0;

                // Lookup attraction, using attractionName, cityID
                // if null
                //      create new attraction
                //      attractionID = newly created attraction
                // else
                //      attractionID = found attraction

                // CONNECT
                int reservationID = 0;

                // create new reservation using tripID and set AttractionTicket bit to 1 and the rest to 0
                // reservationID = newly created reservation

                // CONNECT
                // create new AttractionTicket using reservationID, attractionID, ticketPrice, ticketDate

                MessageBox.Show("Attraction ticket successfully added for attraction " + attractionName);
            }
        }

        /// <summary>
        /// Checks that all valid inputs have been entered; if not, display appropriate message to user
        /// </summary>
        /// <returns>Whether all valid inputs</returns>
        private bool CheckValidInputs()
        {
            string message = "";
            if(Check.ValidName("Attraction name", uxAttractionName.Text, out message)
                && Check.ValidPositiveFloat("Ticket price", uxTicketPrice.Text, out message)                
                && Check.NonNull("Ticket date", uxDate.SelectedDate, out message)
                && Check.ValidName("Country", uxCountry.Text, out message)
                && Check.ValidName("Region", uxRegion.Text, out message)
                && Check.ValidName("City", uxCity.Text, out message))
            {
                return true;
            }
            MessageBox.Show(message);
            return false;
        }
    }
}
