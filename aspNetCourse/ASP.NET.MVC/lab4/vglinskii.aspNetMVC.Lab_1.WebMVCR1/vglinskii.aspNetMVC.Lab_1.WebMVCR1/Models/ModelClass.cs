﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vglinskii.aspNetMVC.Lab_1.WebMVCR1.Models
{
    public class ModelClass
    {
        public static string ModelHello() {
            int hour = DateTime.Now.Hour;
            string Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            return Greeting; 
        }


    }
}