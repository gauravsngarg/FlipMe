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
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;

namespace Flip_Me
{
    public partial class Page1 : PhoneApplicationPage
    {
        // Constructor
        int[] a;
        int[] b;
        int c;

        public Page1()
        {
            a = new int[16];
            b = new int[16];
            c = 0;
            InitializeComponent();
        }

        PhoneApplicationService phoneAppService = PhoneApplicationService.Current;


        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string id;
            id = NavigationContext.QueryString["id"];
            

            if (id.Equals("1"))
            {
                //for (int i = 0; i < 14; i++)
                //{
                //    a[i] = i + 1;
                //}
                //a[14] = 16;
                //a[15] = 15;
                random();
            }
            else if (id.Equals("2"))
            {
                //random();
                string yValue = "";
                IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
                if (settings.TryGetValue<string>("yValue", out yValue))
                {
                    if (yValue.Equals("4"))
                    {
                       LoadState();
                       
                    }
                    settings["yValue"] = "2";
                }
                
                
               appStateLoad();
            }
            
            appStateSave();
        }
        private void LoadState()
        {
            //App obj = new App();
            //obj.LoadState();

            PhoneApplicationService phoneAppService = PhoneApplicationService.Current;
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;

            string myValue = "";

            if (settings.TryGetValue<string>("myValue", out myValue))
            {
                //phoneAppService.State["myValue"] = myValue;
                LoadState_partialCheck();
            }
        }
        private void LoadState_partialCheck()
        {
            PhoneApplicationService phoneAppService = PhoneApplicationService.Current;
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;

            string myValue1 = "", myValue2 = "", myValue3 = "", myValue4 = "", myValue5 = "", myValue6 = "", myValue7 = "", myValue8 = "", myValue9 = "", myValue10 = "",
          myValue11 = "", myValue12 = "", myValue13 = "", myValue14 = "", myValue15 = "", myValue16 = "", myValuec = "";
            if (settings.TryGetValue<string>("myValue1", out myValue1))
            {
                phoneAppService.State["myValue1"] = myValue1;
            }
            if (settings.TryGetValue<string>("myValue2", out myValue2))
            {
                phoneAppService.State["myValue2"] = myValue2;
            }
            if (settings.TryGetValue<string>("myValue3", out myValue3))
            {
                phoneAppService.State["myValue3"] = myValue3;
            }
            if (settings.TryGetValue<string>("myValue4", out myValue4))
            {
                phoneAppService.State["myValue4"] = myValue4;
            }
            if (settings.TryGetValue<string>("myValue5", out myValue5))
            {
                phoneAppService.State["myValue5"] = myValue5;
            }
            if (settings.TryGetValue<string>("myValue6", out myValue6))
            {
                phoneAppService.State["myValue6"] = myValue6;
            }
            if (settings.TryGetValue<string>("myValue7", out myValue7))
            {
                phoneAppService.State["myValue7"] = myValue7;
            }
            if (settings.TryGetValue<string>("myValue8", out myValue8))
            {
                phoneAppService.State["myValue8"] = myValue8;
            }
            if (settings.TryGetValue<string>("myValue9", out myValue9))
            {
                phoneAppService.State["myValue9"] = myValue9;
            }
            if (settings.TryGetValue<string>("myValue10", out myValue10))
            {
                phoneAppService.State["myValue10"] = myValue10;
            }
            if (settings.TryGetValue<string>("myValue11", out myValue11))
            {
                phoneAppService.State["myValue11"] = myValue11;
            }
            if (settings.TryGetValue<string>("myValue12", out myValue12))
            {
                phoneAppService.State["myValue12"] = myValue12;
            }
            if (settings.TryGetValue<string>("myValue13", out myValue13))
            {
                phoneAppService.State["myValue13"] = myValue13;
            }
            if (settings.TryGetValue<string>("myValue14", out myValue14))
            {
                phoneAppService.State["myValue14"] = myValue14;
            }
            if (settings.TryGetValue<string>("myValue15", out myValue15))
            {
                phoneAppService.State["myValue15"] = myValue15;
            }
            if (settings.TryGetValue<string>("myValue16", out myValue16))
            {
                phoneAppService.State["myValue16"] = myValue16;
            }
            if (settings.TryGetValue<string>("myValuec", out myValuec))
            {
                phoneAppService.State["myValuec"] = myValuec;
            }

        }

        private void appStateLoad()
        {
            
            object myValue;
            if (phoneAppService.State.ContainsKey("myValue"))
            {
                if (phoneAppService.State.TryGetValue("myValue", out myValue))
                {
                    appstateLoad_partial_check();
                }
            }
        }

