using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthPro.Models.Repositories
{
    public class ProductRepository : IProductRepository<Product>
    {
        private ApplicationDbContext db;
        public ProductRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
        public void Add(Product entity)
        {
            db.Products.Add(entity);
            db.SaveChanges();
        }

        public void Delete(Product entity)
        {
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();

        }

        public Product FindById(int id)
        {
            var data = db.Products.Find(id);
            return data;
        }

        public IEnumerable<Product> List()
        {
            return db.Products.ToList();
        }

        public IEnumerable<Product> Search(string term)
        {
            var data = db.Products.Where(pro => pro.Name.Contains(term)).ToList();
            return data;
        }

        public void Update(Product entity)
        {
            db.Products.Update(entity);
            db.SaveChanges();
        }
    }
}
