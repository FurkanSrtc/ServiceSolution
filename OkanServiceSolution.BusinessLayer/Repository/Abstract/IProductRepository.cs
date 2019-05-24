using OkanServiceSolution.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkanServiceSolution.BusinessLayer.Repository.Abstract
{
    public interface IProductRepository : IDatabaseRepository<Product>
    {
    }
}
