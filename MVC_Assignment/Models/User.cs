﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Assignment.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
    }
}