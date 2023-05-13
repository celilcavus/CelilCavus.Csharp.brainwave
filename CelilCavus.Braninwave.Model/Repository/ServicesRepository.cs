using CelilCavus.Braninwave.Entity.Entitys;
using CelilCavus.Braninwave.Model.Contexts;
using CelilCavus.Braninwave.Model.enums;
using CelilCavus.Braninwave.Model.Interfaces;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace CelilCavus.Braninwave.Model.Repository
{
    public class ServicesRepository : IRepository<Services>
    {
        public void Add(Services item)
        {
            AppContext.context.Execute($"INSERT INTO {TableName.services} (Title, Description) values ('{item.Title}','{item.Description}')");
        }

        public void Delete(int id)
        {
            AppContext.context.Execute($"DELETE FROM {TableName.services} where Id = {id}");
        }

        public List<Services> GetAll()
        {
            return AppContext.context.Query<Services>($"SELECT * FROM {TableName.services}").ToList();
        }

        public Services GetById(int id)
        {
            return AppContext.context.Query<Services>($"SELECT * FROM {TableName.services}").FirstOrDefault();
        }

        public void Update(Services item)
        {
            AppContext.context.Execute($"UPDATE {TableName.services} SET Title = '{item.Title}', Description = '{item.Description}' WHERE Id = {item.Id}");
        }
    }
}
