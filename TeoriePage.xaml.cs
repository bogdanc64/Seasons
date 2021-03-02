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

namespace First_App_In_WPF
{
    /// <summary>
    /// Interaction logic for TeoriePage.xaml
    /// </summary>
    public partial class TeoriePage : Page
    {
        public TeoriePage()
        {
            InitializeComponent();
        }

        private void Button_Click_back(object sender, RoutedEventArgs e)
        {
            secondpage secondPage = new secondpage();
            this.NavigationService.Navigate(secondPage);

        }
    }
}
