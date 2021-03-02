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
           if(radiobuttonTeorie.IsChecked==true)
            {
                TeoriePage teoriePage = new TeoriePage();
                this.NavigationService.Navigate(teoriePage);
            }

           else if (radiobuttonProbleme.IsChecked == true)
            {
                ProblemePage problemePage = new ProblemePage();
                this.NavigationService.Navigate(problemePage);
            }
        }

        private void rb_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Name)
            {
                case "radiobuttonTeorie":
                    Image.Source = new BitmapImage(new Uri("pack://application:,,,/Images/theory.jpg", UriKind.Absolute));
                    return;
                case "radiobuttonProbleme":
                    Image.Source = new BitmapImage(new Uri("pack://application:,,,/Images/coding.jpg", UriKind.Absolute));
                    return;
            }
        }

    }
}
