using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using TripPlanner.Classes;
using TripPlanner.Data;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TripPlanner.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddNewPlan : Page
    {
        public AddNewPlan()
        {
            this.InitializeComponent();
        }

        private void hamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen;
        }

        private void menuItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void addNewPlan_Click(object sender, RoutedEventArgs e)
        {
            bool validationLocationClear = true;
            bool validationDateClear = true;
            //check location not blank
            if (String.IsNullOrEmpty(planLocation.Text))
            {
                Flyout myFlyout = Resources["validationFlyout"] as Flyout;
                myFlyout.ShowAt(planLocation);
                if(validationLocationClear == true)
                {
                    validationLocationClear = false;
                }
            }
            else
            {
                validationLocationClear = true;
            }
            //Check End Date > Start Date
            if(planStartDate.Date.DateTime.Date > planEndDate.Date.DateTime.Date)
            {
                Flyout dateValidationFlyout = Resources["endDateValidation"] as Flyout;
                dateValidationFlyout.ShowAt(planStartDate);
                if(validationDateClear == true)
                {
                    validationDateClear = false;
                }
            }
            else
            {
                validationDateClear = true;
            }

            if(validationLocationClear == true & validationDateClear ==true)
            {
                if (String.IsNullOrEmpty(planBudget.Text))
                {
                    planBudget.Text = "0";
                }
                
                Plans plan = new Plans(planStartDate.Date.DateTime, planStartDate.Date.DateTime,
                    planLocation.Text, Convert.ToDouble(planBudget.Text));

                Sqlite sqlData = new Sqlite();
                sqlData.conn.Insert(plan);
                //plan.SetPlanDetails(planStartDate.Date.DateTime, planEndDate.Date.DateTime, planLocation.Text, Convert.ToDouble(planBudget.Text));
                Frame.Navigate(typeof(PlanDetails), plan);
            }
        }

        private void cancalNewPlan_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
            //else
            //{
            //    Frame.Navigate(typeof(MainPage));
            //}
        }
    }
}
