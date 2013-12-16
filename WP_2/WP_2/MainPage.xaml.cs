using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WP_2.Resources;

namespace WP_2
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        // Funkcja odpowiada za otwarcie nowej strony SecondPage
        private void NextPage(object sender, EventArgs e)
        {
            // UriKind.Relative oznacza że identyfikator URI został już wcześniej zdefiniowany (w tym przypadku /SecondPage.xaml)
            NavigationService.Navigate(new Uri("/SecondPage.xaml", UriKind.Relative));
        }
    }
}