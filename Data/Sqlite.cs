using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SQLite.Net;
using TripPlanner.Pages;
using TripPlanner.Classes;
using System.Diagnostics;

namespace TripPlanner.Data
{
    public class Sqlite
    {
        public string path;
        public SQLiteConnection conn;

        public Sqlite()
        {
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "TripPlanner.sqlite");
            conn = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.CreateTable<Plans>();
            conn.CreateTable<TripPlanner.Classes.DayEvents>();
            conn.CreateTable<Days>();
            Debug.WriteLine(path);
        }
    }
}
