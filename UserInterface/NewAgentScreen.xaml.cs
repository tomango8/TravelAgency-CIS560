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

        public void AddAgent_Click(object sender, RoutedEventArgs args)
        {

        }

        public void Done_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
