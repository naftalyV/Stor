using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Stor
{
    public class DBInitializer : DropCreateDatabaseAlways<StorDb>
    {
        protected override void Seed(StorDb context)
        {
            base.Seed(context);
        }
    }
}