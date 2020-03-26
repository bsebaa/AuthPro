using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthPro.Models.Repositories
{
   public interface IProductRepository<TEntity>
    {
        public IEnumerable<TEntity> List();
        public TEntity FindById(int id);
        public IEnumerable<TEntity> Search(string term);
        public void Add(TEntity entity);
        public void Delete(TEntity entity);
        public void Update(TEntity entity);
     
    }
}
