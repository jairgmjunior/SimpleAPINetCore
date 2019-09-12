using Microsoft.AspNetCore.Mvc;
using APIS.Models;
using System.Collections.Generic;
using APIS.Repositories;

namespace APIS.Controllers
{
    [Route("v1")] //Prefixo
    public class HomeController : Controller
    {
        private readonly ProductRepository _repository;
        public HomeController(ProductRepository repository)
        {
            this._repository = repository;
        }

        [Route("products")]
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var products = _repository.GetAll();

            return products;
        }

        [Route("products")]
        [HttpPost]
        public void Create(Product product){
            _repository.Create(product);
        }


    }
}