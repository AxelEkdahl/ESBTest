

namespace WebApplication1.App_Start
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Data.Entity;
    public partial class SQLContext : DbContext
    {
        public SQLContext()
            : base("name=SQLContext")
        {
        }

        public virtual DbSet<User> User { get; set; }
    }
}