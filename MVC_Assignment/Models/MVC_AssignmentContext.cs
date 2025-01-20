using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Assignment.Models
{
    public class MVC_AssignmentContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MVC_AssignmentContext() : base("name=MVC_AssignmentContext")
        {
        }

        public System.Data.Entity.DbSet<MVC_Assignment.Models.User> Users { get; set; }
    }
}
