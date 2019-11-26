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
    /// Interaction logic for NewCustomerScreen.xaml
    /// </summary>
    public partial class NewCustomerScreen : Page
    {
        public NewCustomerScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Return to the Trip Setup Screen when the user clicks "Done" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void Done_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }

        /// <summary>
        /// Add the customer to database if valid inputs when the user clicks "Add Customer" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddCustomer_Click(object sender, RoutedEventArgs args)
        {
            if(CheckValidInputs())
            {
                string name = FormatName(uxFirstName.Text) + " " + FormatName(uxLastName.Text);
                float budget = float.Parse(uxBudget.Text);
                int age = int.Parse(uxAge.Text);
                string sex = (bool)uxMale.IsChecked ? "Male" : "Female";

                string address = uxAddress.Text + "\n" + FormatName(uxCity.Text) + ", " + uxZipcode.Text;
                string phone = uxAreaCode.Text + uxFirst3PhoneDigits.Text + uxLast4PhoneDigits.Text;
                string email = uxEmail.Text;

                string city = FormatName(uxCity.Text);
                string region = FormatName(uxRegion.Text);
                string country = FormatName(uxCountry.Text);

                // CONNNECT
                int cityID = 0;
                // Lookup city using city, region, country
                // if city == null
                //      create city
                //      cityID = newly created city
                // else
                //      cityID = found city

                // CONNECT
                int contactID = 0;
                // Create new contact info using address, phone, email, cityID
                // contactID = newly created contact

                // CONNECT
                int customerID = 0;
                // Create new customer using budget, name, age, sex, contactID
                // customerID = newly created customer

                MessageBox.Show("Customer " + name + " has been successfully added. CustomerID = " + customerID);
            }
        }

        /// <summary>
        /// Checks whether valid inputs have been entered; if not, display appropriate message to user
        /// </summary>
        /// <returns>Whether all valid inputs have been entered</returns>
        private bool CheckValidInputs()
        {
            if(CheckValidName("First Name", uxFirstName.Text) && CheckValidName("Last Name", uxLastName.Text)
                && CheckValidPhoneNumber() && CheckValidAge() && CheckValidSex() && CheckValidEmail() 
                && CheckIsValue("Budget", uxBudget.Text) && CheckValidAddress()
                && CheckValidName("Country", uxCountry.Text) && CheckValidName("Region", uxRegion.Text)
                && CheckValidName("City", uxCity.Text) && CheckValidZipcode())
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
                    if ((c < 'a' || c > 'z') && (c < 'A' || c > 'Z'))
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
        /// Check to confirm value is a non negative integer; if not, display the appropriate message.
        /// </summary>
        /// <param name="name">The name of the variable</param>
        /// <param name="value">The value to check</param>
        /// <returns>Whether value is a number or not</returns>
        private bool CheckIsValue(string name, string value)
        {
            if(value == "")
            {
                MessageBox.Show("Must enter a " + name);                
            }
            else
            {
                foreach(char c in value)
                {
                    if( (c < '0' || c > '9'))
                    {
                        MessageBox.Show(name + " must be a number");
                        return false;
                    }                    
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks to confirm that a valid phone number was entered; if not, display appropriate message to user
        /// </summary>
        /// <returns>Whether valid phone number was entered</returns>
        private bool CheckValidPhoneNumber()
        {
            if(CheckIsValue("Area code", uxAreaCode.Text) && CheckIsValue("Phone number", uxFirst3PhoneDigits.Text)
                && CheckIsValue("Phone number", uxLast4PhoneDigits.Text))
            {
                if(uxAreaCode.Text.Length != 3)
                {
                    MessageBox.Show("Area code must be 3 digits");
                }
                else if(uxFirst3PhoneDigits.Text.Length != 3)
                {
                    MessageBox.Show("Second box in phone number must be 3 digits");
                }
                else if(uxLast4PhoneDigits.Text.Length != 4)
                {
                    MessageBox.Show("Last box in phone number must be 4 digits");
                }
                else
                {
                    return true;
                }                        
            }
            return false;
        }

        /// <summary>
        /// Check that a valid age has been entered; if not, display to the user
        /// </summary>
        /// <returns>Whether a valid age or not</returns>
        private bool CheckValidAge()
        {
            if(CheckIsValue("Age", uxAge.Text))
            {
                int age = int.Parse(uxAge.Text);
                if(age < 16)
                {
                    MessageBox.Show("Customer must be registered with someone at least 16");
                }
                else if(age > 150)
                {
                    MessageBox.Show("Recheck age");
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Check to make sure that a sex has been selected; if not, display appropriate message.
        /// </summary>
        /// <returns>Whether a sex has been selected</returns>
        private bool CheckValidSex()
        {
            if(!(bool)uxMale.IsChecked && !(bool)uxFemale.IsChecked)
            {
                MessageBox.Show("Please select a sex");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Check whether a valid email has been entered; if not, display appropriate message to user
        /// </summary>
        /// <returns>Whether a valid email has been entered</returns>
        private bool CheckValidEmail()
        {            
            if(uxEmail.Text == "")
            {
                MessageBox.Show("Please enter an email");
            }
            else
            {
                int atChar = 0;
                int period = 0;
                for(int i = 0; i < uxEmail.Text.Length; i++)
                {
                    if(uxEmail.Text[i] == '@')
                    {
                        atChar++;
                    }
                    if(atChar == 1 && uxEmail.Text[i] == '.')
                    {
                        period++;
                    }
                }
                if(atChar != 1)
                {
                    MessageBox.Show("A valid email contains only 1 @");
                }
                else if(period != 1)
                {
                    MessageBox.Show("A valid email contains 1 and only 1 period after the @");
                }
                else if(uxEmail.Text[uxEmail.Text.Length - 1] == '.')
                {
                    MessageBox.Show("A valid email does not end on a period");
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Checks whether a valid address has been entered; if not, display message to user
        /// </summary>
        /// <returns>Whether a valid address has been entered</returns>
        private bool CheckValidAddress()
        {
            if(uxAddress.Text == "")
            {
                MessageBox.Show("Please enter an address");
                return false;
            }
            return true;
        }        

        /// <summary>
        /// Checks whether a valid zipcode has been entered; if not, display message to user
        /// </summary>
        /// <returns>Whether a valid zipcode has been entered</returns>
        private bool CheckValidZipcode()
        {
            if(CheckIsValue("Zipcode", uxZipcode.Text))
            {
                if(uxZipcode.Text.Length != 5)
                {
                    MessageBox.Show("Zipcode must be a 5 digit code");
                }
                else
                {
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
