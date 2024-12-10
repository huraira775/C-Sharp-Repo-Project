using RepositoryFactoryAndMethodPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Repositories
{
    public interface IGenericRepository<T> where T:IEntityBase, new()
    {
        IEnumerable<T> Get();
        T Get(int id);
        void Insert(T entity);
        void InsertRange (IEnumerable<T> entities);
        void Update (T entity);
        void Delete (int id);
    }
}
