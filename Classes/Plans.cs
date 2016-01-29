using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripPlanner.Pages;

namespace TripPlanner.Classes
{
    public class Plans
    {
        [PrimaryKey]
        public Guid PlanID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Location { get; set; }
        public double Budget { get; set; }
        public int MaxDay { get; set; }

        public Plans()
        {
        }
        public Plans(DateTime startDate, DateTime endDate, string location, double budget)
        {
            PlanID = Guid.NewGuid();
            CreatedDate = DateTime.Now;
            StartDate = startDate;
            EndDate = endDate;
            Location = location;
            Budget = budget;
            MaxDay = CalculateMaxDay(StartDate, EndDate);
        }

        public void SetPlanDetails(DateTime startDate, DateTime endDate, string location, double budget)
        {
            StartDate = startDate;
            EndDate = endDate;
            Location = location;
            Budget = budget;
            MaxDay = CalculateMaxDay(startDate, endDate);
        }

        public int CalculateMaxDay(DateTime startDate, DateTime endDate)
        {
            int maxDay = 0;
            if (startDate.Date > endDate.Date)
            {
                maxDay = 0;
            }
            else if(startDate.Date == endDate.Date)
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
