﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class MessageThread
    {
        public int MessageThreadId { get; set; }

        //Navigation Property
        public virtual List<Message> Messages { get; set; }
    }
}