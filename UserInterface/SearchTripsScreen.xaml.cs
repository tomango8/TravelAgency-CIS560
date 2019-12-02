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
        //private List<Trip> trips = new List<Trip>();

        public SearchTripsScreen()
        {
            InitializeComponent();
            LoadAllTrips();
        }

        public void MainMenu_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }

        public void Search_Click(object sender, RoutedEventArgs args)
        {            

            
        }

        /// <summary>
        /// Opens a new plan trip screen to update the selected trip when user clicks "Update Trip" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void UpdateTrip_Click(object sender, RoutedEventArgs args)
        {
            if (uxTrips.SelectedItem != null)
            {

                if (uxTrips.SelectedItem is TextBlock)
                {
                    TextBlock t = (TextBlock)uxTrips.SelectedItem;
                    int tripID = int.Parse(t.Text.Split(',')[0].Trim());

                    NavigationService.Navigate(new PlanTripScreen(tripID));
                }
                else
                {
                    MessageBox.Show("Can't access selected item");
                }
            }
            else
            {
                MessageBox.Show("Please select a trip to update");
            }
        }

        /// <summary>
        /// Deletes the selected trip when the user clicks "Delete Trip" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void DeleteTrip_Click(object sender, RoutedEventArgs args)
        {
            if(uxTrips.SelectedItem != null)
            { 

                if(uxTrips.SelectedItem is TextBlock t)
                {                    
                    int tripID;                  
                    tripID = int.Parse(t.Text.Split(',')[0].Trim());
                    
                    // CONNECT
                    // delete trip using tripID

                    uxTrips.Items.Remove(uxTrips.SelectedItem);
                    ListBox l = uxTrips;
                    uxTrips = l;
                    MessageBox.Show("Trip " + tripID + " has been removed");
                }
                else
                {
                    MessageBox.Show("Can't access selected item");
                }
            }
            else
            {
                MessageBox.Show("Please select a trip to delete");
            }
        }

        private void LoadAllTrips()
        {
            for (int i = 1; i < 51; i++)
            {
                TextBlock t = new TextBlock();
                t.Text = i + ", CustomerName, CustomerID, AgentName, AgentID, DateCreated";
                uxTrips.Items.Add(t);
            }

            ListBox l = uxTrips;
            uxTrips = l;
        }

        private void FilterByTripID(int tripID)
        {
            foreach(object item in uxTrips.Items)
            {
                if(item is TextBlock t)
                {
                    int compareTripID = int.Parse(t.Text.Split(',')[0].Trim());
                    if(compareTripID != tripID)
                    {
                        
                    }
                }
            }
        }
    }
}
