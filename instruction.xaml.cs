using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Flip_Me
{
    public partial class instruction : PhoneApplicationPage
    {
        public instruction()
        {
            InitializeComponent();
        }

        private void Back_instruct_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Flip-Me;component/MainPage.xaml", UriKind.Relative));
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            Instruct.Text = "You have to make above sequence in minimum no. of moves(<=500)";
        }
    }
}