using OkanServiceSolution.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OkanServiceSolution.ServiceLayer
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        List<Product> GetProducts();
        [OperationContract]
        void SaveProduct(Product item);
        [OperationContract]
        Product GetProduct(int id);
        [OperationContract]
        void RemoveProduct(int id);
    }
}
