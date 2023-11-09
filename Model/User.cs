using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User : BaseEntity
    {
        protected string firstName;
        protected string lastName;
        protected string username;
        protected string password;
        protected string email;
        protected DateTime bDay;
        protected bool gender;
        protected City city;
        protected bool isManager;
        protected bool isOperator;
        protected bool isVolunteer;
        protected ActivityList activities;
        public string FirstName { get { return firstName; } set { firstName = value; } }

        public string LastName { get { return lastName; } set { lastName = value; } }

        public string Username { get { return username; } set { username = value; } }

        public string Password { get { return password; } set { password = value; } }

        public string Email { get { return email; } set { email = value; } }

        public DateTime Birthday { get { return bDay; } set { bDay = value; } }

        public bool Gender { get { return gender; } set { gender = value; } }

        public City City { get { return city; } set { city = value; } }

        public bool IsManager { get { return isManager; } set { isManager = value; } }
        public bool IsOperator { get { return isOperator; } set { isOperator = value; } }
        public bool IsVolunteer { get { return isVolunteer; } set { isVolunteer = value; } }
        public ActivityList Activities { get { return activities; } set { activities = value; } }

    }

    public class UserList : List<User>
    {
        //בנאי ברירת מחדל - אוסף ריק
        public UserList() { }

        //המרה אוסף גנרי לרשימת משתמשים
        public UserList(IEnumerable<User> list)
            : base(list) { }

        //המרה מטיפוס בסיס לרשימת משתמשים
        public UserList(IEnumerable<BaseEntity> list)
            : base(list.Cast<User>().ToList()) { }

    }
}
