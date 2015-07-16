using System;
using System.Data.Entity;
using System.Data.SqlTypes;

namespace EntityFrameworkDemo.DAL
{
    public class SchoolDbInitializer: DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed (SchoolContext context)
        {
           base.Seed(context);
          
        }


    }
}