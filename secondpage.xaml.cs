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
    /// Interaction logic for secondpage.xaml
    /// </summary>
    public partial class secondpage : Page
    {
        public secondpage()
        {            
            InitializeComponent();
        }
        private void Button_Click_back(object sender, RoutedEventArgs e)
        {
            Page1 home = new Page1();
            this.NavigationService.Navigate(home);

        }
        private void Button_submit(object sender, RoutedEventArgs e)
        {
            if (radiobuttonWinter.IsChecked == true)
            {
                Image.Visibility = Visibility.Visible;
                Image2.Visibility = Visibility.Hidden;
                Image3.Visibility = Visibility.Hidden;
                Image4.Visibility = Visibility.Hidden;

            }
            if (radiobuttonSpring.IsChecked == true)
            {
                Image.Visibility = Visibility.Hidden;
                Image2.Visibility = Visibility.Visible;
                Image3.Visibility = Visibility.Hidden;
                Image4.Visibility = Visibility.Hidden;
            }
            if (radiobuttonSummer.IsChecked == true)
            {
                Image.Visibility = Visibility.Hidden;
                Image2.Visibility = Visibility.Hidden;
                Image3.Visibility = Visibility.Visible;
                Image4.Visibility = Visibility.Hidden;
            }
            if (radiobuttonFall.IsChecked == true)
            {
                Image.Visibility = Visibility.Hidden;
                Image2.Visibility = Visibility.Hidden;
                Image3.Visibility = Visibility.Hidden;
                Image4.Visibility = Visibility.Visible;
            }

        }

    }
}
