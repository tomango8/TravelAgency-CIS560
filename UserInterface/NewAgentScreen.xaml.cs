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
    /// Interaction logic for NewAgentScreen.xaml
    /// </summary>
    public partial class NewAgentScreen : Page
    {
        public NewAgentScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add agent to the database if valid entries when user clicks "Add Agent" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddAgent_Click(object sender, RoutedEventArgs args)
        {
            if(CheckValidName(uxAgentFirstName.Text) && CheckValidName(uxAgentLastName.Text) && CheckValidSalary())
            {
                string fullName = FormatName(uxAgentFirstName.Text) + " " + FormatName(uxAgentLastName.Text);
                float salary = float.Parse(uxSalary.Text);

                // CONNECT 
                // Create New Agent
                int agentID = 0; // = Newly Created Agent ID

                MessageBox.Show("Agent " + fullName + " successfully added. Agent ID = " + agentID);
            }
        }

        public void Done_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }

        /// <summary>
        /// Checks whether name contains only characters or not; if not, displays appropriate message to user
        /// </summary>
        /// <param name="name">The name to check</param>
        /// <returns>Whether name contains only characters or not</returns>
        private bool CheckValidName(string name)
        {
            if(name == "")
            {
                MessageBox.Show("Must enter a name");
            }
            else
            {
                foreach(char c in name)
                {
                    if( (c < 'a' || c > 'z') && (c < 'A' || c > 'Z') )
                    {
                        MessageBox.Show("Name must contain only characters");
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks to confirm that salary is valid entry; if not, display message to user
        /// </summary>
        /// <returns>Whether salary is valid entry</returns>
        private bool CheckValidSalary()
        {
            if(uxSalary.Text == "")
            {
                MessageBox.Show("Must enter a salary");
            }
            else
            {
                int decimalChars = 0;
                foreach (char c in uxSalary.Text)
                {
                    if(c == '.')
                    {
                        decimalChars++;
                    }
                    if ((c < '0' || c > '9') && c != '.' || decimalChars > 1)
                    {
                        MessageBox.Show("Salary must be a number");
                        return false;
                    }
                }
                return true;
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
            if(name != "")
            {
                formatName += char.ToUpper(name[0]);
                for (int i = 1; i < name.Length; i++)
                {
                    formatName += char.ToLower(name[i]);
                }
            }
            return formatName;
        }
    }
}
