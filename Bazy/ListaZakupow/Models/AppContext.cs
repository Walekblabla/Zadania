using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ListaZakupow.Models
{
    public class AppContext : DbContext
    {
        public AppContext() : base("ListaDB")
        {

        }
        public DbSet<ListModel> ListModels { get; set; }
    }
}