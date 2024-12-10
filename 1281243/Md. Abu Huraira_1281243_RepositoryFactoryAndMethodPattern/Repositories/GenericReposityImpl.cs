using RepositoryFactoryAndMethodPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Repositories
{
    public class GenericReposityImpl<T> : IGenericRepository<T> where T : IEntityBase, new()
    {
        private List<T> desktopList = new List<T>();
        public IEnumerable<T> Get()
        {
            return desktopList;
        }

        public T Get(int id)
        {
            return desktopList.First(x => x.Id == id);
        }
        public void Insert(T entity)
        {
            desktopList.Add(entity);
        }

        public void InsertRange(IEnumerable<T> entities)
        {
            desktopList.AddRange(entities);
        }

        public void Update(T entity)
        {
            int index = desktopList.FindIndex(x=> x.Id == entity.Id);
            desktopList.RemoveAt(index);
            desktopList.Insert(index, entity);
        }
        public void Delete(int id)
        {
            var desktop = desktopList.FirstOrDefault(x=>x.Id == id);
            if (desktop != null)
                desktopList.Remove(desktop);
        }

        
    }
}
