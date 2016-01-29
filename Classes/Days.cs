using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using SQLite.Net;
using System.Diagnostics;
using TripPlanner.Data;

namespace TripPlanner.Classes
{
    public class Days
    {
        [PrimaryKey]
        public Guid DayID { get; set; }
        public string NumberOfEvents { get; set; }
        public string DayNo { get; set; }
        public Guid PlanID_FK { get; set; }
        
        public Days(Guid planId, string numberofevents, string dayno)
        {
            PlanID_FK = planId;
            DayID = Guid.NewGuid();

            NumberOfEvents = numberofevents;
            DayNo = dayno;
            Debug.WriteLine("Days constructor, dayId: " + DayID);
        }

        public Days(string numberofevents, string dayno)
        {
            DayID = Guid.NewGuid();

            NumberOfEvents = numberofevents;
            DayNo = dayno;
            Debug.WriteLine("Days constructor, dayId: " + DayID);
        }
        public Days()
        {

        }
    }

    public class DayList
    {
        //public static ObservableCollection<Days> getDayList(DateTime startDate, DateTime endDate)
        //{
        //    var dayList = new ObservableCollection<Days>();

        //    //int maxDay = CalculateMaxDay(startDate, endDate);
        //    //for (int i = 1; i <= maxDay; i++)
        //    //{
        //    //dayList.Add(new Days("No Activities on this day!", "Day " +i.ToString()));
        //    //}

        //    return dayList;

        //}

        public static TableQuery<Days> getDayList(Plans p)
        {

            Sqlite sqlData = new Sqlite();

            var queryDay = from d in sqlData.conn.Table<Days>()
                           where d.PlanID_FK.Equals(p.PlanID)
                           select d;
            //int maxDay = CalculateMaxDay(startDate, endDate);
            //for (int i = 1; i <= maxDay; i++)
            //{
            //dayList.Add(new Days("No Activities on this day!", "Day " +i.ToString()));
            //}

            return queryDay;


        }
        public static int CalculateMaxDay(DateTime startDate, DateTime endDate)
        {
            int maxDay = 0;
            if (startDate.Date > endDate.Date)
            {
                maxDay = 0;
            }
            else if (startDate.Date == endDate.Date)
            {
                maxDay = 1;
            }
            else {
                TimeSpan timeSpan = endDate.Date - startDate.Date;
                maxDay = timeSpan.Days + 1;
            }
            return maxDay;
        }
    }
}