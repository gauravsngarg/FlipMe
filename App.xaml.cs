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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;

namespace Flip_Me
{
    
       public partial class App : Application
    {
        
        /// <summary>
        /// Provides easy access to the root frame of the Phone Application.
        /// </summary>
        /// <returns>The root frame of the Phone Application.</returns>
        public PhoneApplicationFrame RootFrame { get; private set; }

        /// <summary>
        /// Constructor for the Application object.
        /// </summary>
        public App()
        {
            // Global handler for uncaught exceptions. 
            UnhandledException += Application_UnhandledException;

            // Standard Silverlight initialization
            InitializeComponent();

            // Phone-specific initialization
            InitializePhoneApplication();

            // Show graphics profiling information while debugging.
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // Display the current frame rate counters.
                Application.Current.Host.Settings.EnableFrameRateCounter = true;

                // Show the areas of the app that are being redrawn in each frame.
                //Application.Current.Host.Settings.EnableRedrawRegions = true;

                // Enable non-production analysis visualization mode, 
                // which shows areas of a page that are handed off to GPU with a colored overlay.
                //Application.Current.Host.Settings.EnableCacheVisualization = true;

                // Disable the application idle detection by setting the UserIdleDetectionMode property of the
                // application's PhoneApplicationService object to Disabled.
                // Caution:- Use this under debug mode only. Application that disables user idle detection will continue to run
                // and consume battery power when the user is not using the phone.
                PhoneApplicationService.Current.UserIdleDetectionMode = IdleDetectionMode.Disabled;
            }

        }

        // Code to execute when the application is launching (eg, from Start)
        // This code will not execute when the application is reactivated
        private void Application_Launching(object sender, LaunchingEventArgs e)
        {
            
            LoadState();
        }

        // Code to execute when the application is activated (brought to foreground)
        // This code will not execute when the application is first launched
        private void Application_Activated(object sender, ActivatedEventArgs e)
        {
            LoadState();
        }

        // Code to execute when the application is deactivated (sent to background)
        // This code will not execute when the application is closing
        private void Application_Deactivated(object sender, DeactivatedEventArgs e)
        {
            SaveState();
        }

        // Code to execute when the application is closing (eg, user hit Back)
        // This code will not execute when the application is deactivated
        private void Application_Closing(object sender, ClosingEventArgs e)
        {
            SaveState();
        }

