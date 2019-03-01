using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNet_Ajax_project.Models
{
    public class PathDbInitializer : DropCreateDatabaseAlways<PathContext>
    {
        protected override void Seed(PathContext db)
        {
            db.Paths.Add(new Path { xBegin = 10, yBegin = 10, xEnd=20, yEnd=10, number = 1 });
            db.Paths.Add(new Path { xBegin = 0, yBegin = 0, xEnd = 20, yEnd = 0, number = 2 });
            base.Seed(db);
        }
    }
}