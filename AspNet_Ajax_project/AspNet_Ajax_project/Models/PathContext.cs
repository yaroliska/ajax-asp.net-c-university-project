using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNet_Ajax_project.Models
{
    public class PathContext: DbContext
    {
        public DbSet<Path> Paths { get; set; }
    }
}