        // Code to execute if a navigation fails
        private void RootFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // A navigation has failed; break into the debugger
                System.Diagnostics.Debugger.Break();
            }
        }

        // Code to execute on Unhandled Exceptions
        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // An unhandled exception has occurred; break into the debugger
                System.Diagnostics.Debugger.Break();
            }
        }

        private void SaveState()
        {
            PhoneApplicationService phoneAppService = PhoneApplicationService.Current;
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
           // string myValue = "";
            // Take whatever is in our temporary "state bag" and save it to
            // the phone's permanent flash memory.
            
                SaveState_partialCheck();
          
        }
        private void SaveState_partialCheck()
        {
            PhoneApplicationService phoneAppService = PhoneApplicationService.Current;
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
            settings["myValue"] = phoneAppService.State["myValue"];
            settings["yValue"] = "4";
            settings["myValue1"] = phoneAppService.State["myValue1"];
            settings["myValue2"] = phoneAppService.State["myValue2"];
            settings["myValue3"] = phoneAppService.State["myValue3"];
            settings["myValue4"] = phoneAppService.State["myValue4"];
            settings["myValue5"] = phoneAppService.State["myValue5"];
            settings["myValue6"] = phoneAppService.State["myValue6"];
            settings["myValue7"] = phoneAppService.State["myValue7"];
            settings["myValue8"] = phoneAppService.State["myValue8"];
            settings["myValue9"] = phoneAppService.State["myValue9"];
            settings["myValue10"] = phoneAppService.State["myValue10"];
            settings["myValue11"] = phoneAppService.State["myValue11"];
            settings["myValue12"] = phoneAppService.State["myValue12"];
            settings["myValue13"] = phoneAppService.State["myValue13"];
            settings["myValue14"] = phoneAppService.State["myValue14"];
            settings["myValue15"] = phoneAppService.State["myValue15"];
            settings["myValue16"] = phoneAppService.State["myValue16"];
            settings["myValuec"] = phoneAppService.State["myValuec"];
            
        }

        public void LoadState()
        {
            PhoneApplicationService phoneAppService = PhoneApplicationService.Current;
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;

            string myValue = "", yValue = "";

            if (settings.TryGetValue<string>("myValue", out myValue))
            {
                phoneAppService.State["myValue"] = myValue;
               // LoadState_partialCheck();
            }
            if (settings.TryGetValue<string>("yValue", out yValue))
            {
                phoneAppService.State["yValue"] = yValue;
                // LoadState_partialCheck();
            }
        }
            
        //private void LoadState_partialCheck()
        //    {
        //        PhoneApplicationService phoneAppService = PhoneApplicationService.Current;
        //        IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;

        //          string  myValue1 = "", myValue2 = "", myValue3 = "", myValue4 = "", myValue5 = "", myValue6 = "", myValue7 = "", myValue8 = "", myValue9 = "", myValue10 = "",
        //        myValue11 = "", myValue12 = "", myValue13 = "", myValue14 = "", myValue15 = "", myValue16 = "", myValuec = "";
        //    if (settings.TryGetValue<string>("myValue1", out myValue1))
        //    {
        //        phoneAppService.State["myValue1"] = myValue1;
        //    }
        //    if (settings.TryGetValue<string>("myValue2", out myValue2))
        //    {
        //        phoneAppService.State["myValue2"] = myValue2;
        //    }
        //    if (settings.TryGetValue<string>("myValue3", out myValue3))
        //    {
        //        phoneAppService.State["myValue3"] = myValue3;
        //    }
        //    if (settings.TryGetValue<string>("myValue4", out myValue4))
        //    {
        //        phoneAppService.State["myValue4"] = myValue4;
        //    }
        //    if (settings.TryGetValue<string>("myValue5", out myValue5))
        //    {
        //        phoneAppService.State["myValue5"] = myValue5;
        //    }
        //    if (settings.TryGetValue<string>("myValue6", out myValue6))
        //    {
        //        phoneAppService.State["myValue6"] = myValue6;
        //    }
        //    if (settings.TryGetValue<string>("myValue7", out myValue7))
        //    {
        //        phoneAppService.State["myValue7"] = myValue7;
        //    }
        //    if (settings.TryGetValue<string>("myValue8", out myValue8))
        //    {
        //        phoneAppService.State["myValue8"] = myValue8;
        //    }
        //    if (settings.TryGetValue<string>("myValue9", out myValue9))
        //    {
        //        phoneAppService.State["myValue9"] = myValue9;
        //    }
        //    if (settings.TryGetValue<string>("myValue10", out myValue10))
        //    {
        //        phoneAppService.State["myValue10"] = myValue10;
        //    }
        //    if (settings.TryGetValue<string>("myValue11", out myValue11))
        //    {
        //        phoneAppService.State["myValue11"] = myValue11;
        //    }
        //    if (settings.TryGetValue<string>("myValue12", out myValue12))
        //    {
        //        phoneAppService.State["myValue12"] = myValue12;
        //    }
        //    if (settings.TryGetValue<string>("myValue13", out myValue13))
        //    {
        //        phoneAppService.State["myValue13"] = myValue13;
        //    }
        //    if (settings.TryGetValue<string>("myValue14", out myValue14))
        //    {
        //        phoneAppService.State["myValue14"] = myValue14;
        //    }
        //    if (settings.TryGetValue<string>("myValue15", out myValue15))
        //    {
        //        phoneAppService.State["myValue15"] = myValue15;
        //    }
        //    if (settings.TryGetValue<string>("myValue16", out myValue16))
        //    {
        //        phoneAppService.State["myValue16"] = myValue16;
        //    }
        //    if (settings.TryGetValue<string>("myValuec", out myValuec))
        //    {
        //        phoneAppService.State["myValuec"] = myValuec;
        //    }
        
        //}

        
        

       

        #region Phone application initialization

        // Avoid double-initialization
        private bool phoneApplicationInitialized = false;

        // Do not add any additional code to this method
        private void InitializePhoneApplication()
        {
            if (phoneApplicationInitialized)
                return;

            // Create the frame but don't set it as RootVisual yet; this allows the splash
            // screen to remain active until the application is ready to render.
            RootFrame = new PhoneApplicationFrame();
            RootFrame.Navigated += CompleteInitializePhoneApplication;

            // Handle navigation failures
            RootFrame.NavigationFailed += RootFrame_NavigationFailed;

            // Ensure we don't initialize again
            phoneApplicationInitialized = true;
        }

        // Do not add any additional code to this method
        private void CompleteInitializePhoneApplication(object sender, NavigationEventArgs e)
        {
            // Set the root visual to allow the application to render
            if (RootVisual != RootFrame)
                RootVisual = RootFrame;

            // Remove this handler since it is no longer needed
            RootFrame.Navigated -= CompleteInitializePhoneApplication;
        }

        #endregion
    }
}