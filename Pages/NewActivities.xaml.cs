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
    public sealed partial class NewActivities : Page
    {
        private Guid _dayId;
        private Guid _planId;
        public NewActivities()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var day = (Days)e.Parameter;
            _dayId = day.DayID;
            _planId = day.PlanID_FK;
        }

        private void hamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen;
        }

        private void menuItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void addNewActivity_Click(object sender, RoutedEventArgs e)
        {
            string actTextContent;
            activityContent.Document.GetText(Windows.UI.Text.TextGetOptions.UseObjectText, out actTextContent);

            TripPlanner.Classes.DayEvents activity = new TripPlanner.Classes.DayEvents(_planId, _dayId, activityStartTime.Time, activityEndTime.Time,
               actTextContent, activityLocation.Text);

            Sqlite sqlData = new Sqlite();
            sqlData.conn.Insert(activity);
        }


        private void cancelNewActivity_Click(object sender, RoutedEventArgs e)
        {
            //temporary back to home
            Frame.Navigate(typeof(MainPage));
            
        }
    }
}
