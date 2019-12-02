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
    /// Interaction logic for TripStatisticsScreen.xaml
    /// </summary>
    public partial class TripStatisticsScreen : Page
    {
        private string connectionString;

        public TripStatisticsScreen()
        {
            InitializeComponent();
        }

        public TripStatisticsScreen(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
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

        public void Report1_Click(object sender, RoutedEventArgs args)
        {
            // CONNECT
            // query report 1
            // load report 1 into uxReportList
            // set uxReportListLabel of what each column represents
        }

        public void Report2_Click(object sender, RoutedEventArgs args)
        {
            // CONNECT
            // query report 2
            // load report 2 into uxReportList
            // set uxReportListLabel of what each column represents
        }

        public void Report3_Click(object sender, RoutedEventArgs args)
        {
            // CONNECT
            // query report 3
            // load report 3 into uxReportList
            // set uxReportListLabel of what each column represents
        }

        public void Report4_Click(object sender, RoutedEventArgs args)
        {
            // CONNECT
            // query report 4
            // load report 4 into uxReportList
            // set uxReportListLabel of what each column represents
        }
    }
}
