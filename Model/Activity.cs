using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Activity : BaseEntity
    {
        protected string activityName;
        protected string managerName;
        protected string operatorName;
        protected int numVolunnteers;
        protected City city;
        protected string location;
        protected DateTime startTime;
        protected DateTime endTime;
        protected ActivityType type;

        public string ActivityName { get { return activityName; } set { activityName = value; } }
        public string ManagerName { get { return managerName; } set { managerName = value; } }
        public string OperatorName { get { return operatorName; } set { operatorName = value; } }
        public int NumVolunnteers { get { return numVolunnteers; } set { numVolunnteers = value; } }
        public City City { get { return city; } set { city = value; } }
        public string Location { get { return location; } set { location = value; } }
        public DateTime StartTime { get { return startTime; } set { startTime = value; } }
        public DateTime EndTime { get { return endTime; } set { endTime = value; } }
        public ActivityType Type { get { return type; } set { type = value; } }

    }

    public class ActivityList : List<Activity>
    {
        //בנאי ברירת מחדל - אוסף ריק
        public ActivityList() { }

        //המרה אוסף גנרי לרשימת פעילויות
        public ActivityList(IEnumerable<Activity> list)
            : base(list) { }

        //המרה מטיפוס בסיס לרשימת פעילויות
        public ActivityList(IEnumerable<BaseEntity> list)
            : base(list.Cast<Activity>().ToList()) { }

    }
}
