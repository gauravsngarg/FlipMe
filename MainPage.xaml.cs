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
using System.IO.IsolatedStorage;
using Microsoft.Phone.Shell;

namespace Flip_Me
{
    public partial class MainPage : PhoneApplicationPage
    {
        //IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void playbutton_Click(object sender, RoutedEventArgs e)
        {
            
            NavigationService.Navigate(new Uri("/Flip-Me;component/Page1.xaml?id=1", UriKind.Relative));
        }

        private void resumeButton_Click(object sender, RoutedEventArgs e)
        {
           
            NavigationService.Navigate(new Uri("/Flip-Me;component/Page1.xaml?id=2", UriKind.Relative));
            

        }
        

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            PhoneApplicationService phoneAppService = PhoneApplicationService.Current;
            object myValue;
            if (phoneAppService.State.ContainsKey("myValue"))
            {
                if (phoneAppService.State.TryGetValue("myValue", out myValue))
                {
                    if(myValue.Equals("check"))
                    resumeButton1.Visibility = System.Windows.Visibility.Visible;
                    else if (myValue.Equals("finish"))
                    {
                        resumeButton1.Visibility = System.Windows.Visibility.Collapsed;
                    }
                }

            }
            else
                resumeButton1.Visibility = System.Windows.Visibility.Collapsed;

            // If there are journal entries on the back navigation stack 
   
           
        // Remove and get the most recent entry on the back navigation stack
                this.NavigationService.RemoveBackEntry();
           
          }

        

        private void Instruction_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Flip-Me;component/instruction.xaml", UriKind.Relative));
        }
    }
}