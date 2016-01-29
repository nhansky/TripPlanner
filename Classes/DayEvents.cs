using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace TripPlanner.Classes
{
    public class DayEvents
    {
        [PrimaryKey, AutoIncrement]
        public int DayEventID { get; set; }
        public string Activities { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Locations { get; set; }
        public string Notes { get; set; }
        public Guid PlanID_FK { get; set; }
        public Guid DayID_FK { get; set; }

        public DayEvents() { }

        public DayEvents(Guid planId, Guid dayId, TimeSpan startTime, TimeSpan endTime, string activities, string location)
        {
            PlanID_FK = planId;
            DayID_FK = dayId;
            StartTime = startTime;
            EndTime = endTime;
            Activities = activities;
            Locations = location;
        }
    }
}
