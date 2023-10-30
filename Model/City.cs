using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class City : BaseEntity
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        
    }

    public class CityList : List<City>
    {
        //בנאי ברירת מחדל - אוסף ריק
        public CityList() { }

        //המרה אוסף גנרי לרשימת ערים
        public CityList(IEnumerable<City> list)
            : base(list) { }

        //המרה מטיפוס בסיס לרשימת ערים
        public CityList(IEnumerable<BaseEntity> list)
            : base(list.Cast<City>().ToList()) { }
    }
}
