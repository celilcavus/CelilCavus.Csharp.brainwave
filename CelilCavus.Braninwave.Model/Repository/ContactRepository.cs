using CelilCavus.Braninwave.Entity.Entitys;
using CelilCavus.Braninwave.Model.Contexts;
using CelilCavus.Braninwave.Model.Interfaces;
using System.Collections.Generic;
using Dapper;
using CelilCavus.Braninwave.Model.enums;

namespace CelilCavus.Braninwave.Model.Repository
{
    public class ContactRepository : IRepository<Contact>
    {
        public void Add(Contact item)
        {
            AppContext.context.Execute($"INSERT INTO {TableName.contact} (Name, Email, PhoneNumber, Message) values ('{item.Name}','{item.Email}','{item.PhoneNumber}','{item.Message}')");
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Contact> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Contact GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Contact item)
        {
            throw new System.NotImplementedException();
        }
    }
}
