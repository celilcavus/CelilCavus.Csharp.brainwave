using System.Collections.Generic;

namespace CelilCavus.Braninwave.Model.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        void Update(T item);
        void Delete(int id);

        List<T> GetAll();

        T GetById(int id);
    }
}
