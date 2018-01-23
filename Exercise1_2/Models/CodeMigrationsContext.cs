using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Exercise1_2.Models
{
    public class CodeMigrationsContext: DbContext
    {
        public CodeMigrationsContext() : base("name=CodeMigrationsContext")
        {

        }

        public System.Data.Entity.DbSet<Exercise1_2.Models.User> Users { get; set; }
    }
}