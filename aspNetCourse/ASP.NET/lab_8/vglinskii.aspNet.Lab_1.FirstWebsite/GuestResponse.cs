using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace vglinskii.aspNet.Lab_1.FirstWebsite
{
    public class GuestResponse
    {
        [Key]
        public int GuestResponseIdId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
        public DateTime Rdata { get; set; }

        public virtual List<Report> Reports { get; set; }

        public GuestResponse (string name, string email, string phone, bool? willAttend)
        {
            Name = name;
            Email = email;
            Phone = phone;
            WillAttend = willAttend;
            Rdata = DateTime.Now;

            Reports = new List<Report>();
        }
        public GuestResponse() { }
    }

   public class Report
    {
        [Key] 
        public int ReportId { get; set; }
        public string NameReport { get; set; }
        public string Annotation { get; set; }

        public GuestResponse GuestRes { get; set; }

        public Report() { }

        public Report(string title, string annot) {
        
            NameReport = title;
            Annotation = annot; 

        }
    }
}