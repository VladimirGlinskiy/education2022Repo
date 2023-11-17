using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vglinskii.aspNet.exam.Models
{
    public class HomeController : Controller
    {
        // GET: Home
        public String Index()
        {
            string conn = "false";
            Student st;

            using (StudentDbContext dbContext = new StudentDbContext())
            {
        

                if (dbContext.Database.Exists()) {
                    conn = "Connected";
                    Console.Write(conn);
                }
                st = dbContext.Students.First() ;
            }

            /*            StudentDbContext studentDbContext = new StudentDbContext();

                        var ID = studentDbContext.Students.ToList();

                        Console.WriteLine("Start");
                        foreach (var student in ID)
                        {
                            Console.WriteLine($"{student.ID} {student.LastName}");
                        }*/
            return st.FirstName.ToString() ;
        }





    }
}