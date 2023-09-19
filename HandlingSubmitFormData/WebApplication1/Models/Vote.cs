using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public int AdminId { get; set; }

        //Navigation Property
        public Admin Admin { get; set; }


       
    }

    
}