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
using TripPlanner.Data;
using TripPlanner.Pages;
using TripPlanner.Classes;
using System.Collections.ObjectModel;
using System.Diagnostics;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TripPlanner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private SQLite.Net.TableQuery<Plans> PlanList;
        //private ObservableCollection<Plans> PlanList;
        public MainPage()
        {
            this.InitializeComponent();
            Sqlite data = new Sqlite();

            PlanList = data.conn.Table<Plans>();
        }

        private void hamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen;
        }

        private void menuItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Home.IsSelected)
                    Frame.Navigate(typeof(MainPage));
             else
                Frame.Navigate(typeof(MainPage));
        }

        private void addNewPlan_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddNewPlan));
        }

        private void deletePlan_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void selectPlan_Click(object sender, RoutedEventArgs e)
        {
            addNewPlan.Visibility = Visibility.Collapsed;
            selectPlan.Visibility = Visibility.Collapsed;
            editPlan.Visibility = Visibility.Visible;
            deletePlan.Visibility = Visibility.Visible;
            cancelPlan.Visibility = Visibility.Visible;

        }

        private void cancelPlan_Click(object sender, RoutedEventArgs e)
        {
            addNewPlan.Visibility = Visibility.Visible;
            selectPlan.Visibility = Visibility.Visible;
            editPlan.Visibility = Visibility.Collapsed;
            deletePlan.Visibility = Visibility.Collapsed;
            cancelPlan.Visibility = Visibility.Collapsed;
        }
    }
}
