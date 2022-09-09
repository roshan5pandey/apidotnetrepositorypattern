using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Models.Repo
{
    public interface IDataRepository<TEntity>
    {
        public IEnumerable<TEntity> GetAllEmployee();
        public TEntity GetEmployee(int id);

        void Add(TEntity entity);
        void Update(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);




    }
}
