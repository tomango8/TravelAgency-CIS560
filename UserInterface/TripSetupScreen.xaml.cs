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

        public TripSetupScreen(string agentID, string customerID)
        {
            InitializeComponent();
            uxAgentID.Text = agentID;
            uxCustomerID.Text = customerID;
        }

        /// <summary>
        /// Open a new agent screen when the user clicks "New Agent" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void NewAgent_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new NewAgentScreen());
        }

        /// <summary>
        /// Open a new customer screen when the user clicks "New Customer" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void NewCustomer_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new NewCustomerScreen());
        }

        /// <summary>
        /// Return to the main menu when the user clicks "Main Menu" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void MainMenu_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }

        /// <summary>
        /// Go to main menu when the user clicks "Done" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void Done_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MainMenu());
        }

        /// <summary>
        /// When user clicks "Plan Trip" button, 
        /// if valid information, create new trip and open new plan trip screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void PlanTrip_Click(object sender, RoutedEventArgs args)
        {
            if(CheckValidInputs())
            {
                int agentID = int.Parse(uxAgentID.Text);
                int customerID = int.Parse(uxCustomerID.Text);
                // CONNECT
                // Lookup agent using agentID
                // Lookup customer using customerID
                // if agent is null
                //      MessageBox.Show("Agent does not exist");
                // else if customer is null
                //      MessageBox.Show("Customer does not exist");
                // else
                // {

                // CONNECT
                //      Create Trip using agent id and customer id
                        int tripID = 0; // = get trip id that was just created

                        NavigationService.Navigate(new PlanTripScreen(tripID, uxCountry.Text, uxRegion.Text, uxCity.Text));
                // } end else
            }            
        }        

        /// <summary>
        /// Check that all inputs are valid; if not, display appropriate message to user
        /// </summary>
        /// <returns>Whether valid inputs or not</returns>
        private bool CheckValidInputs()
        {
            string message = "";
            if(Check.ValidPositiveInt("Agent ID", uxAgentID.Text, out message)
                && Check.ValidPositiveInt("Customer ID", uxCustomerID.Text, out message))
            {
                return true;
            }
            MessageBox.Show(message);
            return false;
        }        
    }
}
