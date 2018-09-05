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
    public class Products
    {
        public int ProductID {set; get;}
        public string ProductName {set; get;}
    }
    public class ProductController : ApiController
    {
        public List<Product> GetAllProducts()
        {
            //URL...... /api/Product/GetAllProducts
            //ORM
            northwindEntities ORM = new northwindEntities();

            List<Product> listOfProducts = ORM.Products.ToList();

            return listOfProducts;
        }

        [HttpGet]
        public List<Product> GetProductInfo(int ProductID)
        {
            //URL....
            //ORM
            northwindEntities ORM = new northwindEntities();

            List<Product> listOfProducts = ORM.Products.Select(x => new Product
            { ProductID = x.ProductID, ProductName = x.ProductName }).ToList();
 
            return listOfProducts;
        }
    }
}