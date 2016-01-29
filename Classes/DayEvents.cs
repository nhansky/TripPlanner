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
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Locations { get; set; }
        public string Notes { get; set; }
        public Guid PlanID_FK { get; set; }

        public DayEvents() { }
    }
}
