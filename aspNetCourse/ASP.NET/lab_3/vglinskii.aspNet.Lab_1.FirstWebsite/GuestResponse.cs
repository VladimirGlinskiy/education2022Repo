using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vglinskii.aspNet.Lab_1.FirstWebsite
{
    public class GuestResponse
    {
        public int GuestResponseIdId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
        public DateTime Rdata { get; set; }

        GuestResponse() { }

        public GuestResponse (string name, string email, string phone, bool? willAttend)
        {
            Name = name;
            Email = email;
            Phone = phone;
            WillAttend = willAttend;
            Rdata = DateTime.Now;
        }
    }
}