using System;
using System.Web.Mvc;
using LanguageFeatures.Models;

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
    }
}
