using CelilCavus.Braninwave.Entity.Entitys;
using CelilCavus.Braninwave.Model.Interfaces;
using System.Collections.Generic;
using Dapper;
using CelilCavus.Braninwave.Model.Contexts;
using CelilCavus.Braninwave.Model.enums;
using System.Linq;

namespace CelilCavus.Braninwave.Model.Repository
{
    public class AboutRepository : IRepository<About>
    {
        
        public void Add(About item)
        {
            AppContext.context.Execute($"INSERT INTO {TableName.about} (Title, Description) values ('{item.Title}','{item.Description}')");
        }

        public void Delete(int id)
        {
            AppContext.context.Execute($"DELETE FROM {TableName.about} where Id = {id}");
        }

        public List<About> GetAll()
        {
            return AppContext.context.Query<About>($"SELECT * FROM {TableName.about}").ToList();
        }

        public About GetById(int id)
        {
            return AppContext.context.Query<About>($"SELECT * FROM {TableName.about}").FirstOrDefault();
        }

        public void Update(About item)
        {
            AppContext.context.Execute($"UPDATE {TableName.about} SET Title = '{item.Title}', Description = '{item.Description}' WHERE Id = {item.Id}");
        }
    }
}
