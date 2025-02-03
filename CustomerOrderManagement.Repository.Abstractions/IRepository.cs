using System.Collections.Generic;

namespace CustomerOrderManagement.Repository.Abstractions
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Save();
    }
}
