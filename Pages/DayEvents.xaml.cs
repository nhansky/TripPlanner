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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TripPlanner.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DayEvents : Page
    {
        public DayEvents()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var day = (Days)e.Parameter;
            pageTitle.Text = day.DayNo;
        }
        private void hamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen;
        }

        private void menuItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void addNewActivities_Click(object sender, RoutedEventArgs e)
        {

            Frame.Navigate(typeof(NewActivities));
        }

        private void selectActivities_Click(object sender, RoutedEventArgs e)
        {
            addNewActivity.Visibility = Visibility.Collapsed;
            selectActivities.Visibility = Visibility.Collapsed;
            deleteActivities.Visibility = Visibility.Visible;
            editActivity.Visibility = Visibility.Visible;
            cancel.Visibility = Visibility.Visible;
        }

        private void deleteActivities_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            addNewActivity.Visibility = Visibility.Visible;
            selectActivities.Visibility = Visibility.Visible;
            deleteActivities.Visibility = Visibility.Collapsed;
            editActivity.Visibility = Visibility.Collapsed;
            cancel.Visibility = Visibility.Collapsed;
        }

        private void editActivity_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
