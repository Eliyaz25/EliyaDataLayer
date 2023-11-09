using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ActivityType : BaseEntity
    {
        protected string type;
        public string Type{ get { return type; } set { type = value; } }
    }

    public class ActivityTypeList : List<ActivityType>
    {
        //בנאי ברירת מחדל - אוסף ריק
        public ActivityTypeList() { }

        //המרה אוסף גנרי לרשימת סוג פעילות
        public ActivityTypeList(IEnumerable<ActivityType> list)
            : base(list) { }

        //המרה מטיפוס בסיס לרשימת סוגי פעילות
        public ActivityTypeList(IEnumerable<BaseEntity> list)
            : base(list.Cast<ActivityType>().ToList()) { }

    }
}
