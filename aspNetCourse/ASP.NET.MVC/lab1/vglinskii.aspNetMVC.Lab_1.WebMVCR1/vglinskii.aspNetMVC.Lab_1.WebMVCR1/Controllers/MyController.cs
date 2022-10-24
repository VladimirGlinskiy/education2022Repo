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
        // GET: Home
        public string Index(string text)
         {
            string greeting = ModelClass.ModelHello() + ", " + text;
            return greeting;
         }


        public string Start() { 
        
        int hour = DateTime.Now.Hour;
            string Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            return Greeting;
        
        }
    }
}