        #region appstateLoad_partial_check
        private void appstateLoad_partial_check()
        {
            
            object myValue1, myValue2, myValue3, myValue4, myValue5, myValue6, myValue7, myValue8, myValue9, myValue10, myValue11, myValue12, myValue13, myValue14
                , myValue15, myValue16, myValuec;

            if (phoneAppService.State.ContainsKey("myValue1"))
            {
                if (phoneAppService.State.TryGetValue("myValue1", out myValue1))
                {
                    button1.Content = myValue1.ToString();
                    if (button1.Content.Equals(""))
                        button1.Visibility = System.Windows.Visibility.Collapsed;
                }
            }

            if (phoneAppService.State.ContainsKey("myValue2"))
            {
                if (phoneAppService.State.TryGetValue("myValue2", out myValue2))
                {
                    button2.Content = myValue2.ToString();
                    if (button2.Content.Equals(""))
                        button2.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
            if (phoneAppService.State.ContainsKey("myValue3"))
            {
                if (phoneAppService.State.TryGetValue("myValue3", out myValue3))
                {
                    button3.Content = myValue3.ToString();
                    if (button3.Content.Equals(""))
                        button3.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
            if (phoneAppService.State.ContainsKey("myValue4"))
            {
                if (phoneAppService.State.TryGetValue("myValue4", out myValue4))
                {
                    button4.Content = myValue4.ToString();
                    if (button4.Content.Equals(""))
                        button4.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
            if (phoneAppService.State.ContainsKey("myValue5"))
            {
                if (phoneAppService.State.TryGetValue("myValue5", out myValue5))
                {
                    button5.Content = myValue5.ToString();
                    if (button5.Content.Equals(""))
                        button5.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
            if (phoneAppService.State.ContainsKey("myValue6"))
            {
                if (phoneAppService.State.TryGetValue("myValue6", out myValue6))
                {
                    button6.Content = myValue6.ToString();
                    if (button6.Content.Equals(""))
                        button6.Visibility = System.Windows.Visibility.Collapsed;
                }
            }

            if (phoneAppService.State.ContainsKey("myValue7"))
            {
                if (phoneAppService.State.TryGetValue("myValue7", out myValue7))
                {
                    button7.Content = myValue7.ToString();
                    if (button7.Content.Equals(""))
                        button7.Visibility = System.Windows.Visibility.Collapsed;
                }
            }

            if (phoneAppService.State.ContainsKey("myValue8"))
            {
                if (phoneAppService.State.TryGetValue("myValue8", out myValue8))
                {
                    button8.Content = myValue8.ToString();
                    if (button8.Content.Equals(""))
                        button8.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
            if (phoneAppService.State.ContainsKey("myValue9"))
            {
                if (phoneAppService.State.TryGetValue("myValue9", out myValue9))
                {
                    button9.Content = myValue9.ToString();
                    if (button9.Content.Equals(""))
                        button9.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
            if (phoneAppService.State.ContainsKey("myValue10"))
            {
                if (phoneAppService.State.TryGetValue("myValue10", out myValue10))
                {
                    button10.Content = myValue10.ToString();
                    if (button10.Content.Equals(""))
                        button10.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
            if (phoneAppService.State.ContainsKey("myValue11"))
            {
                if (phoneAppService.State.TryGetValue("myValue11", out myValue11))
                {
                    button11.Content = myValue11.ToString();
                    if (button11.Content.Equals(""))
                        button11.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
            if (phoneAppService.State.ContainsKey("myValue12"))
            {
                if (phoneAppService.State.TryGetValue("myValue12", out myValue12))
                {
                    button12.Content = myValue12.ToString();
                    if (button12.Content.Equals(""))
                        button12.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
            if (phoneAppService.State.ContainsKey("myValue13"))
            {
                if (phoneAppService.State.TryGetValue("myValue13", out myValue13))
                {
                    button13.Content = myValue13.ToString();
                    if (button13.Content.Equals(""))
                        button13.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
            if (phoneAppService.State.ContainsKey("myValue14"))
            {
                if (phoneAppService.State.TryGetValue("myValue14", out myValue14))
                {
                    button14.Content = myValue14.ToString();
                    if (button14.Content.Equals(""))
                        button14.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
            if (phoneAppService.State.ContainsKey("myValue15"))
            {
                if (phoneAppService.State.TryGetValue("myValue15", out myValue15))
                {
                    button15.Content = myValue15.ToString();
                    if (button15.Content.Equals(""))
                        button15.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
            if (phoneAppService.State.ContainsKey("myValue16"))
            {
                if (phoneAppService.State.TryGetValue("myValue16", out myValue16))
                {
                    button16.Content = myValue16.ToString();
                    if (button16.Content.Equals(""))
                        button16.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
            if (phoneAppService.State.ContainsKey("myValuec"))
            {
                if (phoneAppService.State.TryGetValue("myValuec", out myValuec))
                {
                    c = int.Parse(myValuec.ToString());
                    label2.Text = c.ToString();
                }
            }
        }
        #endregion

        
        private void appStateSave()
        {
           
            phoneAppService.State["myValue"] = "check";
            phoneAppService.State["myValue1"] = button1.Content;
            phoneAppService.State["myValue2"] = button2.Content;
            phoneAppService.State["myValue3"] = button3.Content;
            phoneAppService.State["myValue4"] = button4.Content;
            phoneAppService.State["myValue5"] = button5.Content;
            phoneAppService.State["myValue6"] = button6.Content;
            phoneAppService.State["myValue7"] = button7.Content;
            phoneAppService.State["myValue8"] = button8.Content;
            phoneAppService.State["myValue9"] = button9.Content;
            phoneAppService.State["myValue10"] = button10.Content;
            phoneAppService.State["myValue11"] = button11.Content;
            phoneAppService.State["myValue12"] = button12.Content;
            phoneAppService.State["myValue13"] = button13.Content;
            phoneAppService.State["myValue14"] = button14.Content;
            phoneAppService.State["myValue15"] = button15.Content;
            phoneAppService.State["myValue16"] = button16.Content;
            phoneAppService.State["myValuec"] = c.ToString();

        }

        // private void random1()
        //{
        //    //Random r = new Random();
        //    //for (int i = 0; i < 16; i++)
        //    //{
        //    //    a[i] = r.Next(1, 16);
        //    //}
        //    //for (int i = 0; i < 16; i++)
        //    //{
        //    //    for (int j = i + 1; j < 16; j++)
        //    //    {
        //    //        if (a[i] == a[j])
        //    //            a[j] = 0;
        //    //    }
        //    //}
        //    //int x = 0;
        //    //for (int i = 1; i <= 16; i++)
        //    //{
        //    //    int f = 0;
        //    //    for (int j = 0; j < 16; j++)
        //    //    {
        //    //        if (i == a[j])
        //    //            f = 1;
        //    //    }
        //    //    if (f != 1)
        //    //    {
        //    //        b[x] = i;
        //    //        x++;
        //    //    }
        //    //}
        //    //int x1 = 0;
        //    //for (int i = 0; i < 16; i++)
        //    //{
        //    //    if (a[i] == 0)
        //    //    {
        //    //        a[i] = b[x1];
        //    //        x1++;
        //    //    }
        //    //}
        //    this.button1.Content = a[0].ToString();
        //    this.button2.Content = a[1].ToString();
        //    this.button3.Content = a[2].ToString();
        //    this.button4.Content = a[3].ToString();
        //    this.button5.Content = a[4].ToString();
        //    this.button6.Content = a[5].ToString();
        //    this.button7.Content = a[6].ToString();
        //    this.button8.Content = a[7].ToString();
        //    this.button9.Content = a[8].ToString();
        //    this.button10.Content = a[9].ToString();
        //    this.button11.Content = a[10].ToString();
        //    this.button12.Content = a[11].ToString();
        //    this.button13.Content = a[12].ToString();
        //    this.button14.Content = a[13].ToString();
        //    this.button15.Content = a[14].ToString();
        //    this.button16.Content = a[15].ToString();
        //    //if (button1.Content == "0" && button1.Content == "16")
        //    //{
        //    //    bool up = button1.Content.Equals("16");
        //    //    Console.WriteLine(up);
        //    //}
        //    if (button1.Content.Equals("16"))
        //    {
        //        this.button1.Content = "";
        //        button1.Visibility = System.Windows.Visibility.Collapsed;

        //    }
        //    else if (this.button2.Content.Equals("16"))
        //    {
        //        this.button2.Content = "";
        //        button2.Visibility = System.Windows.Visibility.Collapsed;
        //    }
        //    else if (this.button3.Content.Equals("16"))
        //    {
        //        this.button3.Content = "";
        //        button3.Visibility = System.Windows.Visibility.Collapsed;
        //    }
        //    else if (this.button4.Content.Equals("16"))
        //    {
        //        this.button4.Content = "";
        //        button4.Visibility = System.Windows.Visibility.Collapsed;
        //    }
        //    else if (this.button5.Content.Equals("16"))
        //    {
        //        this.button5.Content = "";
        //        button5.Visibility = System.Windows.Visibility.Collapsed;
        //    }
        //    else if (this.button6.Content.Equals("16"))
        //    {
        //        this.button6.Content = "";
        //        button6.Visibility = System.Windows.Visibility.Collapsed;
        //    }
        //    else if (this.button7.Content.Equals("16"))
        //    {
        //        this.button7.Content = "";
        //        button7.Visibility = System.Windows.Visibility.Collapsed;
        //    }
        //    else if (this.button8.Content.Equals("16"))
        //    {
        //        this.button8.Content = "";
        //        button8.Visibility = System.Windows.Visibility.Collapsed;
        //    }
        //    else if (this.button9.Content.Equals("16"))
        //    {
        //        this.button9.Content.Equals("16");
        //        button9.Visibility = System.Windows.Visibility.Collapsed;
        //    }
        //    else if (this.button10.Content.Equals("16"))
        //    {
        //        this.button10.Content = "";
        //        button10.Visibility = System.Windows.Visibility.Collapsed;
        //    }
        //    else if (this.button11.Content.Equals("16"))
        //    {
        //        this.button11.Content = "";
        //        button11.Visibility = System.Windows.Visibility.Collapsed;
        //    }
        //    else if (this.button12.Content.Equals("16"))
        //    {
        //        this.button12.Content = "";
        //        button12.Visibility = System.Windows.Visibility.Collapsed;
        //    }
        //    else if (this.button13.Content.Equals("16"))
        //    {
        //        this.button13.Content = "";
        //        button13.Visibility = System.Windows.Visibility.Collapsed;
        //    }
        //    else if (this.button14.Content.Equals("16"))
        //    {
        //        this.button14.Content = "";
        //        button14.Visibility = System.Windows.Visibility.Collapsed;
        //    }
        //    else if (this.button15.Content.Equals("16"))
        //    {
        //        this.button15.Content = "";
        //        button15.Visibility = System.Windows.Visibility.Collapsed;
        //    }
        //    else if (this.button16.Content.Equals("16"))
        //    {
        //        this.button16.Content = "";
        //        button16.Visibility = System.Windows.Visibility.Collapsed;
        //    }

        //    this.label2.Text = "0";
        //}
        


        #region Random function
        private void random()
        {
            Random r = new Random();
            for (int i = 0; i < 16; i++)
            {
                a[i] = r.Next(1, 16);
            }
            for (int i = 0; i < 16; i++)
            {
                for (int j = i + 1; j < 16; j++)
                {
                    if (a[i] == a[j])
                        a[j] = 0;
                }
            }
            int x = 0;
            for (int i = 1; i <= 16; i++)
            {
                int f = 0;
                for (int j = 0; j < 16; j++)
                {
                    if (i == a[j])
                        f = 1;
                }
                if (f != 1)
                {
                    b[x] = i;
                    x++;
                }
            }
            int x1 = 0;
            for (int i = 0; i < 16; i++)
            {
                if (a[i] == 0)
                {
                    a[i] = b[x1];
                    x1++;
                }
            }
            this.button1.Content = a[0].ToString();
            this.button2.Content = a[1].ToString();
            this.button3.Content = a[2].ToString();
            this.button4.Content = a[3].ToString();
            this.button5.Content = a[4].ToString();
            this.button6.Content = a[5].ToString();
            this.button7.Content = a[6].ToString();
            this.button8.Content = a[7].ToString();
            this.button9.Content = a[8].ToString();
            this.button10.Content = a[9].ToString();
            this.button11.Content = a[10].ToString();
            this.button12.Content = a[11].ToString();
            this.button13.Content = a[12].ToString();
            this.button14.Content = a[13].ToString();
            this.button15.Content = a[14].ToString();
            this.button16.Content = a[15].ToString();
           

            if (button1.Content.Equals("16"))
            {
                this.button1.Content = "";
                button1.Visibility = System.Windows.Visibility.Collapsed;

            }
            else if (this.button2.Content.Equals("16"))
            {
                this.button2.Content = "";
                button2.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (this.button3.Content.Equals("16"))
            {
                this.button3.Content = "";
                button3.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (this.button4.Content.Equals("16"))
            {
                this.button4.Content = "";
                button4.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (this.button5.Content.Equals("16"))
            {
                this.button5.Content = "";
                button5.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (this.button6.Content.Equals("16"))
            {
                this.button6.Content = "";
                button6.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (this.button7.Content.Equals("16"))
            {
                this.button7.Content = "";
                button7.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (this.button8.Content.Equals("16"))
            {
                this.button8.Content = "";
                button8.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (this.button9.Content.Equals("16"))
            {
                this.button9.Content.Equals("16");
                button9.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (this.button10.Content.Equals("16"))
            {
                this.button10.Content = "";
                button10.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (this.button11.Content.Equals("16"))
            {
                this.button11.Content = "";
                button11.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (this.button12.Content.Equals("16"))
            {
                this.button12.Content = "";
                button12.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (this.button13.Content.Equals("16"))
            {
                this.button13.Content = "";
                button13.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (this.button14.Content.Equals("16"))
            {
                this.button14.Content = "";
                button14.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (this.button15.Content.Equals("16"))
            {
                this.button15.Content = "";
                button15.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (this.button16.Content.Equals("16"))
            {
                this.button16.Content = "";
                button16.Visibility = System.Windows.Visibility.Collapsed;
            }

            this.label2.Text = c.ToString();
        }
        #endregion


        //PhoneApplicationService phoneAppService = PhoneApplicationService.Current;


        #region button1
        private void button1_Click(object sender, RoutedEventArgs e)
        {
           // phoneAppService.State["Myvalue"] = button1.Content;
            if (this.button2.Content.Equals(""))
            {
                this.button2.Content = this.button1.Content;
                this.button1.Visibility = 0;
                button2.Visibility = System.Windows.Visibility.Visible;
                button1.Visibility = System.Windows.Visibility.Collapsed;
                this.button1.Content = "";
                c++;
            }
            else if (this.button5.Content.Equals(""))
            {
                this.button5.Content = this.button1.Content;
                this.button1.Visibility = 0;
                button5.Visibility = System.Windows.Visibility.Visible;
                button1.Visibility = System.Windows.Visibility.Collapsed;
                this.button1.Content = "";
                c++;
            }

            this.label2.Text = c.ToString();

            //if (this.button1.Content.Equals(""))
            //    h[0] = 16;
            //else
            //    h[0] = Convert.ToInt32(this.button1.Content);
            // appStateSave();
            appStateSave();
            sort();
        }
        #endregion
        #region button2
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (this.button1.Content.Equals(""))
            {
                this.button1.Content = this.button2.Content;
                button1.Visibility = System.Windows.Visibility.Visible;
                button2.Visibility = System.Windows.Visibility.Collapsed;
                this.button2.Content = "";
                c++;
            }
            else if (this.button3.Content.Equals(""))
            {
                this.button3.Content = this.button2.Content;
                button3.Visibility = System.Windows.Visibility.Visible;
                button2.Visibility = System.Windows.Visibility.Collapsed;
                this.button2.Content = "";
                c++;
            }
            else if (this.button6.Content.Equals(""))
            {
                this.button6.Content = this.button2.Content;
                button6.Visibility = System.Windows.Visibility.Visible;
                button2.Visibility = System.Windows.Visibility.Collapsed;
                this.button2.Content = "";
                c++;
            }
            this.label2.Text = c.ToString();

            //if (this.button2.Content == "")
            //    h[1] = 16;
            //else
            //    h[1] = Convert.ToInt32(this.button2.Content);
            appStateSave();
            sort();

        }
        #endregion
        #region button3


        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (this.button2.Content.Equals(""))
            {
                this.button2.Content = this.button3.Content;
                button3.Visibility = System.Windows.Visibility.Collapsed;
                button2.Visibility = System.Windows.Visibility.Visible;
                this.button3.Content = "";
                c++;
            }
            else if (this.button4.Content.Equals(""))
            {
                this.button4.Content = this.button3.Content;
                button3.Visibility = System.Windows.Visibility.Collapsed;
                button4.Visibility = System.Windows.Visibility.Visible;
                this.button3.Content = "";
                c++;
            }
            else if (this.button7.Content.Equals(""))
            {
                this.button7.Content = this.button3.Content;
                button3.Visibility = System.Windows.Visibility.Collapsed;
                button7.Visibility = System.Windows.Visibility.Visible;
                this.button3.Content = "";
                c++;
            }
            this.label2.Text = c.ToString();
            //if (this.button3.Content.Equals(""))
            //    h[2] = 16;
            //else
            //    h[2] = Convert.ToInt32(this.button3.Content);
            appStateSave();
            sort();
        }
        #endregion
        #region button4

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (this.button3.Content.Equals(""))
            {
                this.button3.Content = this.button4.Content;
                button4.Visibility = System.Windows.Visibility.Collapsed;
                button3.Visibility = System.Windows.Visibility.Visible;
                this.button4.Content = "";
                c++;
            }
            else if (this.button8.Content.Equals(""))
            {
                this.button8.Content = this.button4.Content;
                button4.Visibility = System.Windows.Visibility.Collapsed;
                button8.Visibility = System.Windows.Visibility.Visible;
                this.button4.Content = "";
                c++;
            }
            this.label2.Text = c.ToString();

            //if (this.button4.Content.Equals(""))
            //    h[3] = 16;
            //else
            //    h[3] = Convert.ToInt32(this.button4.Content);
            appStateSave();
            sort();
        }
        #endregion
        #region button5
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (this.button1.Content.Equals(""))
            {
                this.button1.Content = this.button5.Content;
                button5.Visibility = System.Windows.Visibility.Collapsed;
                button1.Visibility = System.Windows.Visibility.Visible;
                this.button5.Content = "";
                c++;
            }
            else if (this.button6.Content.Equals(""))
            {
                this.button6.Content = this.button5.Content;
                button5.Visibility = System.Windows.Visibility.Collapsed;
                button6.Visibility = System.Windows.Visibility.Visible;
                this.button5.Content = "";
                c++;
            }
            else if (this.button9.Content.Equals(""))
            {
                this.button9.Content = this.button5.Content;
                button5.Visibility = System.Windows.Visibility.Collapsed;
                button9.Visibility = System.Windows.Visibility.Visible;
                this.button5.Content = "";
                c++;
            }
            this.label2.Text = c.ToString();

            //if (this.button5.Content.Equals(""))
            //    h[4] = 16;
            //else
            //    h[4] = Convert.ToInt32(this.button5.Content);
            appStateSave();
            sort();

        }

        #endregion
        #region button6
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (this.button2.Content.Equals(""))
            {
                this.button2.Content = this.button6.Content;
                button6.Visibility = System.Windows.Visibility.Collapsed;
                button2.Visibility = System.Windows.Visibility.Visible;
                this.button6.Content = "";
                c++;
            }
            else if (this.button5.Content.Equals(""))
            {
                this.button5.Content = this.button6.Content;
                button6.Visibility = System.Windows.Visibility.Collapsed;
                button5.Visibility = System.Windows.Visibility.Visible;
                this.button6.Content = "";
                c++;
            }
            else if (this.button7.Content.Equals(""))
            {
                this.button7.Content = this.button6.Content;
                button6.Visibility = System.Windows.Visibility.Collapsed;
                button7.Visibility = System.Windows.Visibility.Visible;
                this.button6.Content = "";
                c++;
            }
            else if (this.button10.Content.Equals(""))
            {
                this.button10.Content = this.button6.Content;
                button6.Visibility = System.Windows.Visibility.Collapsed;
                button10.Visibility = System.Windows.Visibility.Visible;
                this.button6.Content = "";
                c++;
            }
            this.label2.Text = c.ToString();

            //if (this.button6.Content.Equals(""))
            //    h[5] = 16;
            //else
            //    h[5] = Convert.ToInt32(this.button6.Content);
            appStateSave();
            sort();
        }
        #endregion
        #region button7

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (this.button3.Content.Equals(""))
            {
                this.button3.Content = this.button7.Content;
                button7.Visibility = System.Windows.Visibility.Collapsed;
                button3.Visibility = System.Windows.Visibility.Visible;
                this.button7.Content = "";
                c++;

            }
            else if (this.button6.Content.Equals(""))
            {
                this.button6.Content = this.button7.Content;
                button7.Visibility = System.Windows.Visibility.Collapsed;
                button6.Visibility = System.Windows.Visibility.Visible;
                this.button7.Content = "";
                c++;
            }
            else if (this.button8.Content.Equals(""))
            {
                this.button8.Content = this.button7.Content;
                button7.Visibility = System.Windows.Visibility.Collapsed;
                button8.Visibility = System.Windows.Visibility.Visible;
                this.button7.Content = "";
                c++;
            }
            else if (this.button11.Content.Equals(""))
            {
                this.button11.Content = this.button7.Content;
                button7.Visibility = System.Windows.Visibility.Collapsed;
                button11.Visibility = System.Windows.Visibility.Visible;
                this.button7.Content = "";
                c++;
            }
            this.label2.Text = c.ToString();
            //if (this.button7.Content.Equals(""))
            //    h[6] = 16;
            //else
            //    h[6] = Convert.ToInt32(this.button7.Content);
            appStateSave();
            sort();
        }

        #endregion
        #region button8
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (this.button4.Content.Equals(""))
            {
                this.button4.Content = this.button8.Content;
                button8.Visibility = System.Windows.Visibility.Collapsed;
                button4.Visibility = System.Windows.Visibility.Visible;
                this.button8.Content = "";
                c++;
            }
            else if (this.button7.Content.Equals(""))
            {
                this.button7.Content = this.button8.Content;
                button8.Visibility = System.Windows.Visibility.Collapsed;
                button7.Visibility = System.Windows.Visibility.Visible;
                this.button8.Content = "";
                c++;
            }
            else if (this.button12.Content.Equals(""))
            {
                this.button12.Content = this.button8.Content;
                button8.Visibility = System.Windows.Visibility.Collapsed;
                button12.Visibility = System.Windows.Visibility.Visible;
                this.button8.Content = "";
                c++;
            }
            this.label2.Text = c.ToString();

            //if (this.button8.Content.Equals(""))
            //    h[7] = 16;
            //else
            //    h[7] = Convert.ToInt32(this.button8.Content);
            appStateSave();
            sort();
        }
        #endregion
        #region button9
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (this.button5.Content.Equals(""))
            {
                this.button5.Content = this.button9.Content;
                button9.Visibility = System.Windows.Visibility.Collapsed;
                button5.Visibility = System.Windows.Visibility.Visible;
                this.button9.Content = "";
                c++;
            }
            else if (this.button10.Content.Equals(""))
            {
                this.button10.Content = this.button9.Content;
                button9.Visibility = System.Windows.Visibility.Collapsed;
                button10.Visibility = System.Windows.Visibility.Visible;
                this.button9.Content = "";
                c++;
            }
            else if (this.button13.Content.Equals(""))
            {
                this.button13.Content = this.button9.Content;
                button9.Visibility = System.Windows.Visibility.Collapsed;
                button13.Visibility = System.Windows.Visibility.Visible;
                this.button9.Content = "";
                c++;
            }

            this.label2.Text = c.ToString();
            //if (this.button9.Content.Equals(""))
            //    h[8] = 16;
            //else
            //    h[8] = Convert.ToInt32(this.button9.Content);
            appStateSave();
            sort();
        }
        #endregion
        #region button10
        private void button10_Click(object sender, RoutedEventArgs e)
        {
            if (this.button6.Content.Equals(""))
            {
                this.button6.Content = this.button10.Content;
                button10.Visibility = System.Windows.Visibility.Collapsed;
                button6.Visibility = System.Windows.Visibility.Visible;
                this.button10.Content = "";
                c++;
            }
            else if (this.button9.Content.Equals(""))
            {
                this.button9.Content = this.button10.Content;
                button10.Visibility = System.Windows.Visibility.Collapsed;
                button9.Visibility = System.Windows.Visibility.Visible;
                this.button10.Content = "";
                c++;
            }
            else if (this.button11.Content.Equals(""))
            {
                this.button11.Content = this.button10.Content;
                button10.Visibility = System.Windows.Visibility.Collapsed;
                button11.Visibility = System.Windows.Visibility.Visible;
                this.button10.Content = "";
                c++;
            }
            else if (this.button14.Content.Equals(""))
            {
                this.button14.Content = this.button10.Content;
                button10.Visibility = System.Windows.Visibility.Collapsed;
                button14.Visibility = System.Windows.Visibility.Visible;
                this.button10.Content = "";
                c++;
            }
            this.label2.Text = c.ToString();

            //if (this.button10.Content.Equals(""))
            //    h[9] = 16;
            //else
            //    h[9] = Convert.ToInt32(this.button10.Content);
            appStateSave();
            sort();
        }

        #endregion
        #region button11
        private void button11_Click(object sender, RoutedEventArgs e)
        {
            if (this.button7.Content.Equals(""))
            {
                this.button7.Content = this.button11.Content;
                button11.Visibility = System.Windows.Visibility.Collapsed;
                button7.Visibility = System.Windows.Visibility.Visible;
                this.button11.Content = "";
                c++;
            }
            else if (this.button10.Content.Equals(""))
            {
                this.button10.Content = this.button11.Content;
                button11.Visibility = System.Windows.Visibility.Collapsed;
                button10.Visibility = System.Windows.Visibility.Visible;
                this.button11.Content = "";
                c++;
            }
            else if (this.button12.Content.Equals(""))
            {
                this.button12.Content = this.button11.Content;
                button11.Visibility = System.Windows.Visibility.Collapsed;
                button12.Visibility = System.Windows.Visibility.Visible;
                this.button11.Content = "";
                c++;
            }
            else if (this.button15.Content.Equals(""))
            {
                this.button15.Content = this.button11.Content;
                button11.Visibility = System.Windows.Visibility.Collapsed;
                button15.Visibility = System.Windows.Visibility.Visible;
                this.button11.Content = "";
                c++;
            }
            this.label2.Text = c.ToString();

            //if (this.button10.Content.Equals(""))
            //    h[9] = 16;
            //else
            //    h[9] = Convert.ToInt32(this.button10.Content);
            appStateSave();
            sort();
        }
        #endregion
        #region button12
        private void button12_Click(object sender, RoutedEventArgs e)
        {
            if (this.button8.Content.Equals(""))
            {
                this.button8.Content = this.button12.Content;
                button12.Visibility = System.Windows.Visibility.Collapsed;
                button8.Visibility = System.Windows.Visibility.Visible;
                this.button12.Content = "";
                c++;
            }
            else if (this.button11.Content.Equals(""))
            {
                this.button11.Content = this.button12.Content;
                button12.Visibility = System.Windows.Visibility.Collapsed;
                button11.Visibility = System.Windows.Visibility.Visible;
                this.button12.Content = "";
                c++;
            }
            else if (this.button16.Content.Equals(""))
            {
                this.button16.Content = this.button12.Content;
                button12.Visibility = System.Windows.Visibility.Collapsed;
                button16.Visibility = System.Windows.Visibility.Visible;
                this.button12.Content = "";
                c++;
            }
            this.label2.Text = c.ToString();

            //if (this.button12.Content.Equals(""))
            //    h[11] = 16;
            //else
            //    h[11] = Convert.ToInt32(this.button12.Content);
            appStateSave();
            sort();
        }
        #endregion
        #region button13
        private void button13_Click(object sender, RoutedEventArgs e)
        {
            if (this.button9.Content.Equals(""))
            {
                this.button9.Content = this.button13.Content;
                button13.Visibility = System.Windows.Visibility.Collapsed;
                button9.Visibility = System.Windows.Visibility.Visible;
                this.button13.Content = "";
                c++;
            }
            else if (this.button14.Content.Equals(""))
            {
                this.button14.Content = this.button13.Content;
                button13.Visibility = System.Windows.Visibility.Collapsed;
                button14.Visibility = System.Windows.Visibility.Visible;
                this.button13.Content = "";
                c++;
            }

            this.label2.Text = c.ToString();

            //if (this.button13.Content.Equals(""))
            //    h[12] = 16;
            //else
            //    h[12] = Convert.ToInt32(this.button13.Content);

            appStateSave();
            sort();
        }
        #endregion
        #region button14
        private void button14_Click(object sender, RoutedEventArgs e)
        {
            if (this.button10.Content.Equals(""))
            {
                this.button10.Content = this.button14.Content;
                button10.Visibility = System.Windows.Visibility.Visible;
                button14.Visibility = System.Windows.Visibility.Collapsed;
                this.button14.Content = "";
                c++;
            }
            else if (this.button15.Content.Equals(""))
            {
                this.button15.Content = this.button14.Content;
                button15.Visibility = System.Windows.Visibility.Visible;
                button14.Visibility = System.Windows.Visibility.Collapsed;
                this.button14.Content = "";
                c++;
            }
            else if (this.button13.Content.Equals(""))
            {
                this.button13.Content = this.button14.Content;
                button13.Visibility = System.Windows.Visibility.Visible;
                button14.Visibility = System.Windows.Visibility.Collapsed;
                this.button14.Content = "";
                c++;
            }
            this.label2.Text = c.ToString();
            appStateSave();
            sort();
        }
        #endregion
        #region button15
        private void button15_Click(object sender, RoutedEventArgs e)
        {
            if (this.button11.Content.Equals(""))
            {
                this.button11.Content = this.button15.Content;
                button11.Visibility = System.Windows.Visibility.Visible;
                button15.Visibility = System.Windows.Visibility.Collapsed;
                this.button15.Content = "";
                c++;
            }
            else if (this.button16.Content.Equals(""))
            {
                this.button16.Content = this.button15.Content;
                button16.Visibility = System.Windows.Visibility.Visible;
                button15.Visibility = System.Windows.Visibility.Collapsed;
                this.button15.Content = "";
                c++;
            }
            else if (this.button14.Content.Equals(""))
            {
                this.button14.Content = this.button15.Content;
                button14.Visibility = System.Windows.Visibility.Visible;
                button15.Visibility = System.Windows.Visibility.Collapsed;
                this.button15.Content = "";
                c++;
            }
            this.label2.Text = c.ToString();


            //if (this.button15.Content.Equals(""))
            //   h[14] = 16;
            //else
            //  h[14] = Convert.ToInt32(this.button15.Content);
            appStateSave();
            sort();
        }
        #endregion
        #region button16
        private void button16_Click(object sender, RoutedEventArgs e)
        {
            if (this.button12.Content.Equals(""))
            {
                this.button12.Content = this.button16.Content;
                button16.Visibility = System.Windows.Visibility.Collapsed;
                button12.Visibility = System.Windows.Visibility.Visible;
                this.button16.Content = "";
                c++;
            }
            else if (this.button15.Content.Equals(""))
            {
                this.button15.Content = this.button16.Content;
                button16.Visibility = System.Windows.Visibility.Collapsed;
                button15.Visibility = System.Windows.Visibility.Visible;
                this.button16.Content = "";
                c++;
            }
            this.label2.Text = c.ToString();

            //if (this.button16.Content.Equals(""))
            //    h[15] = 16;
            //else
            //    h[15] = Convert.ToInt32(this.button16.Content);
            appStateSave();
            sort();
        }
        #endregion
        #region sort_function
        public void sort()
        {
            int e = 0;
            if (this.button1.Content.Equals("1"))
            {
                if (this.button2.Content.Equals("2"))
                {
                    if (this.button3.Content.Equals("3"))
                    {
                        if (this.button4.Content.Equals("4"))
                        {
                            if (this.button5.Content.Equals("5"))
                            {
                                if (this.button6.Content.Equals("6"))
                                {
                                    if (this.button7.Content.Equals("7"))
                                    {
                                        if (this.button8.Content.Equals("8"))
                                        {
                                            if (this.button9.Content.Equals("9"))
                                            {
                                                if (this.button10.Content.Equals("10"))
                                                {
                                                    if (this.button11.Content.Equals("11"))
                                                    {
                                                        if (this.button12.Content.Equals("12"))
                                                        {
                                                            if (this.button13.Content.Equals("13"))
                                                            {
                                                                if (this.button14.Content.Equals("14"))
                                                                {
                                                                    if (this.button15.Content.Equals("15"))
                                                                    {
                                                                        if (this.button16.Content.Equals(""))
                                                                        {
                                                                            e = 1;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (e == 1 )
            {
                //myDialog.GotFocus(1);
                youwon.Text = "Result \nCONGRATULATIONS!!!! You Won" + "\nNo. of Moves = " + c.ToString();
                label2.Visibility = System.Windows.Visibility.Collapsed;
                lable1.Visibility = System.Windows.Visibility.Collapsed;
                myDialog.Visibility = System.Windows.Visibility.Visible;
                //appstateremove();
                phoneAppService.State["myValue"] = "finish";

                this.NavigationService.RemoveBackEntry();
               
            }
            else if (c >=500 )
            {
                
                youwon.Text = "Result \nGame Over!!!!" + "\nYour moves are exceeding its maximum value";
                c = 0;
                label2.Visibility = System.Windows.Visibility.Collapsed;
                lable1.Visibility = System.Windows.Visibility.Collapsed;
                this.NavigationService.RemoveBackEntry();

                phoneAppService.State["myValue"] = "finish";
                myDialog.Visibility = System.Windows.Visibility.Visible;
            }
            return;


        }

        #endregion

        //private void Yes_Click(object sender, RoutedEventArgs e)
        //{
        //   // appstateremove();
        //    //phoneAppService.State.Remove("myValue");
        //    appstateremove();
           
        //    myDialog.Visibility = System.Windows.Visibility.Collapsed;

        //    NavigationService.Navigate(new Uri("/Flip-Me;component/Page1.xaml?id=3", UriKind.Relative));
            
        //}


        private void closeButton_Click(object sender, RoutedEventArgs e)
        {

            //phoneAppService.State.Remove("myValue");
            appstateremove();
            myDialog.Visibility = System.Windows.Visibility.Collapsed;
            //phoneAppService.State["myValue"] = null;
            //Dispatcher.BeginInvoke(NavigationService.Navigate(new Uri("/Flip-Me;component/MainPage.xaml", UriKind.Relative));
            this.NavigationService.RemoveBackEntry();
            phoneAppService.State["myValue"] = "finish";
            NavigationService.Navigate(new Uri("/Flip-Me;component/MainPage.xaml", UriKind.Relative));
            label2.Visibility = System.Windows.Visibility.Visible;

            lable1.Visibility = System.Windows.Visibility.Visible;
            //this.NavigationService.RemoveBackEntry();
            
        }

        private void appstateremove()
        {

            phoneAppService.State.Remove("myValue");
            phoneAppService.State.Remove("myValue1");
            phoneAppService.State.Remove("myValue2");
            phoneAppService.State.Remove("myValue3");
            phoneAppService.State.Remove("myValue4");
            phoneAppService.State.Remove("myValue5");
            phoneAppService.State.Remove("myValue6");
            phoneAppService.State.Remove("myValue7");
            phoneAppService.State.Remove("myValue8");
            phoneAppService.State.Remove("myValue9");
            phoneAppService.State.Remove("myValue10");
            phoneAppService.State.Remove("myValue11");
            phoneAppService.State.Remove("myValue12");
            phoneAppService.State.Remove("myValue13");
            phoneAppService.State.Remove("myValue14");
            phoneAppService.State.Remove("myValue15");
            phoneAppService.State.Remove("myValue16");
            phoneAppService.State.Remove("myValuec");
        }

        
    }
}