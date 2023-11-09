using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class UserDB : BaseDB
    {
        protected override BaseEntity NewEntity()
        {
            return new User();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            User user = entity as User;
            user.ID = int.Parse(reader["ID"].ToString());
            user.FirstName = reader["firstName"].ToString();
            user.LastName = reader["lastName"].ToString();
            user.Username = reader["username"].ToString();
            user.Password = reader["password"].ToString();
            user.Email = reader["email"].ToString();
            user.Birthday = DateTime.Parse(reader["bDay"].ToString());
            user.Gender = bool.Parse(reader["gender"].ToString());
            user.IsManager = bool.Parse(reader["isManager"].ToString());
            user.IsOperator = bool.Parse(reader["isOperator"].ToString());
            user.IsVolunteer = bool.Parse(reader["isVolunteer"].ToString());
            ActivityDB activityDB = new ActivityDB();
            user.Activities = activityDB.SelectByUser(user);
            CityDB cityDB = new CityDB();
            int cityID = int.Parse(reader["city"].ToString());
            user.City = cityDB.SelectById(cityID);
            return user;
        }


        public UserList SelectAll()
        {
            command.CommandText = "SELECT * FROM tblUser";
            UserList list = new UserList(ExecuteCommand());
            return list;
        }

        public User SelectById(int id)
        {
            command.CommandText = $"SELECT * FROM TblUsers WHERE (ID = {id})";
            UserList list = new UserList(base.ExecuteCommand());
            if (list.Count == 1)
                return list[0];
            return null;
        }
    }
}
