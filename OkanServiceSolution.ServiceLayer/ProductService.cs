using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using OkanServiceSolution.DataLayer;
using OkanServiceSolution.BusinessLayer.Repository.Concrete;

namespace OkanServiceSolution.ServiceLayer
{
    public class ProductService : IProductService
    {
        ProductRepository repo = new ProductRepository();
        public Product GetProduct(int id)
        {
           return repo.Get(id);
        }

        public List<Product> GetProducts()
        {
            return repo.GetAll().ToList();
        }

        public void RemoveProduct(int id)
        {
            repo.Remove(id);
        }

        public void SaveProduct(Product item)
        {
            repo.Save(item);
        }
    }
}
