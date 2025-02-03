using System.Collections.Generic;

namespace CustomerOrderManagement.Services.Abstractions
{
    public interface IService<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
    }
}
