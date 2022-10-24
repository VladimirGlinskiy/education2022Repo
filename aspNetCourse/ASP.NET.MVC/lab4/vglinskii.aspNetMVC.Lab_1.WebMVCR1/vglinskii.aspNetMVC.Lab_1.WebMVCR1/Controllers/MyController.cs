using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vglinskii.aspNetMVC.Lab_1.WebMVCR1.Models;

namespace vglinskii.aspNetMVC.Lab_1.WebMVCR1.Controllers
{
    public class MyController : Controller
    {

        private static PersonRepository db = new PersonRepository();


        // GET: Home
        public ViewResult Index(string text)
         {
           // string greeting = ModelClass.ModelHello() + ", " + text;
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            ViewData["Mes"] = "хорошего настроения";
            return View();
         }


        public string Start() { 
        
        int hour = DateTime.Now.Hour;
            string Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            return Greeting;
        
        }

        [HttpGet]
        public ViewResult InputData() {
            return View(); 
        }

        [HttpPost]
        public ViewResult InputData(Person p) { 
            db.AddResponse(p);
            return View("Hello", p);
        }

        public ViewResult OutputData() {
            ViewBag.Pers = db.GetAllResponses;
            ViewBag.Counts = db.NumberOfPerson;
            return View("ListPerson");
        }
    }
}