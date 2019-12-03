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
    /// Interaction logic for TripSetupScreen.xaml
    /// </summary>
    public partial class TripSetupScreen : Page
    {
        private string connectionString;

        public TripSetupScreen()
        {
            InitializeComponent();
        }

        public TripSetupScreen(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            LoadAllAgents();
            LoadAllCustomers();
        }        

        /// <summary>
        /// Open a new agent screen when the user clicks "New Agent" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void NewAgent_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new NewAgentScreen(connectionString));
        }

        /// <summary>
        /// Open a new customer screen when the user clicks "New Customer" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void NewCustomer_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new NewCustomerScreen(connectionString));
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
            NavigationService.Navigate(new MainMenu(connectionString));
        }

        /// <summary>
        /// Filters out agents based on min value; if null, displays all agents when user clicks "Search" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SearchAgents_Click(object sender, RoutedEventArgs args)
        {
            LoadAllAgents();
            if(uxAgentID.Text != "")
            {
                string message = "";
                if(Check.ValidPositiveInt("AgentID", uxAgentID.Text, out message))
                {
                    FilterMinAgents(int.Parse(uxAgentID.Text));
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
        }

        /// <summary>
        /// Filters out customers based on min value; if null, displays all customers when user clicks "Search" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SearchCustomers_Click(object sender, RoutedEventArgs args)
        {
            LoadAllCustomers();
            if (uxCustomerID.Text != "")
            {
                string message = "";
                if (Check.ValidPositiveInt("CustomerID", uxCustomerID.Text, out message))
                {
                    FilterMinCustomers(int.Parse(uxCustomerID.Text));
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
        }

        /// <summary>
        /// When user clicks "Plan Trip" button, 
        /// if valid information, create new trip and open new plan trip screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void PlanTrip_Click(object sender, RoutedEventArgs args)
        {
            if(CheckValidInputs() && uxAgents.SelectedItem is TextBlock agent && uxCustomers.SelectedItem is TextBlock customer)
            {
                int agentID = int.Parse(agent.Text.Split(',')[0].Trim());
                int customerID = int.Parse(customer.Text.Split(',')[0].Trim());
                
                // CONNECT                
                
                SqlCommandExecutor executor = new SqlCommandExecutor(connectionString);

                // Lookup agent using agentID
                if (executor.ExecuteReader(new AgencyGetAgentDelegate(agentID)) == null)
                {
                    MessageBox.Show("Agent does not exist in database");
                }
                // Lookup customer using customerID
                else if (executor.ExecuteReader(new AgencyGetCustomerDelegate(customerID)) == null)
                {
                    MessageBox.Show("Customer does not exist in database");
                }
                else
                {
                    //Create trip
                    Trip trip = executor.ExecuteNonQuery(new AgencyCreateTripDelegate(customerID, agentID));

                    if(trip == null)
                    {
                        MessageBox.Show("Trip failed to be created");
                    }
                    else
                    {                       
                        // Navigate to plan trip screen   
                        NavigationService.Navigate(new PlanTripScreen(connectionString, trip.TripID, uxCountry.Text, uxRegion.Text, uxCity.Text));
                    }
                }            
            }            
        }        

        /// <summary>
        /// Check that all inputs are valid; if not, display appropriate message to user
        /// </summary>
        /// <returns>Whether valid inputs or not</returns>
        private bool CheckValidInputs()
        {
            if(uxAgents.SelectedItem == null)
            {
                MessageBox.Show("Please select an agent");
            }
            else if(uxCustomers.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer");
            }
            else
            {
                return true;
            }
            return false;
        }
        
        /// <summary>
        /// Load all agents into the agent list
        /// </summary>
        private void LoadAllAgents()
        {
            uxAgents.Items.Clear();

            // CONNECT
            // Get list of all agents
            // load all agents into uxAgents

            // Test code - delete when connected to SQL
            for(int i = 1; i < 16; i++)
            {
                TextBlock t = new TextBlock();
                t.Text = i + ", AgentName";
                uxAgents.Items.Add(t);
            }
            RefreshAgentList();
        }

        /// <summary>
        /// Load all customers into the customer list
        /// </summary>
        private void LoadAllCustomers()
        {
            uxCustomers.Items.Clear();

            // CONNECT
            // Get list of all customers
            // load all customers into uxCustomers

            // Test code - detele when connected to SQL
            for(int i = 1; i < 51; i++)
            {
                TextBlock t = new TextBlock();
                t.Text = i + ", CustomerName, CustomerInformation...";
                uxCustomers.Items.Add(t);
            }
            RefreshCustomerList();
        }

        /// <summary>
        /// Filters agents by minAgentID
        /// </summary>
        /// <param name="minAgentID">Minimum agent id in agents</param>
        private void FilterMinAgents(int minAgentID)
        {
            for(int i = 0; i < uxAgents.Items.Count; i++)
            {
                object item = uxAgents.Items[i];
                if(item is TextBlock t)
                {
                    if(int.Parse(t.Text.Split(',')[0].Trim()) < minAgentID)
                    {
                        uxAgents.Items.Remove(item);
                        i--;
                    }
                }
            }
        }

        /// <summary>
        /// Filters customers by minCustomerID
        /// </summary>
        /// <param name="minCustomerID">Minimum customer id in customers</param>
        private void FilterMinCustomers(int minCustomerID)
        {
            for (int i = 0; i < uxCustomers.Items.Count; i++)
            {
                object item = uxCustomers.Items[i];
                if (item is TextBlock t)
                {
                    if (int.Parse(t.Text.Split(',')[0].Trim()) < minCustomerID)
                    {
                        uxCustomers.Items.Remove(item);
                        i--;
                    }
                }
            }
        }

        /// <summary>
        /// Refresh the agent list
        /// </summary>
        private void RefreshAgentList()
        {
            ListBox l = uxAgents;
            uxAgents = l;
        }

        /// <summary>
        /// Refresh the customer list
        /// </summary>
        private void RefreshCustomerList()
        {
            ListBox l = uxCustomers;
            uxCustomers = l;
        }
    }
}
