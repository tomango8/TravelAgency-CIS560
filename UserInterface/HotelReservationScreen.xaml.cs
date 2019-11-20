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
        public HotelReservationScreen()
        {
            InitializeComponent();
        }

        public void AddReservation_Click (object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
