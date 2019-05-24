using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkanServiceSolution.BusinessLayer.Repository.Abstract
{
    public interface IDatabaseRepository<T> where T : class
    {
        void Save(T entity);
        void Remove(int id);
        void Remove(T entity);
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}
