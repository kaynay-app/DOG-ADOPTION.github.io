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
using System.IO;
using Microsoft.Win32;
using static System.Console;

namespace Dog_Adoption
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /* Name: Kelem Nyarko
     * Project: WPF.NET C#
     * App Name: DOG ADOPTION 
     **/
    public partial class MainWindow : Window
    {

        public static string SetValueForName = "";
        /*public static string SetValueForBreed = "";
        public static string SetValueForDOB = "";
        public static string SetValueForGender = "";
        public static string SetValueForHaveShots = "";
        public static string SetValueForColor = ""; */


        string str;
        public MainWindow()
        {
            InitializeComponent();

        }



        private void btnJames_Click(object sender, RoutedEventArgs e)
        {
            imgJames.Visibility = Visibility.Visible;
            imgJane.Visibility = Visibility.Hidden;
            imgScooby.Visibility = Visibility.Hidden;
            imgMax.Visibility = Visibility.Hidden;
            imgTerry.Visibility = Visibility.Hidden;
            imgMike.Visibility = Visibility.Hidden;
            btnOrderJames.Visibility = Visibility.Visible;

            lblDogName.Visibility = Visibility.Visible;
            int line = 3; 
            try
            {
                using (var sr = new StreamReader("Dog Adoption.txt")) 
                {
                    for (int i=1; i<= line; i++)
                    {
                        str = sr.ReadLine();
                    }

                    string [] dogAbout = str.Split(",");
                    lblDogName.Content = dogAbout[0];
                    lblBreed.Content = dogAbout[1];
                    lblWeight.Content = dogAbout[2];
                    lblDOB.Content = dogAbout[3];
                    lblGender.Content = dogAbout[5];
                    lblShots.Content = dogAbout[6];
                    lblColor.Content = dogAbout[7];
                    
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    

        private void btnMike_Click(object sender, RoutedEventArgs e)
        {
            imgMike.Visibility = Visibility.Visible;
            imgJames.Visibility = Visibility.Hidden;
            imgJane.Visibility = Visibility.Hidden;
            imgScooby.Visibility = Visibility.Hidden;
            imgMax.Visibility = Visibility.Hidden;
            imgTerry.Visibility = Visibility.Hidden;

            int line = 4;
            try
            {
                using (var sr = new StreamReader("Dog Adoption.txt"))
                {
                    for (int i = 1; i <= line; i++)
                    {
                        str = sr.ReadLine();
                    }

                    string[] dogAbout = str.Split(",");
                    lblDogName.Content = dogAbout[0];
                    lblBreed.Content = dogAbout[1];
                    lblWeight.Content = dogAbout[2];
                    lblDOB.Content = dogAbout[3];
                    lblGender.Content = dogAbout[5];
                    lblShots.Content = dogAbout[6];
                    lblColor.Content = dogAbout[7];

                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnTerry_Click(object sender, RoutedEventArgs e)
        {
            imgTerry.Visibility = Visibility.Visible;
            imgJames.Visibility = Visibility.Hidden;
            imgMike.Visibility= Visibility.Hidden;
            imgJane.Visibility = Visibility.Hidden;
            imgScooby.Visibility = Visibility.Hidden;
            imgMax.Visibility = Visibility.Hidden;

            int line = 5;
            try
            {
                using (var sr = new StreamReader("Dog Adoption.txt"))
                {
                    for (int i = 1; i <= line; i++)
                    {
                        str = sr.ReadLine();
                    }

                    string[] dogAbout = str.Split(",");
                    lblDogName.Content = dogAbout[0];
                    lblBreed.Content = dogAbout[1];
                    lblWeight.Content = dogAbout[2];
                    lblDOB.Content = dogAbout[3];
                    lblGender.Content = dogAbout[5];
                    lblShots.Content = dogAbout[6];
                    lblColor.Content = dogAbout[7];

                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMax_Click(object sender, RoutedEventArgs e)
        {
            imgMax.Visibility = Visibility.Visible;
            imgTerry.Visibility = Visibility.Hidden;
            imgMike.Visibility = Visibility.Hidden;
            imgJane.Visibility = Visibility.Hidden;
            imgScooby.Visibility = Visibility.Hidden;
            imgJames.Visibility = Visibility.Hidden;

            int line = 6;
            try
            {
                using (var sr = new StreamReader("Dog Adoption.txt"))
                {
                    for (int i = 1; i <= line; i++)
                    {
                        str = sr.ReadLine();
                    }

                    string[] dogAbout = str.Split(",");
                    lblDogName.Content = dogAbout[0];
                    lblBreed.Content = dogAbout[1];
                    lblWeight.Content = dogAbout[2];
                    lblDOB.Content = dogAbout[3];
                    lblGender.Content = dogAbout[5];
                    lblShots.Content = dogAbout[6];
                    lblColor.Content = dogAbout[7];

                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnScooby_Click(object sender, RoutedEventArgs e)
        {
            imgScooby.Visibility = Visibility.Visible;
            imgMax.Visibility = Visibility.Hidden;
            imgTerry.Visibility = Visibility.Hidden;
            imgJames.Visibility = Visibility.Hidden;
            imgMike.Visibility = Visibility.Hidden;
            imgJane.Visibility = Visibility.Hidden;

            int line = 7;
            try
            {
                using (var sr = new StreamReader("Dog Adoption.txt"))
                {
                    for (int i = 1; i <= line; i++)
                    {
                        str = sr.ReadLine();
                    }

                    string[] dogAbout = str.Split(",");
                    lblDogName.Content = dogAbout[0];
                    lblBreed.Content = dogAbout[1];
                    lblWeight.Content = dogAbout[2];
                    lblDOB.Content = dogAbout[3];
                    lblGender.Content = dogAbout[5];
                    lblShots.Content = dogAbout[6];
                    lblColor.Content = dogAbout[7];

                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJane_Click(object sender, RoutedEventArgs e)
        {
            imgJane.Visibility = Visibility.Visible;
            imgScooby.Visibility = Visibility.Hidden;
            imgMax.Visibility = Visibility.Hidden;
            imgTerry.Visibility = Visibility.Hidden;
            imgJames.Visibility = Visibility.Hidden;
            imgMike.Visibility = Visibility.Hidden;


            int line = 8;
            try
            {
                using (var sr = new StreamReader("Dog Adoption.txt"))
                {
                    for (int i = 1; i <= line; i++)
                    {
                        str = sr.ReadLine();
                    }

                    string[] dogAbout = str.Split(",");
                    lblDogName.Content = dogAbout[0];
                    lblBreed.Content = dogAbout[1];
                    lblWeight.Content = dogAbout[2];
                    lblDOB.Content = dogAbout[3];
                    lblGender.Content = dogAbout[5];
                    lblShots.Content = dogAbout[6];
                    lblColor.Content = dogAbout[7];

                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lblDogName.Content = "";
            lblBreed.Content = "";
            lblWeight.Content = "";
            lblDOB.Content = "";
            lblGender.Content = "";
            lblShots.Content = "";
            lblColor.Content = "";

            imgJane.Visibility = Visibility.Hidden;
            imgScooby.Visibility = Visibility.Hidden;
            imgMax.Visibility = Visibility.Hidden;
            imgTerry.Visibility = Visibility.Hidden;
            imgJames.Visibility = Visibility.Hidden;
            imgMike.Visibility = Visibility.Hidden;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnOrderJames_Click(object sender, RoutedEventArgs e)
        {
            Verification_Window win2 = new Verification_Window(this);
            this.Visibility = Visibility.Hidden;
            win2.ShowDialog();
            this.Visibility = Visibility.Visible;

            SetValueForName = btnJames.Content.ToString();   //lblDogName.Content.ToString();
   
        }
    }
}
