using OkanServiceSolution.BusinessLayer.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OkanServiceSolution.DataLayer;

namespace OkanServiceSolution.BusinessLayer.Repository.Concrete
{
    public class ProductRepository : IProductRepository
    {
        public Product Get(int id)
        {
            using (OkanDbEntities db = new OkanDbEntities())
            {
                return db.Products.FirstOrDefault(p => p.ProductId == id);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            using (OkanDbEntities db = new OkanDbEntities())
            {
                return db.Products.ToList();
            }
        }

        public void Remove(Product entity)
        {
            using (OkanDbEntities db = new OkanDbEntities())
            {
                db.Products.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Remove(int id)
        {
            using (OkanDbEntities db = new OkanDbEntities())
            {
                var entity = Get(id);
                db.Products.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();

            }
        }

        public void Save(Product entity)
        {
            using (OkanDbEntities db = new OkanDbEntities())
            {
                var prod = Get(entity.ProductId);
                if (prod == null)
                {
                    db.Products.Attach(entity);
                    db.Entry(entity).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                }
                else
                {
                    db.Products.Attach(entity);
                    db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }


            }
        }
    }
}
