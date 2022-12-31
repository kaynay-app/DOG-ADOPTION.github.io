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
using System.Windows.Shapes;

namespace Dog_Adoption
{
    /// <summary>
    /// Interaction logic for Verification_Window.xaml
    /// </summary>
    public partial class Verification_Window : Window
    {
        MainWindow _MainWindow;
        public Verification_Window(MainWindow MainWindow1)
        {
            InitializeComponent();
            this._MainWindow = MainWindow1;
        }

        private void VerMain_Loaded(object sender, RoutedEventArgs e)
        {
            lblDogName1.Content =  _MainWindow.lblDogName.Content;
            lblBreed.Content = _MainWindow.lblBreed.Content;
            lblWeight.Content = _MainWindow.lblWeight.Content;
            lblDOB.Content = _MainWindow.lblDOB.Content;
            lblGender.Content = _MainWindow.lblGender.Content;
            lblShots.Content = _MainWindow.lblShots.Content;
            lblColor.Content = _MainWindow.lblColor.Content;
            //lblDogName1.Content = MainWindow.SetValueForName;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            this.Visibility = Visibility.Hidden;
            win1.ShowDialog();
            this.Visibility = Visibility.Hidden;
        }

        private void btnConfirm_Order_Click(object sender, RoutedEventArgs e)
        {

            lblDogName1.Content = _MainWindow.lblDogName.Content;
            lblBreed.Content = _MainWindow.lblBreed.Content;
            lblWeight.Content = _MainWindow.lblWeight.Content;
            lblDOB.Content = _MainWindow.lblDOB.Content;
            lblGender.Content = _MainWindow.lblGender.Content;
            lblShots.Content = _MainWindow.lblShots.Content;
            lblColor.Content = _MainWindow.lblColor.Content;
            //Label lbl = (Label)sender;
            //display the name of button and text in it
            MessageBox.Show($"You have odered: \n {lblDogName1.Content} with: \n Breed - {lblBreed.Content}" +
                $" \n Weight - {lblWeight.Content} \n DOB-{lblDOB.Content} \n Gender - {lblGender.Content}" +
                $"\n Have-Shots - {lblShots.Content} \n Color - {lblColor.Content} " +
                $"\n Click Ok to Confirm?");
        }
    }
}
