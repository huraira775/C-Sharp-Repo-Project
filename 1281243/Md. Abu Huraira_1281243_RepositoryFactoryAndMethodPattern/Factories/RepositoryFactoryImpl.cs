using RepositoryFactoryAndMethodPattern.Models;
using RepositoryFactoryAndMethodPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Factories
{
    public class RepositoryFactoryImpl : IRepositoryFactory
    {
        public IGenericRepository<T> GetRepo<T>() where T : IEntityBase, new()
        {
            return new GenericReposityImpl<T>();
        }
    }
}
