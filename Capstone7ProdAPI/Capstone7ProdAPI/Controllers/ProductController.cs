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
    //created new Class "Products"
    public class Products
    {
        public int ProductID {set; get;}
        public string ProductName {set; get;}
    }
    //return all products
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

        //return product by ID input
        [HttpGet]
        public List<Product> GetProductByID(int ProductID)
        {
            //URL..../api/Product/GetProductByID?ProductID=7
            //ORM
            northwindEntities ORM = new northwindEntities();

            // filter Products by ID
            List<Product> listByProdID = ORM.Products.Where(x => x.ProductID == ProductID).ToList();

            return listByProdID;
        }
        
        //return product info by ID and name
        [HttpGet]
        public List<Product> GetProductByNameID(int ProductID, string ProductName)
        {
            //URL....
            //ORM
            northwindEntities ORM = new northwindEntities();

            List<Product> prodList = ORM.Products.ToList();

            return ORM.Products.Where(x => x.ProductID < 0 && ProductName != null).ToList();

           

        }
    }
}