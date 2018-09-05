using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Capstone7ProdAPI.Controllers;
using Capstone7ProdAPI.Models;

namespace Capstone7ProdAPI.Controllers
{
    public class ProductController : ApiController
    {
        public List<Product> GetAllProducts()
        {
            //URL
            //ORM
            northwindEntities ORM = new northwindEntities();

            List<Product> listOfProducts = ORM.Products.ToList();

            return listOfProducts;
        }
    }
}