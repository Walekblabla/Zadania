using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kontakt.Models
{
    public class AppContext : DbContext
    {
        public AppContext() : base ("Kontakt")
    {

    }
        public DbSet<KontaktList> KontaktLists { get; set; }
    }
}
