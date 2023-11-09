using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    internal class ActivityTypeDB : BaseDB
    {
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            ActivityType activityType = entity as ActivityType;
            activityType.ID = int.Parse(reader["ID"].ToString());
            activityType.Type = reader["Type"].ToString();
            return activityType;
        }

        protected override BaseEntity NewEntity()
        {
            return new ActivityType();
        }

        public ActivityTypeList SelectAll()
        {
            command.CommandText = "SELECT * FROM tblActivityType";
            ActivityTypeList list = new ActivityTypeList(ExecuteCommand());
            return list;
        }

        public ActivityType SelectById(int id)
        {
            command.CommandText = $"SELECT * FROM tblActivityType WHERE ID={id}";
            ActivityTypeList list = new ActivityTypeList(ExecuteCommand());
            if (list.Count == 0)
                return null;
            return list[0];
        }
    }
}
