using Baza.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Baza.Models
{
    public class AppContext : DbContext
    {
        public AppContext() : base("TEstDB")
        {

        }
        public DbSet<TestModel> TestModels { get; set; }
    }
}