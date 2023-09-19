using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public bool IsActive { get; set; }

        //Navigation Property
        public virtual List<Vote> Votes { get; set; }


    }
}