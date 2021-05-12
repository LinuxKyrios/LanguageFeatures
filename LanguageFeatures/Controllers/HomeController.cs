using System;
using System.Web.Mvc;
using LanguageFeatures.Models;
using System.Collections.Generic;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Passage to URL address displaying example";
        }

        public ViewResult AutoProperty()
        {
            //creating new object Product
            Product myProduct = new Product();

            //setting value of property
            myProduct.Name = "MacBook Pro";

            //Reading property
            string productName = myProduct.Name;

            //Generating view
            return View("result", (object)String.Format("Product name: {0}", productName));
        }

        public ViewResult CreateProduct()
        {
            Product myProduct = new Product
            {
                //setting value property with object initializR
                ProductID = 100,
                Name = "MacBook Air",
                Description = "One of the cutest ultrabooks",
                Price = 7699,
                Category = "Ultrabooks"
            };

            return View("Result", (object)String.Format("Category: {0}", myProduct.Category));
        }

        //Example of using dictionaries with collections, it is much easier and comfortable to use
        public ViewResult CreateCollection()
        {
            string[] stringArray = { "MacBook Air", "MacBook Pro", "Mac Mini", "iMac" };

            List<int> intList = new List<int> { 10, 20, 30, 40, 50 };

            Dictionary<string, int> myDict = new Dictionary<string, int>
            {
                {"MacBook Air", 10}, {"MacBook Pro", 20}, {"Mac Mini", 30}, {"iMac", 40}
            };

            return View("Result", (object)stringArray[1]);
        }
    }
}
