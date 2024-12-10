using RepositoryFactoryAndMethodPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Utils
{
    public static class EntityExtensions
    {
        public static string GetDetails (this IEntityBase entity)
        {
            return entity.ToString ();
        }
    }
}
