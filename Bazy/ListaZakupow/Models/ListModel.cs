using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListaZakupow.Models
{
    public class ListModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime LastEdit { get; set; }
    }
}