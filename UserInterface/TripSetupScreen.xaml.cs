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
            if(CheckValidInputs() && CheckValidIDs())
            {
                int agentID = int.Parse(uxAgentID.Text);
                int customerID = int.Parse(uxCustomerID.Text);

                // CONNECT
                // Create Trip using agent id and customer id
                int tripID = 0; // = get trip id that was just created

                NavigationService.Navigate(new PlanTripScreen(tripID, uxCountry.Text, uxCity.Text, uxRegion.Text));
            }            
        }

        /// <summary>
        /// Checks whether the string is a number or not
        /// </summary>
        /// <param name="value">The string to check</param>
        /// <returns>Whether string is value or not</returns>
        private bool IsValue(string value)
        {
            foreach(char c in value)
            {
                if(c < '0' || c > '9')
                {
                    return false;
                }                
            }
            return true;
        }

        /// <summary>
        /// Check that all inputs are valid; if not, display appropriate message to user
        /// </summary>
        /// <returns>Whether valid inputs or not</returns>
        private bool CheckValidInputs()
        {
            if (uxAgentID.Text == "")
            {
                MessageBox.Show("Must contain an AgentID");
            }
            else if (uxCustomerID.Text == "")
            {
                MessageBox.Show("Must contain a Customer ID");
            }
            else if (!IsValue(uxAgentID.Text))
            {
                MessageBox.Show("AgentID must be a number");
            }
            else if (!IsValue(uxCustomerID.Text))
            {
                MessageBox.Show("CustomerID must be a number");
            }
            else
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks that the customer and agent exist in database; if not, display appropriate message to user
        /// </summary>
        /// <returns>Whether IDs exist in database</returns>
        private bool CheckValidIDs()
        {
            if(!LookupAgentID(int.Parse(uxAgentID.Text)))
            {
                MessageBox.Show("Agent ID does not exist");
            }
            else if(!LookupCustomerID(int.Parse(uxCustomerID.Text)))
            {
                MessageBox.Show("Customer ID does not exist");
            }
            else
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Lookup to see whether the agent id exists in database
        /// </summary>
        /// <param name="id">The agent id to lookup</param>
        /// <returns>Whether the agent is in the database or not</returns>
        private bool LookupAgentID(int id)
        {
            // CONNECT

            // if null
            // return false            
            return true;
        }

        /// <summary>
        /// Lookup to see whether the customer id exists in database
        /// </summary>
        /// <param name="id">The customer id to lookup</param>
        /// <returns>Whether the customer is in the database or not</returns>
        private bool LookupCustomerID(int id)
        {
            // CONNECT

            // if null
            // return false
            return true;
        }        
    }
}
