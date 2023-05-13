using CelilCavus.Braninwave.Entity.Entitys;
using CelilCavus.Braninwave.Model.Interfaces;
using System.Collections.Generic;
using Dapper;
using CelilCavus.Braninwave.Model.Contexts;
using CelilCavus.Braninwave.Model.enums;
using System.Linq;

namespace CelilCavus.Braninwave.Model.Repository
{
    public class PortfolioRepository : IRepository<Portfolio>
    {

        public void Add(Portfolio item)
        {
            AppContext.context.Execute($"INSERT INTO {TableName.portfolio} (Title, Description) values ('{item.Title}','{item.Description}')");
        }

        public void Delete(int id)
        {
            AppContext.context.Execute($"DELETE FROM {TableName.portfolio} where Id = {id}");
        }

        public List<Portfolio> GetAll()
        {
            return AppContext.context.Query<Portfolio>($"SELECT * FROM {TableName.portfolio}").ToList();
        }

        public Portfolio GetById(int id)
        {
            return AppContext.context.Query<Portfolio>($"SELECT * FROM {TableName.portfolio}").FirstOrDefault();
        }

        public void Update(Portfolio item)
        {
            AppContext.context.Execute($"UPDATE {TableName.portfolio} SET Title = '{item.Title}', Description = '{item.Description}' WHERE Id = {item.Id}");
        }
    }
}
