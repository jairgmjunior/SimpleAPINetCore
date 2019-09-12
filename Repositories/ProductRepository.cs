using Microsoft.AspNetCore.Mvc;
using APIS.Models;
using System.Collections.Generic;
using APIS.Data;

namespace APIS.Repositories
{
    public class ProductRepository
    {
        private readonly StoreDataContext _dataContext;
        public ProductRepository(StoreDataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public IEnumerable<Product> GetAll()
        {
            return _dataContext.Products;
        }

        public void Create(Product product)
        {
            _dataContext.Products.Add(product);
            _dataContext.SaveChanges();
        }
    }
}