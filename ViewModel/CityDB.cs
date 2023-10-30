using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class CityDB : BaseDB
    {
        protected override BaseEntity NewEntity()
        {
            return new City();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            City city = entity as City;
            city.ID = int.Parse(reader["ID"].ToString());
            city.Name = reader["cityName"].ToString();
            return city;
        }


        public CityList SelectAll()
        {
            command.CommandText = "SELECT * FROM tblCity";
            CityList list = new CityList(ExecuteCommand());
            return list;
        }

        public City SelectById(int id)
        {
            command.CommandText = "SELECT * FROM tblCity WHERE ID=" + id;
            CityList list = new CityList(ExecuteCommand());
            if (list.Count == 0)
                return null;
            return list[0];
        }


    }
}
